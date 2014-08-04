using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mu.Repository;

namespace Mu.Models
{
    public class Painel
    {
        public MembInfo User { get; set; }
        public Painel(MembInfo user)
        {
            User = user;
        }
        public IList<Character> GetCharacters()
        {
            var section = Mu.MvcApplication.SessionFactory.GetCurrentSession();

            return section.QueryOver<Character>().Where(i => i.Accountid == User.MembId).List();

        }

        public string Reset(string characterName)
        {
            var section = Mu.MvcApplication.SessionFactory.GetCurrentSession();
            var UserStatus = section.QueryOver<MembStat>().Where(i => i.MembId == User.MembId).SingleOrDefault();

            if (UserStatus.Connectstat != 0)
            {
                return "Deslogue do jogo antes de resetar!";
            }
            var character = section.QueryOver<Character>().Where(i => i.Accountid == User.MembId && i.Name == characterName).SingleOrDefault();

            if (User.Vip > 0)
            {
                if (character.Clevel >= 280)
                {
                    character.Clevel = 1;
                    character.Mapnumber = 0;
                    character.Mapposx = 183;
                    character.Mapposy = 120;
                    character.Mapdir = 2;
                    character.Experience = 0;
                    character.Resets = character.Resets + 1;
                    section.Update(character);
                    return "Reset efetuado com sucesso";
                }
                return "Level Insuficiente para resetar";
            }
            else if (character.Clevel >= 400)
            {
                character.Clevel = 1;
                character.Mapnumber = 0;
                character.Mapposx = 183;
                character.Mapposy = 120;
                character.Mapdir = 2;
                character.Experience = 0;
                character.Resets = character.Resets + 1;
                section.Update(character);
                return "Reset efetuado com sucesso";
            }
            else
                return "Level Insuficiente para resetar somente VIPS resetam no 280";
        }
        public void DeleteChar(string characterName)
        {
            var section = Mu.MvcApplication.SessionFactory.GetCurrentSession();

            var character = section.QueryOver<Character>().Where(i => i.Accountid == User.MembId && i.Name == characterName).SingleOrDefault();

            if (character != null)
            {
                section.Delete(character);
            }

        }
        public void DistributePoints(string CharName, int strength, int agility, int vitality, int energy)
        {
            var section = Mu.MvcApplication.SessionFactory.GetCurrentSession();
            var character = section.QueryOver<Character>().Where(i => i.Accountid == User.MembId && i.Name == CharName).SingleOrDefault();

            var totalLevelUpPoints = character.Leveluppoint;
            if (strength + agility + vitality + energy > totalLevelUpPoints)
                throw new Exception("Pontos Insificientes");

            if (character.Strength + strength > 32767 || character.Vitality + vitality > 32767 || character.Dexterity + agility > 32767 || character.Energy + energy > 32767)
                throw new Exception("Nenhum Atributo pode passar de 32767");

            if (character.Strength <= 0 || character.Dexterity <= 0 || character.Vitality <= 0 || character.Energy <= 0)
                throw new Exception("Nenhum Atributo pode passar ser menor que 1");


            try
            {
                character.Strength = (Int16)(character.Strength + strength);
                character.Vitality = (Int16)(character.Vitality + vitality);
                character.Dexterity = (Int16)(character.Dexterity + agility);
                character.Energy = (Int16)(character.Energy + energy);
                character.Leveluppoint = (Int16)(character.Leveluppoint - strength - agility - vitality - energy);
            }
            catch (Exception)
            {
                throw new Exception("Nenhum Atributo pode passar de 32767");
            }

            section.Update(character);
        }

        public void CreateTeam(string charName, string teamName)
        {
            var vld = new Validations.Inputs();
            vld.Team(teamName);
            var section = Mu.MvcApplication.SessionFactory.GetCurrentSession();
            var character = GetCharacters().Where(i => i.Name == charName).SingleOrDefault();
            if (character.MemberOfTeam != null)
            {
                throw new Exception("O Personagem " + character.Name + " já em membro do time " + character.MemberOfTeam.Name);
            }
            Team team = new Team() { Name = teamName, Lider = character, IsFull = false };
            if (team.Members == null)
                team.Members = new List<Character>();
            team.Members.Add(character);
            section.Save(team);
            character.MemberOfTeam = team;
            section.Save(character);
        }

        public void DeleteTeam(string charName)
        {
            var section = Mu.MvcApplication.SessionFactory.GetCurrentSession();

            var character = GetCharacters().Where(i => i.Name == charName).SingleOrDefault();
            var team = character.MemberOfTeam;


            if (team.Lider == character)
            {
                var requests = section.QueryOver<TeamMemberRequests>().Where(i => i.Team == team).List();
                foreach (var item in requests)
                {
                    section.Delete(item);
                }
                team.Lider = null;
                foreach (var item in team.Members)
                {
                    item.MemberOfTeam = null;
                    section.Save(item);
                }
                team.Members = null;
                section.Save(team);
                section.Delete(team);
            }
            else
                throw new Exception("Você não é o Lider do time");

        }
        public void ApllyToTeam(string CharName, int teamId)
        {
            var section = Mu.MvcApplication.SessionFactory.GetCurrentSession();
            var character = GetCharacters().Where(i => i.Name == CharName).SingleOrDefault();
            Team team = section.QueryOver<Team>().Where(i => i.Id == teamId).SingleOrDefault();
            if (section.QueryOver<TeamMemberRequests>().Where(i => i.Closed == false && i.Character == character && i.Team == team).RowCount() > 0)
                throw new Exception("Solicitação já enviada.");
            var request = new TeamMemberRequests() { Team = team, Character = character, Closed = false };
            section.Save(request);
        }
        public void AccepApplyToTeam(int requestId)
        {
            var section = Mu.MvcApplication.SessionFactory.GetCurrentSession();
            var request = section.QueryOver<TeamMemberRequests>().Where(i => i.Id == requestId).SingleOrDefault();
            if (request.Team.Members.Count() < 4)
            {
                if (request.Team.Members.Where(i => i == request.Character).Count() == 0)
                {
                    request.Team.Members.Add(request.Character);
                    request.Character.MemberOfTeam = request.Team;
                    request.Closed = true;
                    if (request.Team.Members.Count() > 4)
                    {
                        request.Team.IsFull = true;
                    }
                    var othersRquests = section.QueryOver<TeamMemberRequests>().Where(i => i.Character == request.Character).List();
                    foreach (var item in othersRquests)
                    {
                        item.Character = null;
                        item.Team = null;
                        section.Save(item);
                        section.Delete(item);
                    }
                }
            }

        }
        public void RecuseApplyToTeam(int requestId)
        {
            var section = Mu.MvcApplication.SessionFactory.GetCurrentSession();
            var request = section.QueryOver<TeamMemberRequests>().Where(i => i.Id == requestId).SingleOrDefault();
            request.Closed = true;
        }

        public void LeaveTeam(string charName)
        {
            var character = GetCharacters().Where(i => i.Name == charName).SingleOrDefault();
            character.MemberOfTeam.Members.Remove(character);
            character.MemberOfTeam = null;
        }
    }


}

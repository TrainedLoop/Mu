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

            if(UserStatus.Connectstat != 0)
            {
                return "Deslogue do jogo antes de resetar!";
            }
            var character = section.QueryOver<Character>().Where(i => i.Accountid == User.MembId && i.Name == characterName).SingleOrDefault();

            if (User.Vip > 0)
            {
                if (character.Clevel >= 350)
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
                return "Level Insuficiente para resetar somente VIPS resetam no 350";
        }
        public void DeleteChar(string characterName)
        {
            var section = Mu.MvcApplication.SessionFactory.GetCurrentSession();

            var character = section.QueryOver<Character>().Where(i => i.Accountid == User.MembId && i.Name == characterName).SingleOrDefault();
           
            if(character!= null)
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

    }


}

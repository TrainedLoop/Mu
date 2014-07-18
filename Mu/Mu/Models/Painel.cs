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

        public string DistributePoints(string characterName, int strength, int agility, int vitality, int energy)
        {
            var section = Mu.MvcApplication.SessionFactory.GetCurrentSession();
            var character = section.QueryOver<Character>().Where(i => i.Accountid == User.MembId && i.Name == characterName).SingleOrDefault();

            var totalLevelUpPoints = character.Leveluppoint;
            if (strength + agility + vitality + energy > totalLevelUpPoints)
                throw new Exception("Pontos Insificientes");
            if (strength > 32767 || agility > 32767 || vitality > 32767 || energy > 32767)
                throw new Exception("Nenhum Atributo pode passar de 32767");
            character.
            if (strength < 0 || agility < 0 || vitality < 0 || energy < 0)
                throw new Exception("Nenhum Atributo pode passar de 32767");

            return null;


        }

    }


}

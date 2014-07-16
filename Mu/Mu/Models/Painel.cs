using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mu.Repository;

namespace Mu.Models
{
    public class Painel
    {
        public MEMB_INFO User { get; set; }
        public Painel(MEMB_INFO user)
        {
            User = user;
        }
        public List<Character> GetCharacters()
        {
            using (var context = new MuOnlineEntities())
            {
                return context.Character.Where(i => i.AccountID == User.memb___id).ToList();
            }
        }
        public string Reset(string characterName)
        {
            using (var context = new MuOnlineEntities())
            {
                var character = context.Character.Where(i => i.AccountID == User.memb___id && i.Name == characterName).FirstOrDefault();
                if (User.vip > 0)
                {
                    if (character.cLevel >= 350)
                    {
                        character.cLevel = 1;
                        character.MapNumber = 0;
                        character.MapPosX = 183;
                        character.MapPosY = 120;
                        character.MapDir = 2;
                        character.Experience = 0;
                        character.resets = character.resets + 1;
                        context.SaveChanges();
                        return "Reset efetuado com sucesso";
                    }
                    return "Level Insuficiente para resetar";
                }
                else if (character.cLevel >= 400)
                {
                    character.cLevel = 1;
                    character.MapNumber = 0;
                    character.MapPosX = 183;
                    character.MapPosY = 120;
                    character.MapDir = 2;
                    character.Experience = 0;
                    context.SaveChanges();
                    return "Reset efetuado com sucesso";
                }
                else
                return "Level Insuficiente para resetar somente VIPS resetam no 350";
            }
        }

    }
}
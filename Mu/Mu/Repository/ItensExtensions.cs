using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mu.Repository
{
    public class ItensExtensions
    {
        public class Item
        {
            public CharacterExtensions.Classes Userclass { get; set; }
            public string Name { get; set; }
            public string Image { get; set; }
            public decimal Value { get; set; }

        }
        static List<Item> Swords = new List<Item>()
                {
                   
                   new Item{ Name = "Kriss", Image="/Content/Shop/Swords/kriss.bmp", Value = 2},
                   new Item{ Name = "Short Sword", Image="/Content/Shop/Swords/short.bmp", Value = 2},
                   new Item{ Name = "Rapier", Image="/Content/Shop/Swords/rapier.bmp", Value = 3},
                   new Item{ Name = "Assassin Sword", Image="/Content/Shop/Swords/assain.bmp", Value = 3},
                   new Item{ Name = "Katana", Image="/Content/Shop/Swords/katana.bmp", Value = 3},
                   new Item{ Name = "Gladius", Image="/Content/Shop/Swords/gladius.bmp", Value = 4},
                   new Item{ Name = "Falchion", Image="/Content/Shop/Swords/falchion.bmp", Value =4},
                   new Item{ Name = "Serpent Sword", Image="/Content/Shop/Swords/serpent.bmp", Value = 4},
                   new Item{ Name = "Salamender Sword", Image="/Content/Shop/Swords/short.bmp", Value = 4},
                   new Item{ Name = "Blade", Image="/Content/Shop/Swords/salamender.bmp", Value = 5},
                   new Item{ Name = "Light Saber", Image="/Content/Shop/Swords/saber.bmp", Value = 5},
                   new Item{ Name = "Legendary Sword", Image="/Content/Shop/Swords/legendary.bmp", Value = 6},
                   new Item{ Name = "Double Blade", Image="/Content/Shop/Swords/double.bmp", Value = 7},
                   new Item{ Name = "Giant Sword", Image="/Content/Shop/Swords/giant.bmp", Value = 8},
                   new Item{ Name = "Heliacal Sword", Image="/Content/Shop/Swords/heliacal.bmp", Value = 9},
                   new Item{ Name = "Lightning Sword", Image="/Content/Shop/Swords/lightning.bmp", Value = 10},
                   new Item{ Name = "Crystal Sword", Image="/Content/Shop/Swords/crystal.bmp", Value = 11},
                   new Item{ Name = "Sword of Destruction", Image="/Content/Shop/Swords/destruction.bmp", Value = 12},
                   new Item{ Name = "Spirit Sword", Image="/Content/Shop/Swords/spirit.bmp", Value = 15},
                   new Item{ Name = "Thunder Blade", Image="/Content/Shop/Swords/thunder.bmp", Value = 18},
                   new Item{ Name = "Divine Sword of Archangel", Image="/Content/Shop/Swords/archangel.bmp", Value = 20},
                   new Item{ Name = "Rune Blade", Image="/Content/Shop/Swords/rune.bmp", Value = 25},
                   new Item{ Name = "Devourer Blade", Image="/Content/Shop/Swords/devourer.bmp", Value = 25},
                   new Item{ Name = "Black Reign Blade", Image="/Content/Shop/Swords/black-reign.bmp", Value = 25},
                  
                };
        public class Sets
        {
            static List<Item> BK = new List<Item>()
            {
                new Item{ Name = "Leather", Image="/Content/Shop/Sets/bk/leather.bmp", Value = 10},
                new Item{ Name = "Bronze ", Image="/Content/Shop/Sets/bk/bronze.bmp", Value = 13},
                new Item{ Name = "Scale ", Image="/Content/Shop/Sets/bk/scale.bmp", Value = 17},
                new Item{ Name = "Brass ", Image="/Content/Shop/Sets/bk/brass.bmp", Value = 20},
                new Item{ Name = "Plate ", Image="/Content/Shop/Sets/bk/plate.bmp", Value = 25},
                new Item{ Name = "Dragon ", Image="/Content/Shop/Sets/bk/dragon.bmp", Value = 30},
                new Item{ Name = "Black Dragon", Image="/Content/Shop/Sets/bk/bdragon.bmp", Value = 40},
                new Item{ Name = "Dark Phoenix", Image="/Content/Shop/Sets/bk/phoenix.bmp", Value = 50},
                new Item{ Name = "Great Dragon", Image="/Content/Shop/Sets/bk/rphoenix.bmp", Value = 70}
                };

            static List<Item> ME = new List<Item>()
            {
                new Item{ Name = "Vine", Image="/Content/Shop/Sets/me/vine.bmp", Value = 10},
                new Item{ Name = "Silk", Image="/Content/Shop/Sets/me/silk.bmp", Value = 13},
                new Item{ Name = "Wind", Image="/Content/Shop/Sets/me/wind.bmp", Value = 17},
                new Item{ Name = "Spirit", Image="/Content/Shop/Sets/me/spirit.bmp", Value = 20},
                new Item{ Name = "Guardian", Image="/Content/Shop/Sets/me/guardian.bmp", Value = 30},
                new Item{ Name = "Divine", Image="/Content/Shop/Sets/me/divine.bmp", Value = 50},
                new Item{ Name = "Red Spirit", Image="/Content/Shop/Sets/me/redspirit.bmp", Value = 60}
            };

            static List<Item> SM = new List<Item>()
            {
                new Item{ Name = "Pad", Image="/Content/Shop/Sets/sm/pad.bmp", Value = 10},
                new Item{ Name = "Bone", Image="/Content/Shop/Sets/sm/bone.bmp", Value = 13},
                new Item{ Name = "Sphinx", Image="/Content/Shop/Sets/sm/Sphinx.bmp", Value = 17},
                new Item{ Name = "Legendary", Image="/Content/Shop/Sets/sm/legendary.bmp", Value = 30},
                new Item{ Name = "Grand Soul", Image="/Content/Shop/Sets/sm/grandsoul.bmp", Value = 50},
                new Item{ Name = "Dark Soul", Image="/Content/Shop/Sets/sm/darksoul.bmp", Value = 60}
            };
            static List<Item> MG = new List<Item>()
            {
                new Item{ Name = "Storm Crow", Image="/Content/Shop/Sets/sm/storm.bmp", Value = 30},
                new Item{ Name = "Thunder Hawk", Image="/Content/Shop/Sets/sm/thunder.bmp", Value = 50},
                new Item{ Name = "Hurricane", Image="/Content/Shop/Sets/sm/hurricane.bmp", Value = 60}
            };




        }
    }
}
//Short Sword
//Kriss
//Rapier
//Assassin Sword
//Katana
//Gladius
//Falchion
//Serpent Sword
//Salamender Sword
//Blade
//Light Saber
//Legendary Sword
//Double Blade
//Giant Sword
//Heliacal Sword
//Lightning Sword
//Crystal Sword
//Sword of Destruction
//Spirit Sword
//Thunder Blade
//Divine Sword of Archangel
//Rune Blade
//Knight Blade
//Black Reign Blade



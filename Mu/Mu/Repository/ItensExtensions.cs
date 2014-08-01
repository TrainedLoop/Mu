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
        public static List<Item> Swords = new List<Item>()
                {
                   
                   new Item{ Name = "Kriss", Image="/Content/Shop/Swords/kriss.jpg", Value = 5},
                   new Item{ Name = "Short Sword", Image="/Content/Shop/Swords/short.jpg", Value = 5},
                   new Item{ Name = "Rapier", Image="/Content/Shop/Swords/rapier.jpg", Value = 5},
                   new Item{ Name = "Assassin Sword", Image="/Content/Shop/Swords/assain.jpg", Value = 5},
                   new Item{ Name = "Katana", Image="/Content/Shop/Swords/katana.jpg", Value = 5},
                   new Item{ Name = "Gladius", Image="/Content/Shop/Swords/gladius.jpg", Value = 5},
                   new Item{ Name = "Falchion", Image="/Content/Shop/Swords/falchion.jpg", Value =5},
                   new Item{ Name = "Serpent Sword", Image="/Content/Shop/Swords/serpent.jpg", Value = 5},
                   new Item{ Name = "Salamender Sword", Image="/Content/Shop/Swords/short.jpg", Value = 5},
                   new Item{ Name = "Blade", Image="/Content/Shop/Swords/salamender.jpg", Value = 5},
                   new Item{ Name = "Light Saber", Image="/Content/Shop/Swords/saber.jpg", Value = 5},
                   new Item{ Name = "Legendary Sword", Image="/Content/Shop/Swords/legendary.jpg", Value = 6},
                   new Item{ Name = "Double Blade", Image="/Content/Shop/Swords/double.jpg", Value = 7},
                   new Item{ Name = "Giant Sword", Image="/Content/Shop/Swords/giant.jpg", Value = 8},
                   new Item{ Name = "Heliacal Sword", Image="/Content/Shop/Swords/heliacal.jpg", Value = 9},
                   new Item{ Name = "Lightning Sword", Image="/Content/Shop/Swords/lightning.jpg", Value = 10},
                   new Item{ Name = "Crystal Sword", Image="/Content/Shop/Swords/crystal.jpg", Value = 11},
                   new Item{ Name = "Sword of Destruction", Image="/Content/Shop/Swords/destruction.jpg", Value = 12},
                   new Item{ Name = "Spirit Sword", Image="/Content/Shop/Swords/spirit.jpg", Value = 15},
                   new Item{ Name = "Thunder Blade", Image="/Content/Shop/Swords/thunder.jpg", Value = 18},
                   new Item{ Name = "Divine Sword of Archangel", Image="/Content/Shop/Swords/archangel.jpg", Value = 20},
                   new Item{ Name = "Rune Blade", Image="/Content/Shop/Swords/rune.jpg", Value = 25},
                   new Item{ Name = "Devourer Blade", Image="/Content/Shop/Swords/devourer.jpg", Value = 25},
                   new Item{ Name = "Black Reign Blade", Image="/Content/Shop/Swords/black-reign.jpg", Value = 25},
                  
                };
        public static List<Item> Axes = new List<Item>()
                {
                   
                   new Item{ Name = "Small Axe", Image="/Content/Shop/Axes/small.jpg", Value = 5},
                   new Item{ Name = "Hand Axe", Image="/Content/Shop/Axes/hand.jpg", Value = 5},
                   new Item{ Name = "Double Axe", Image="/Content/Shop/Axes/double.jpg", Value = 5},
                   new Item{ Name = "Tomahawk", Image="/Content/Shop/Axes/tomahawk.jpg", Value = 5},
                   new Item{ Name = "Elven", Image="/Content/Shop/Axes/elven.jpg", Value = 5},
                   new Item{ Name = "Battle", Image="/Content/Shop/Axes/battle.jpg", Value = 5},
                   new Item{ Name = "Nikkea", Image="/Content/Shop/Axes/nikkea.jpg", Value = 5},
                   new Item{ Name = "Larkan", Image="/Content/Shop/Axes/larkan.jpg", Value = 5},
                   new Item{ Name = "Crescent Axe", Image="/Content/Shop/Axes/crescent.jpg", Value = 5},
                   new Item{ Name = "Chaos", Image="/Content/Shop/Axes/chaos.jpg", Value = 10},

                  
                };
        public static List<Item> Maces = new List<Item>()
                {                   
                   new Item{ Name = "Mace", Image="/Content/Shop/Maces/mace.jpg", Value = 5},
                   new Item{ Name = "Morning Star", Image="/Content/Shop/Maces/morning.jpg", Value = 5},
                   new Item{ Name = "Flail", Image="/Content/Shop/Maces/flail.jpg", Value = 5},
                   new Item{ Name = "Warhammer", Image="/Content/Shop/Maces/hammer.jpg", Value = 5},
                   new Item{ Name = "Crystal Mace", Image="/Content/Shop/Maces/crystal.jpg", Value = 7},                  
                };

        public class Sets
        {
            public static List<Item> BK = new List<Item>()
            {
                new Item{ Name = "Leather", Image="/Content/Shop/Sets/bk/leather.bmp", Value = 10},
                new Item{ Name = "Bronze ", Image="/Content/Shop/Sets/bk/bronze.bmp", Value = 13},
                new Item{ Name = "Scale ", Image="/Content/Shop/Sets/bk/scale.bmp", Value = 17},
                new Item{ Name = "Brass ", Image="/Content/Shop/Sets/bk/brass.bmp", Value = 20},
                new Item{ Name = "Plate ", Image="/Content/Shop/Sets/bk/plate.bmp", Value = 25},
                new Item{ Name = "Dragon ", Image="/Content/Shop/Sets/bk/dragon.bmp", Value = 30},
                new Item{ Name = "Black Dragon", Image="/Content/Shop/Sets/bk/bdragon.bmp", Value = 35},
                new Item{ Name = "Dark Phoenix", Image="/Content/Shop/Sets/bk/phoenix.bmp", Value = 40},
                new Item{ Name = "Great Dragon", Image="/Content/Shop/Sets/bk/rphoenix.bmp", Value = 50}
                };

            public static List<Item> ME = new List<Item>()
            {
                new Item{ Name = "Vine", Image="/Content/Shop/Sets/me/vine.bmp", Value = 10},
                new Item{ Name = "Silk", Image="/Content/Shop/Sets/me/silk.bmp", Value = 13},
                new Item{ Name = "Wind", Image="/Content/Shop/Sets/me/wind.bmp", Value = 17},
                new Item{ Name = "Spirit", Image="/Content/Shop/Sets/me/spirit.bmp", Value = 20},
                new Item{ Name = "Guardian", Image="/Content/Shop/Sets/me/guardian.bmp", Value = 30},
                new Item{ Name = "Divine", Image="/Content/Shop/Sets/me/divine.bmp", Value = 40},
                new Item{ Name = "Red Spirit", Image="/Content/Shop/Sets/me/redspirit.bmp", Value = 50}
            };

            public static List<Item> SM = new List<Item>()
            {
                new Item{ Name = "Pad", Image="/Content/Shop/Sets/sm/pad.bmp", Value = 10},
                new Item{ Name = "Bone", Image="/Content/Shop/Sets/sm/bone.bmp", Value = 13},
                new Item{ Name = "Sphinx", Image="/Content/Shop/Sets/sm/Sphinx.bmp", Value = 17},
                new Item{ Name = "Legendary", Image="/Content/Shop/Sets/sm/legendary.bmp", Value = 30},
                new Item{ Name = "Grand Soul", Image="/Content/Shop/Sets/sm/grandsoul.bmp", Value = 40},
                new Item{ Name = "Dark Soul", Image="/Content/Shop/Sets/sm/darksoul.bmp", Value = 50}
            };
            public static List<Item> MG = new List<Item>()
            {
                new Item{ Name = "Storm Crow", Image="/Content/Shop/Sets/mg/storm.bmp", Value = 30},
                new Item{ Name = "Thunder Hawk", Image="/Content/Shop/Sets/mg/thunder.bmp", Value = 40},
                new Item{ Name = "Hurricane", Image="/Content/Shop/Sets/mg/hurricane.bmp", Value = 50}
            };
            public static List<Item> DL = new List<Item>()
            {
                new Item{ Name = "Light Plate", Image="/Content/Shop/Sets/dl/lplate.jpg", Value = 20},
                new Item{ Name = "Adamantine ", Image="/Content/Shop/Sets/dl/adamantine.jpg", Value = 30},
                new Item{ Name = "Dark Steel", Image="/Content/Shop/Sets/dl/darksteel.jpg", Value = 40},
                new Item{ Name = "Dark Master", Image="/Content/Shop/Sets/dl/darkmaster.jpg", Value = 50}
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



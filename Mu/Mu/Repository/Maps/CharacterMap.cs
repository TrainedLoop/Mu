using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using Mu.Repository; 

namespace Mu.Repository.Maps {
    
    
    public class CharacterMap : ClassMap<Character> {
        
        public CharacterMap() {
			Table("Character");
			LazyLoad();
			Id(x => x.Name).GeneratedBy.Assigned().Column("Name");
			Map(x => x.Accountid).Column("AccountID").Not.Nullable();
			Map(x => x.Clevel).Column("cLevel");
			Map(x => x.Leveluppoint).Column("LevelUpPoint");
			Map(x => x.Class).Column("Class");
			Map(x => x.Experience).Column("Experience");
			Map(x => x.Strength).Column("Strength");
			Map(x => x.Dexterity).Column("Dexterity");
			Map(x => x.Vitality).Column("Vitality");
			Map(x => x.Energy).Column("Energy");
			Map(x => x.Inventory).Column("Inventory");
			Map(x => x.Magiclist).Column("MagicList");
			Map(x => x.Money).Column("Money");
			Map(x => x.Life).Column("Life");
			Map(x => x.Maxlife).Column("MaxLife");
			Map(x => x.Mana).Column("Mana");
			Map(x => x.Maxmana).Column("MaxMana");
			Map(x => x.Mapnumber).Column("MapNumber");
			Map(x => x.Mapposx).Column("MapPosX");
			Map(x => x.Mapposy).Column("MapPosY");
			Map(x => x.Mapdir).Column("MapDir");
			Map(x => x.Pkcount).Column("PkCount");
			Map(x => x.Pklevel).Column("PkLevel");
			Map(x => x.Pktime).Column("PkTime");
			Map(x => x.Mdate).Column("MDate");
			Map(x => x.Ldate).Column("LDate");
			Map(x => x.Ctlcode).Column("CtlCode");
			Map(x => x.Dbversion).Column("DbVersion");
			Map(x => x.Quest).Column("Quest");
			Map(x => x.Resets).Column("resets").Not.Nullable();
            References(x => x.MemberOfTeam).Column("MemberOfTeam");
        }
    }
}

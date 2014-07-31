using System;
using System.Text;
using System.Collections.Generic;


namespace Mu.Repository {
    
    public class Character {
        public virtual string Name { get; set; }
        public virtual string Accountid { get; set; }
        public virtual short? Clevel { get; set; }
        public virtual int? Leveluppoint { get; set; }
        public virtual byte? Class { get; set; }
        public virtual int? Experience { get; set; }
        public virtual short? Strength { get; set; }
        public virtual short? Dexterity { get; set; }
        public virtual short? Vitality { get; set; }
        public virtual short? Energy { get; set; }
        public virtual byte[] Inventory { get; set; }
        public virtual byte[] Magiclist { get; set; }
        public virtual int? Money { get; set; }
        public virtual float? Life { get; set; }
        public virtual float? Maxlife { get; set; }
        public virtual float? Mana { get; set; }
        public virtual float? Maxmana { get; set; }
        public virtual short? Mapnumber { get; set; }
        public virtual short? Mapposx { get; set; }
        public virtual short? Mapposy { get; set; }
        public virtual byte? Mapdir { get; set; }
        public virtual int? Pkcount { get; set; }
        public virtual int? Pklevel { get; set; }
        public virtual int? Pktime { get; set; }
        public virtual DateTime? Mdate { get; set; }
        public virtual DateTime? Ldate { get; set; }
        public virtual byte? Ctlcode { get; set; }
        public virtual byte? Dbversion { get; set; }
        public virtual byte[] Quest { get; set; }
        public virtual int Resets { get; set; }
        public virtual Team MemberOfTeam { get; set; }
    }
}

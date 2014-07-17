using System;
using System.Text;
using System.Collections.Generic;


namespace Mu.Repository {
    
    public class Warehouse {
        public virtual int Id { get; set; }
        public virtual string Accountid { get; set; }
        public virtual byte[] Items { get; set; }
        public virtual int? Money { get; set; }
        public virtual DateTime? Endusedate { get; set; }
        public virtual byte? Dbversion { get; set; }
        public virtual short? Pw { get; set; }
    }
}

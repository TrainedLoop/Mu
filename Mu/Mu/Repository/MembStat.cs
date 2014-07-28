using System;
using System.Text;
using System.Collections.Generic;


namespace Mu {
    
    public class MembStat {
        public virtual string MembId { get; set; }
        public virtual byte? Connectstat { get; set; }
        public virtual string Servername { get; set; }
        public virtual string Ip { get; set; }
        public virtual DateTime? Connecttm { get; set; }
        public virtual DateTime? Disconnecttm { get; set; }
    }
}

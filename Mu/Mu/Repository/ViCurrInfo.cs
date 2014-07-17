using System;
using System.Text;
using System.Collections.Generic;


namespace Mu.Repository {
    
    public class ViCurrInfo {
        public virtual string MembId { get; set; }
        public virtual string EndsDays { get; set; }
        public virtual string ChekCode { get; set; }
        public virtual int? UsedTime { get; set; }
        public virtual string MembName { get; set; }
        public virtual int MembGuid { get; set; }
        public virtual string SnoNumb { get; set; }
        public virtual int? BillSection { get; set; }
        public virtual int? BillValue { get; set; }
        public virtual int? BillHour { get; set; }
        public virtual int? SurplusPoint { get; set; }
        public virtual DateTime? SurplusMinute { get; set; }
        public virtual int? IncreaseDays { get; set; }
    }
}

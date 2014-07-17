using System;
using System.Text;
using System.Collections.Generic;


namespace Mu.Repository {
    
    public class MembInfo {
        public virtual string MembId { get; set; }
        public virtual int MembGuid { get; set; }
        public virtual string MembPwd { get; set; }
        public virtual string MembName { get; set; }
        public virtual string SnoNumb { get; set; }
        public virtual string PostCode { get; set; }
        public virtual string AddrInfo { get; set; }
        public virtual string AddrDeta { get; set; }
        public virtual string TelNumb { get; set; }
        public virtual string PhonNumb { get; set; }
        public virtual string MailAddr { get; set; }
        public virtual string FpasQues { get; set; }
        public virtual string FpasAnsw { get; set; }
        public virtual string JobCode { get; set; }
        public virtual DateTime? ApplDays { get; set; }
        public virtual DateTime? ModiDays { get; set; }
        public virtual DateTime? OutDays { get; set; }
        public virtual DateTime? TrueDays { get; set; }
        public virtual string MailChek { get; set; }
        public virtual string BlocCode { get; set; }
        public virtual string Ctl1Code { get; set; }
        public virtual int Creditos { get; set; }
        public virtual int Vip { get; set; }
    }
}

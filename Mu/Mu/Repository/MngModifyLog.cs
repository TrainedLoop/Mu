//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mu.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class MngModifyLog
    {
        public int Number { get; set; }
        public string ManagerID { get; set; }
        public string AccountId { get; set; }
        public string GameID { get; set; }
        public Nullable<byte> servernumber { get; set; }
        public string IP { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public Nullable<short> LogType { get; set; }
        public string LogText { get; set; }
    }
}

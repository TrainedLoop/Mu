using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using Mu.Repository; 

namespace Mu.Repository.Maps {
    
    
    public class ViCurrInfoMap : ClassMap<ViCurrInfo> {
        
        public ViCurrInfoMap() {
			Table("VI_CURR_INFO");
			LazyLoad();
			Id(x => x.MembId).GeneratedBy.Assigned().Column("memb___id");
			Map(x => x.EndsDays).Column("ends_days");
			Map(x => x.ChekCode).Column("chek_code").Not.Nullable();
			Map(x => x.UsedTime).Column("used_time");
			Map(x => x.MembName).Column("memb_name").Not.Nullable();
			Map(x => x.MembGuid).Column("memb_guid").Not.Nullable();
			Map(x => x.SnoNumb).Column("sno__numb").Not.Nullable();
			Map(x => x.BillSection).Column("Bill_Section");
			Map(x => x.BillValue).Column("Bill_Value");
			Map(x => x.BillHour).Column("Bill_Hour");
			Map(x => x.SurplusPoint).Column("Surplus_Point");
			Map(x => x.SurplusMinute).Column("Surplus_Minute");
			Map(x => x.IncreaseDays).Column("Increase_Days");
        }
    }
}

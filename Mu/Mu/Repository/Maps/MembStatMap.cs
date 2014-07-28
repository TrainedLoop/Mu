using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using Mu; 

namespace Mu.Maps {
    
    
    public class MembStatMap : ClassMap<MembStat> {
        
        public MembStatMap() {
			Table("MEMB_STAT");
			LazyLoad();
			Id(x => x.MembId).GeneratedBy.Assigned().Column("memb___id");
			Map(x => x.Connectstat).Column("ConnectStat");
			Map(x => x.Servername).Column("ServerName");
			Map(x => x.Ip).Column("IP");
			Map(x => x.Connecttm).Column("ConnectTM");
			Map(x => x.Disconnecttm).Column("DisConnectTM");
        }
    }
}

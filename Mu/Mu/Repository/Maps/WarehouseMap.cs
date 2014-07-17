using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using Mu.Repository; 

namespace Mu.Repository.Maps {
    
    
    public class WarehouseMap : ClassMap<Warehouse> {
        
        public WarehouseMap() {
			Table("warehouse");
			LazyLoad();
            Id(x => x.Id).GeneratedBy.Assigned().Column("Id");
			Map(x => x.Accountid).Column("AccountID").Not.Nullable();
			Map(x => x.Items).Column("Items");
			Map(x => x.Money).Column("Money");
			Map(x => x.Endusedate).Column("EndUseDate");
			Map(x => x.Dbversion).Column("DbVersion");
			Map(x => x.Pw).Column("pw");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;

namespace Mu.Repository.Maps
{

    public class ShopCartMap : ClassMap<ShopCart>
    {
        public ShopCartMap()
        {
            Table("ShopCart");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Assigned().Column("Id");
            References(x => x.User);
            HasMany(i => i.Itens).AsBag().Cascade.All();
            Map(i => i.IsOpen).Column("IsOpen");
        }

    }
}

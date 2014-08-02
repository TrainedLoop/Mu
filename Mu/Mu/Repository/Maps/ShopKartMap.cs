using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;

namespace Mu.Repository.Maps
{

    public class ShopKartMap : ClassMap<ShopKart>
    {
        public ShopKartMap()
        {
            Table("ShopCart");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("Id");
            References(x => x.User);
            HasMany(i => i.Requests).AsBag().Cascade.All();
            Map(i => i.IsOpen).Column("IsOpen");
        }

    }
}

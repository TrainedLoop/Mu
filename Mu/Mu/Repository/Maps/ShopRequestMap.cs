using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mu.Repository.Maps
{
    public class ShopRequestMap : ClassMap<ShopRequest>
    {
        public ShopRequestMap()
        {
            Table("ShopRequest");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("Id");
            References(x => x.Item);
            References(x => x.Cart);
        }

    }
}
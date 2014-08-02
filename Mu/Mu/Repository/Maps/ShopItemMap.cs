using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;

namespace Mu.Repository.Maps
{
    public class ShopItemMap : ClassMap<ShopItem>
    {
        public ShopItemMap()
        {
            Table("ShopItem");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("Id");
            Map(x => x.ItemName).Column("ItemName");
            Map(x => x.ItemValue).Column("ItemValue");
            Map(x => x.AddOptions).Column("AddOptions");
        }

    }
}
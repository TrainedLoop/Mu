using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mu.Repository
{
    public class ShopItem
    {
        public virtual int Id { get; set; }
        public virtual string ItemName { get; set; }
        public virtual decimal ItemValue { get; set; }
    }
}
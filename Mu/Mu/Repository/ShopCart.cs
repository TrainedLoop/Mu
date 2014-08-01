using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mu.Repository
{
    public class ShopCart
    {
        public virtual int Id { get; set; }
        public virtual IList<ShopItem> Itens { get; set; }
        public virtual MembInfo User { get; set; }
        public virtual bool IsOpen { get; set; }
    }
}
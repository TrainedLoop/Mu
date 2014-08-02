using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mu.Repository
{
    public class ShopRequest
    {
        public virtual int Id { get; set; }
        public virtual ShopItem Item { get; set; }
        public virtual ShopKart Cart { get; set; }
    }
}
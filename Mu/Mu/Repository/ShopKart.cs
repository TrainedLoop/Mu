using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mu.Repository
{
    public class ShopKart
    {
        public virtual int Id { get; set; }
        public virtual IList<ShopRequest> Requests { get; set; }
        public virtual MembInfo User { get; set; }
        public virtual bool IsOpen { get; set; }
    }
}
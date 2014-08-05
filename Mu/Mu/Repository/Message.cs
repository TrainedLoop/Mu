using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mu.Repository
{
    public class Message
    {
        public virtual int Id { get; set; }
        public virtual string MessageString { get; set; }
        public virtual MembInfo FromUser { get; set; }
        public virtual MembInfo ToUser { get; set; }
        public virtual bool ToAdm { get; set; }
        public virtual bool Answered { get; set; }
    }
}
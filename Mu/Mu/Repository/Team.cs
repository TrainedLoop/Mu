using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mu.Repository;

namespace Mu.Repository
{
    public class Team
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int Score { get; set; }
        public virtual string Img { get; set; }
        public virtual bool IsFull { get; set; }
        public virtual Character Lider { get; set; }
        public virtual IList<Character> Members { get; set; }

    }
}
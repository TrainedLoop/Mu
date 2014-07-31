using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mu.Repository
{
    public class TeamMemberRequests
    {
        public virtual int Id { get; set; }
        public virtual Character Character { get; set; }
        public virtual Team Team { get; set; }
        public virtual bool Closed { get; set; }
    }
}
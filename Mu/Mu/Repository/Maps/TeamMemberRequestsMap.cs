using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;

namespace Mu.Repository.Maps
{
    public class TeamMemberRequestsMap : ClassMap<TeamMemberRequests>
    {

        public TeamMemberRequestsMap()
        {
            Table("TeamMemberRequests");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Assigned().Column("Id");
            References(x => x.Character);
            References(x => x.Team);
            Map(x => x.Closed).Column("Closed");
        }

    }
}
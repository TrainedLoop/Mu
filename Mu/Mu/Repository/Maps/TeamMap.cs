﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;

namespace Mu.Repository.Maps
{
    public class TeamMap :  ClassMap<Team>
    {

        public TeamMap()
        {
			Table("Team");
			LazyLoad();
			Id(x => x.Id).GeneratedBy.Assigned().Column("Id");
			Map(x => x.Name).Column("Name");
            Map(x => x.Score).Column("Score");
            Map(x => x.Img).Column("img").Nullable();
            References(x => x.Lider);
            HasMany(x => x.Members).AsBag().Cascade.All();
        }
    }
}
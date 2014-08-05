using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;

namespace Mu.Repository.Maps
{
    public class MessageMap : ClassMap<Message>
    {

        public MessageMap()
        {
            Table("Message");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("Id");
            Map(x => x.MessageString).Column("MessageString");
            Map(x => x.ToAdm).Column("ToAdm");
            Map(x => x.Answered).Column("Answered");
            References(i => i.ToUser);
            References(i => i.FromUser);
        }
    }
}
using Mu.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mu.Models
{
    public class Message
    {
        public MembInfo User { get; set; }

        public Message(MembInfo user)
        {
            User = user;
        }
        public IList<Mu.Repository.Message> GetMessages(bool OnlyOpenMessages = true)
        {
            var section = Mu.MvcApplication.SessionFactory.GetCurrentSession();
            var messages = section.QueryOver<Mu.Repository.Message>().Where(i => i.ToUser == User).List();
            if (OnlyOpenMessages)
            {
                messages = messages.Where(i => i.Answered == false).ToList();
            }
            return messages;
        }
        public static IList<Mu.Repository.Message> GetAdmMessages(bool OnlyOpenMessages = true)
        {
            var section = Mu.MvcApplication.SessionFactory.GetCurrentSession();
            var messages = section.QueryOver<Mu.Repository.Message>().Where(i => i.ToAdm == true).List();
            if (OnlyOpenMessages)
            {
                messages = messages.Where(i => i.Answered == false).ToList();
            }
            return messages;
        }

        public void SendMessageToAdm(string messageString)
        {
            var section = Mu.MvcApplication.SessionFactory.GetCurrentSession();

            Repository.Message message = new Repository.Message();
            message.FromUser = User;
            message.ToAdm = true;
            message.MessageString = messageString;
            message.Answered = false;
            section.Save(message);
        }
        public static void SendMessagePlayer(string messageString, MembInfo User)
        {
            var section = Mu.MvcApplication.SessionFactory.GetCurrentSession();
            Repository.Message message = new Repository.Message();
            message.FromUser = User;
            message.ToAdm = false;
            message.MessageString = messageString;
            message.Answered = false;
            section.Save(message);
        }
    }
}
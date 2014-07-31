using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using Mu.Repository;

namespace Mu.Models.Validations
{
    public class Inputs
    {
        private class RegularExpressions
        {
            public static Regex Email() { return new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$"); }
            public static Regex Password() { return new Regex(@"^(?=[^\d_].*?\d)\w(\w|[!@#$%]){4,10}"); }
        }
        private class ErrorMessages
        {
            //User
            public const string UserEmpty = "Digite Seu ID";
            public const string UserInvalid = "ID com no maximo 10 caracteres e no minimo 4";
            public const string UserExist = "Usuario já existe";
            //Emails
            public const string EmailEmpty = "Digite Seu Email";
            public const string EmailInvalid = "Email Invalido";
            //Password
            public const string PasswordInvalid = "A senha deve ter pelo menos uma letra e um numero e ser de 4 a 10 caracteres";
            public const string PasswordNotSame = "Senhas não correspondem";

            //User
            public const string TeamNameExist = "Esse Time Já Existe";
            public const string TeamNameInvalid = "Time com no maximo 10 caracteres e no minimo 4";

        }
        public void UserID(string UserID)
        {
            if (string.IsNullOrEmpty(UserID))
                throw new Exception(ErrorMessages.UserEmpty);

            if (UserID.Length > 10 || UserID.Length < 4)
                throw new Exception(ErrorMessages.UserInvalid);


            var section = Mu.MvcApplication.SessionFactory.GetCurrentSession();
            if (section.QueryOver<MembInfo>().Where(i => i.MembId == UserID).RowCount() > 0)
                throw new Exception(ErrorMessages.UserExist);

        }


        public void Team(string TeamName)
        {
            if (string.IsNullOrEmpty(TeamName))
                throw new Exception(ErrorMessages.TeamNameInvalid);

            if (TeamName.Length > 10 || TeamName.Length < 4)
                throw new Exception(ErrorMessages.TeamNameInvalid);


            var section = Mu.MvcApplication.SessionFactory.GetCurrentSession();
            if (section.QueryOver<Team>().Where(i => i.Name == TeamName).RowCount() > 0)
                throw new Exception(ErrorMessages.TeamNameExist);

        }

        public void EmailString(string email)
        {
            if (string.IsNullOrEmpty(email))
                throw new Exception(ErrorMessages.EmailEmpty);

            if (!RegularExpressions.Email().IsMatch(email) || email.Length > 50)
                throw new Exception(ErrorMessages.EmailInvalid);

        }

        public void PasswordString(string password)
        {

            if (!RegularExpressions.Password().IsMatch(password))
                throw new Exception(ErrorMessages.PasswordInvalid);
        }
        public void PasswordString(string password1, string password2)
        {

            if (!RegularExpressions.Password().IsMatch(password1))
                throw new Exception(ErrorMessages.PasswordInvalid);
            if (password1 != password2)
                throw new Exception(ErrorMessages.PasswordNotSame);
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;

namespace Mu.Models.Validations
{
    public class Inputs
    {
        private class RegularExpressions
        {
            public static Regex Email() { return new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$"); }
            public static Regex Password() { return new Regex(@"^(?=[^\d_].*?\d)\w(\w|[!@#$%]){4,16}"); }
        }
        private class ErrorMessages
        {
            public const string UserEmpty = "Digite Seu ID";
            public const string UserInvalid = "ID com no maximo 16 caracteres";
            //Emails
            public const string EmailEmpty = "Digite Seu Email";
            public const string EmailInvalid = "Email Invalido";
            //Password
            public const string PasswordInvalid = "A senha deve ter pelo menos uma letra e um numero e ser de 4 a 16 caracteres";
            public const string PasswordNotSame = "Senhas não correspondem";
            //IP
            public const string IPInvalid = "Senhas não correspondem";
        }
        public void UserID(string UserID)
        {
            if (string.IsNullOrEmpty(UserID))
                throw new Exception(ErrorMessages.UserEmpty);

            if (UserID.Length> 16)
                throw new Exception(ErrorMessages.EmailInvalid);

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
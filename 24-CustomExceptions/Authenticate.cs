using System;

namespace _24_CustomExceptions
{
    public class AuthenticationException : Exception
    {
        public AuthenticationException(string message) : base(message)
        {

        }
    }
    public class UserInvalidException : AuthenticationException
    {
        public UserInvalidException(string message) : base(message)
        {

        }
    }

    public class PasswordInvalidException : AuthenticationException
    {
        public PasswordInvalidException(string message) : base(message)
        {

        }
    }


    public static class Authenticate
    {
        public static void Authentic(string user, string password)
        {
            if(user != "adm")
                throw new UserInvalidException("User Invalid");
            if(password != "adm")
                throw new PasswordInvalidException("Password Invalid");
        }
    }
}

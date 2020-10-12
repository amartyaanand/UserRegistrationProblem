using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    public class InvalidUserDetailException : Exception
    {
        public enum ExceptionType
        {
            INVALID_FIRSTNAME,
            INVALID_LASTNAME,
            INVALID_EMAIL,
            INVALID_PASSWORD,
            INVALID_MOBILE
        }
        private ExceptionType type;
        public InvalidUserDetailException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class RegexValidation
    {
        public const string REGEX_FIRSTNAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string REGEX_LASTNAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string REGEX_EMAIL = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
        public const string REGEX_MOBILENUMBER = "^[1-9]{1}[0-9]{0,3}\\s[1-9]{1}[0-9]{9}$";
        //  \S matches any non-whitespace character
        public const string REGEX_PASSWORD = "^(?=.*[A-Z])(?=.*\\d)(?=[\\w]*[\\W][\\w]*$)[\\S]{8,}$";
        public bool ValidateFirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, REGEX_FIRSTNAME))
                return true;
            else
                throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_FIRSTNAME, "Invalid First Name");
        }
        public bool ValidateLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, REGEX_LASTNAME))
                return true;
            else
                throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_LASTNAME, "Invalid Last Name");
        }
        public bool ValidateEmail(string email)
        {
            if (Regex.IsMatch(email, REGEX_EMAIL))
                return true;
            else
                throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_EMAIL, "Invalid Email");
        }
        public bool ValidateMobile(string mobileNum)
        {
            if (Regex.IsMatch(mobileNum, REGEX_MOBILENUMBER))
                return true;
            else
                throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_MOBILE, "Invalid Mobile Number");
        }
        public bool ValidatePassword(string password)
        {
            if (Regex.IsMatch(password, REGEX_PASSWORD))
                return true;
            else
                throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_PASSWORD, "Invalid Password");
        }
    }
}
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
        public bool ValidateFirstName(string firstName) => (Regex.IsMatch(firstName, REGEX_FIRSTNAME));
        public bool ValidateLastName(string lastName) => (Regex.IsMatch(lastName, REGEX_LASTNAME));
        public bool ValidateEmail(string email) => (Regex.IsMatch(email, REGEX_EMAIL));
        public bool ValidateMobile(string mobNumber) => (Regex.IsMatch(mobNumber, REGEX_MOBILENUMBER));
        public bool ValidatePassword(string password) => (Regex.IsMatch(password, REGEX_PASSWORD));
    }
}
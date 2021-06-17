using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationSystem
{
    class UserRegistration
    {
        public string REGEX_FIRSTNAME = "^[A-Z][a-z]{2,}$";
        public string REGEX_LASTNAME= "^[A-Z][a-z]{2,}$";
        public string REGEX_EMAIL = "^[a-zA-Z0-9]+([.][A-Za-z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]+)?$";
        public bool ValidateFirstName(string firstname)
        {
            return Regex.IsMatch(firstname,REGEX_FIRSTNAME);
        }
        public bool ValidateLastName(string lastname)
        {
            return Regex.IsMatch(lastname, REGEX_LASTNAME);
        }
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }
    }
}

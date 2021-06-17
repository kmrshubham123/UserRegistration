using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationSystem
{
    class UserRegistration
    {
        public string REGEX_FIRSTNAME = "^[A-Z][a-z]{2,}$";
        public bool ValidateFirstName(string firstname)
        {
            return Regex.IsMatch(firstname,REGEX_FIRSTNAME);
        }
    }
}

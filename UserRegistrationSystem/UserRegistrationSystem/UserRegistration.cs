using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions; //allow the pattern matching

namespace UserRegistrationSystem
{
    class UserRegistration
    {
        public string REGEX_FIRSTNAME = "^[A-Z][a-z]{2,}$";
        public string REGEX_LASTNAME= "^[A-Z][a-z]{2,}$";
        public string REGEX_EMAIL = "^[a-zA-Z0-9]+([.][A-Za-z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]+)?$";
        public string REGEX_MOBILENUMBER = "^[1-9]{1,3}[ ][0-9]{10}$";
        public string REGEX_PASSWORDFIRST = "^[a-zA-Z0-9-+_!@#$%^&*.,?]{8,}$";
        public string REGEX_PASSWORDSECOND="^(?=.*[A-Z])[A-Za-z0-9!@#$%^&*]{8,}$";
        public string REGEX_PASSWORDTHIRD = "^(?=.*[A-Z])(?=.*[0-9])[A-Za-z0-9-+_!@#$%^&*.,?]{8,}$";
        public string REGEX_PASSWORDFOURTH = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[-+_!@#$%^&*.,?{}()<>])[A-Za-z0-9-+_!@#$%^&*.,?]{8,}$";
        public string REGEX_ALLEMAIL = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([a-zA-Z]{2,3}){0,1}";
        public bool ValidateFirstName(string firstname)
        {
            return Regex.IsMatch(firstname,REGEX_FIRSTNAME); // Returns:True if the regular Expression find the match
        }                                                     //otherwise:False
        public bool ValidateLastName(string lastname)
        {
            return Regex.IsMatch(lastname, REGEX_LASTNAME);
        }
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }
        public bool ValidateMobileNumber(string mobilenumber)
        {
            return Regex.IsMatch(mobilenumber, REGEX_MOBILENUMBER);
        }
        public bool ValidatePasswordFirst(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORDFIRST);
        }
        public bool ValidatePasswordSecond(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORDSECOND);
        }
        public bool ValidatePasswordThird(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORDTHIRD);
        }
        public bool ValidatePasswordFourth(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORDFOURTH);
        }
        public bool ValidateAllEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_ALLEMAIL); // Returns:True if the regular Expression find the match
        }                                                //otherwise:False

    }
}

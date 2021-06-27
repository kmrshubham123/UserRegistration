using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions; //allow the pattern matching

namespace UserRegistrationSystem
{
    public class UserRegistration
    {
        public string REGEX_FIRSTNAME = "^[A-Z][a-z]{2,}$";
        public string REGEX_LASTNAME= "^[A-Z][a-z]{2,}$";
        public string REGEX_EMAIL = "^[a-zA-Z0-9]+([.][A-Za-z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]+)?$";
        public string REGEX_MOBILENUMBER = "^[1-9]{1,3}[ ][0-9]{10}$";
        public string REGEX_PASSWORD = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[-+_!@#$%^&*.,?{}()<>])[A-Za-z0-9-+_!@#$%^&*.,?]{8,}$";
        public string REGEX_ALLEMAIL = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([a-zA-Z]{2,3}){0,1}([.][a-zA-Z]{2,3})?$";
        //UC13:-Use Lambda Function to validate User Entry
        public bool ValidateFirstName(string firstName) => (Regex.IsMatch(firstName, REGEX_FIRSTNAME));
        public bool ValidateLastName(string lastName) => (Regex.IsMatch(lastName, REGEX_LASTNAME));
        public bool ValidateEmail(string email) => (Regex.IsMatch(email, REGEX_EMAIL));
        public bool ValidateMobileNumber(string mobNumber) => (Regex.IsMatch(mobNumber, REGEX_MOBILENUMBER));
        public bool ValidatePassword(string password) => (Regex.IsMatch(password, REGEX_PASSWORD));
        public bool ValidateAllEmail(string allEmail) => (Regex.IsMatch(allEmail, REGEX_ALLEMAIL));
        public void PrintResult(bool result)
        {
            if (result)
            {
                Console.WriteLine("Valid.");
            }
            else
            {
                Console.WriteLine("Invalid.");
            }
        }
        public List<string> sampleEMails = new List<string>
        {
            "abc@yahoo.com",
            "abc-100@yahoo.com",
            "abc.100@yahoo.com",
            "abc111@abc.com",
            "abc-100@abc.net",
            "abc.100@abc.com.au",
            "abc@1.com",
            "abc@gmail.com.com",
            "abc+100@gmail.com"
        };
        public List<string> GetList()
        {
            return sampleEMails;
        }

    }
}

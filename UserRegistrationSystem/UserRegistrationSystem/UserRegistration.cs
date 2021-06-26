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
        public string REGEX_ALLEMAIL = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([a-zA-Z]{2,3}){0,1}$";
        /// <summary>
        /// Validate First Name 
        /// </summary>
        /// <param name="firstName"></param>
        /// <returns></returns>
        public bool ValidateFirstName(string firstName)
        {
            try
            {
                if (Regex.IsMatch(firstName, REGEX_FIRSTNAME))
                {
                    return true;
                }
                else
                {
                    throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_FIRST_NAME, "Invalid first name.");
                }
            }
            catch (InvalidUserDetailException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false; 

        }
        /// <summary>
        /// validate Last Name
        /// </summary>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public bool ValidateLastName(string lastName)
        {
            try
            {
                if (Regex.IsMatch(lastName, REGEX_LASTNAME))
                {
                    return true;
                }
                else
                {
                    throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_LAST_NAME, "Invalid last name.");
                }
            }
            catch (InvalidUserDetailException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;

        }
        /// <summary>
        /// Validate Email Address
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool ValidateEmail(string email)
        {
            try
            {
                if (Regex.IsMatch(email, REGEX_EMAIL))
                {
                    return true;
                }
                else
                {
                    throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_EMAIL, "Invalid email id.");
                }
            }
            catch (InvalidUserDetailException ex) 
            { 
                Console.WriteLine(ex.Message); 
            }
            return false;
        }
        /// <summary>
        /// Validate Mobile Number
        /// </summary>
        /// <param name="mobNumber"></param>
        /// <returns></returns>
        public bool ValidateMobileNumber(string mobNumber)
        {
            try
            {
                if (Regex.IsMatch(mobNumber, REGEX_MOBILENUMBER))
                {
                    return true;
                }
                else
                {
                    throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_MOBILE_NUMBER, "Invalid mobile number.");
                }
            }
            catch (InvalidUserDetailException ex) 
            { 
                Console.WriteLine(ex.Message); 
            }
            return false;
        }

        public bool ValidatePassword(string password)
        {
            try
            {
                if (Regex.IsMatch(password, REGEX_PASSWORD))
                {
                    return true;
                }
                else
                {
                    throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_PASSWORD, "Invalid password.");
                }
            }
            catch (InvalidUserDetailException ex) 
            { 
                Console.WriteLine(ex.Message); 
            }
            return false;
        }
        public bool ValidateAllEmail(string email)
        {
            try
            {
                if (Regex.IsMatch(email, REGEX_ALLEMAIL))
                {
                    return true;
                }
                else
                {
                    throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_EMAIL, "Invalid email id.");
                }
            }
            catch (InvalidUserDetailException ex) 
            { 
                Console.WriteLine(ex.Message); 
            }
            return false;
        }

    }
}

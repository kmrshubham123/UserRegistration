using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationSystem
{
    /// <summary>
    ///  Regex Validations Custom exceptions class derived from Exception class
    ///  Exception:Represent error that occur during application Execution
    /// </summary>
    public class InvalidUserDetailException : Exception
    {
        public enum ExceptionType
        {
            INVALID_FIRST_NAME,
            INVALID_LAST_NAME,
            INVALID_EMAIL,
            INVALID_MOBILE_NUMBER,
            INVALID_PASSWORD
        }
        //creating 'type' variable of the type ExceptionType
        private ExceptionType type;
        /// <summary>
        ///Parameterized constructor sets the Exception Type and message
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        public InvalidUserDetailException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}

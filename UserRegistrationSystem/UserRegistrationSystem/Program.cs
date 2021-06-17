using System;

namespace UserRegistrationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Welcome to User Registration System****");
            UserRegistration registration = new UserRegistration();
            //UC1:-Enter Valid First Name
            Console.WriteLine(registration.ValidateFirstName("Kumar"));
            //UC2:-Enter Valid Last Name
            Console.WriteLine(registration.ValidateLastName("Shubham"));
            //UC3:-Enter Valid Email
            Console.WriteLine(registration.ValidateEmail("kmrshubham123@gmail.com"));


        }
    }
}

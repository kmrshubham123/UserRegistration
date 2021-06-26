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
            Console.WriteLine("First Name:- "+registration.ValidateFirstName("Ku"));
            //UC2:-Enter Valid Last Name
            Console.WriteLine("Last Name:- "+registration.ValidateLastName("hubam"));
            //UC3:-Enter Valid Email
            Console.WriteLine("Email:- "+registration.ValidateEmail("+kmi8gmalcom"));
            //UC4:-Enter Valid MobileNumber
            Console.WriteLine("Mob No:- "+registration.ValidateMobileNumber("917060731565"));
            //UC5,6,7,8:-Rule 1,2,3,4=minimum 8 digit, one Upper Case,Atleast one Numeric value,Exactly one Special Character
            Console.WriteLine("Password:- "+registration.ValidatePassword("kk598*huyfr"));
            Console.WriteLine("==================");
            //UC9:-vaildate All types of sample Email
            Console.WriteLine("Sample All Email:- ");
            Console.WriteLine("1 Email: "+registration.ValidateAllEmail("abc@yahoo.com"));
            Console.WriteLine("2 Email: "+registration.ValidateAllEmail("abc-100@yahoo.com"));
            Console.WriteLine("3 Email: "+registration.ValidateAllEmail("abc.100@yahoo.com"));
            Console.WriteLine("4 Email: "+registration.ValidateAllEmail("abc111@abc.com"));
            Console.WriteLine("5 Email: "+registration.ValidateAllEmail("abc-100@yabc.net"));
            Console.WriteLine("6 Email: "+registration.ValidateAllEmail("abc.100@abc.com.au.abc"));
            Console.WriteLine("7 Email: "+registration.ValidateAllEmail("abc@1.com"));
            Console.WriteLine("8 Email: "+registration.ValidateAllEmail("abc@gmail.com.com.com.com.com"));
            Console.WriteLine("9 Email: "+registration.ValidateAllEmail("abc+100@ygmail.com"));


        }
    }
}

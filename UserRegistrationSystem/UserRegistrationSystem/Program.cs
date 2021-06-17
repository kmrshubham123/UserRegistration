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
            Console.WriteLine("First Name:- "+registration.ValidateFirstName("Kumar"));
            //UC2:-Enter Valid Last Name
            Console.WriteLine("Last Name:- "+registration.ValidateLastName("Shubham"));
            //UC3:-Enter Valid Email
            Console.WriteLine("Email:- "+registration.ValidateEmail("kmrshubham123@gmail.com"));
            //UC4:-Enter Valid MobileNumber
            Console.WriteLine("Mob No:- "+registration.ValidateMobileNumber("91 7060731565"));
            //UC5:-Rule 1=Password minimum 8 digit 
            Console.WriteLine("Password1:- "+registration.ValidatePasswordFirst("+58lkuj@#"));
            //UC6:-Rule 2=Should have one Upper Case
            Console.WriteLine("Password2:- "+registration.ValidatePasswordSecond("K8*pj&%iou"));
            //UC7:-Rule 3=Atleast one Numeric value
            Console.WriteLine("Password3:- "+registration.ValidatePasswordThird("k5k*&ypK"));
            //UC8:-Rule 4=Has Exactly one Special Character
            Console.WriteLine("Password4:- "+registration.ValidatePasswordFourth("Mk598*huyfr"));
            Console.WriteLine("======");
            //UC9:-vaildate All types of sample Email
            Console.WriteLine("Sample All Email:- ");
            Console.WriteLine(registration.ValidateAllEmail("abc@yahoo.com"));
            Console.WriteLine(registration.ValidateAllEmail("abc-100@yahoo.com"));
            Console.WriteLine(registration.ValidateAllEmail("abc.100@yahoo.com"));
            Console.WriteLine(registration.ValidateAllEmail("abc111@abc.com"));
            Console.WriteLine(registration.ValidateAllEmail("abc-100@yabc.net"));
            Console.WriteLine(registration.ValidateAllEmail("abc.100@abc.com.au"));
            Console.WriteLine(registration.ValidateAllEmail("abc@1.com"));
            Console.WriteLine(registration.ValidateAllEmail("abc@gmail.com.com"));
            Console.WriteLine(registration.ValidateAllEmail("abc+100@ygmail.com"));






        }
    }
}

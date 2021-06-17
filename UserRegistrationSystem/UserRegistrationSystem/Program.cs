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
            //UC4:-Enter Valid MobileNumber
            Console.WriteLine(registration.ValidateMobileNumber("91 7060731565"));
            //UC5:-Rule 1=Password minimum 8 digit 
            Console.WriteLine(registration.ValidatePasswordFirst("+58lkuj@#"));
            //UC6:-Rule 2=Should have one Upper Case
            Console.WriteLine(registration.ValidatePasswordSecond("K8*pj&%iou"));
            //UC7:-Rule 3=Atleast one Numeric value
            Console.WriteLine(registration.ValidatePasswordThird("k5k*&ypK"));






        }
    }
}

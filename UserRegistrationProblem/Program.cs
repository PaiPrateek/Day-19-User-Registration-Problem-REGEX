using System;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem");
            Console.WriteLine("\n");

            //Validation for First Name
            //CheckFirstName();

            //Validation For Last Name
            //CheckLastName();

            //Validation for Email
            CheckEmail();
        }
        //Creating Method for checking the valid FirstName
        public static void CheckFirstName()
        {
            Console.WriteLine("Enter FirstName");
            Console.WriteLine("\nNote: First Name Should Starts with Capital Letter and it should have atleast 3 Characters.");
            string input = Console.ReadLine();
            //Regex Patter for validating the First Name
            string FirstNamePattern = @"^[A-Z]{1,}[a-zA-Z]{2,}$";
            Console.WriteLine("\n");

            Regex FirstNameRegex = new Regex(FirstNamePattern);
            var Result = FirstNameRegex.IsMatch(input);
            if (Result)
            {
                Console.WriteLine("The Entered First Name is Registered Successfully");
            }
            else
            {
                Console.WriteLine("Enter Valid First Name");
            }
        }

        //Creating Method for checking the valid LastName
        public static void CheckLastName()
        {
            Console.WriteLine("Enter Last Name");
            Console.WriteLine("\nNote: Last Name Should Starts with Capital Letter and it should have atleast 3 Characters.");
            string input = Console.ReadLine();
            //Regex Patter for validating the Last Name
            string LastNamePattern = @"^[A-Z]{1,}[a-zA-Z]{2,}$";
            Console.WriteLine("\n");

            Regex LastNameRegex = new Regex(LastNamePattern);
            var Result = LastNameRegex.IsMatch(input);
            if (Result)
            {
                Console.WriteLine("The Entered Last Name is Registered Successfully");
            }
            else
            {
                Console.WriteLine("Enter Valid Last Name");
            }
        }
        //Creating Method for checking the valid LastName
        public static void CheckEmail()
        {
            Console.WriteLine("Enter Email");
            string input = Console.ReadLine();
            //Regex Patter for validating the Email
            string EmailPattern = @"^([A-Za-z]{3,}([.a-z]*)[@][a-z]{2,}[.][a-z]{2,3}([.a-z]*))$";
            Console.WriteLine("\n");

            Regex EmailRegex = new Regex(EmailPattern);
            var Result = EmailRegex.IsMatch(input);
            if (Result)
            {
                Console.WriteLine("The Entered Email is Registered Successfully");
            }
            else
            {
                Console.WriteLine("Enter Valid Email");
            }
        }
    }
}

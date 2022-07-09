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
            CheckFirstName();
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
    }
}

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
            //CheckEmail();

            //Vlaidation for Mobile Number
            //CheckMobileNumber();

            //Validation for Password (Min 8 Characters)
            //Check_Password_Conatins_Min_8_Characters();

            //Validation for Password (Min 8 Characters have 1 upper case)
            //Check_Password_Conatins_Min_8_Characters_Have_1_Uppercase();

            //Validation for Password (Min 8 Characters have 1 upper case and 1 Numeric number)
            //Check_Password_Conatins_Min_8_Characters_Have_1_Uppercase_1_Numeric_Number();

            //Validation for Password (Min 8 Characters have 1 upper case, 1 Numeric number and Special Chacter)
            Check_Password_Conatins_Min_8_Characters_Have_1_Uppercase_1_Numeric_Number_and_has_1_SpecialCharacter();
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
        //Creating Method for checking the valid Mobile Number
        public static void CheckMobileNumber()
        {
            Console.WriteLine("Enter Mobile Number");
            Console.WriteLine("\nCountry code follwed by space and 10 Digit Number");
            string input = Console.ReadLine();
            //Regex Patter for validating the Mobile Number
            string MobileNumberPattern = @"^[1-9]{2,}[\s][6-9]{1}[0-9]{9}$";
            Console.WriteLine("\n");
            Regex MobileNumberRegex = new Regex(MobileNumberPattern);
            var Result = MobileNumberRegex.IsMatch(input);
            if (Result)
            {
                Console.WriteLine("The Entered Mobile Number is Registered Successfully");
            }
            else
            {
                Console.WriteLine("Enter Valid Mobile Number");
            }
        }
        //Creating Method for checking the valid Password (Min 8 Character)
        public static void Check_Password_Conatins_Min_8_Characters()
        {
            Console.WriteLine("Enter Password");
            Console.WriteLine("\nPassword Should have min 8 Characters");
            string input = Console.ReadLine();
            //Regex Patter for validating the Password
            string PasswordPattern = @"^[a-zA-Z]{8,}$";
            Console.WriteLine("\n");
            Regex PasswordRegex = new Regex(PasswordPattern);
            var Result = PasswordRegex.IsMatch(input);
            if (Result)
            {
                Console.WriteLine("The Entered Password is Registered Successfully");
            }
            else
            {
                Console.WriteLine("Enter Valid Password");
            }
        }
        //Creating Method for checking the valid Password (Min 8 Character have atleast 1 upeer case )
        public static void Check_Password_Conatins_Min_8_Characters_Have_1_Uppercase()
        {
            Console.WriteLine("Enter Password");
            Console.WriteLine("\nPassword Should have min 8 Characters");
            string input = Console.ReadLine();
            //Regex Patter for validating the Password
            string PasswordPattern = @"^(?=.*[A-Z])[a-zA-Z]{8,}$";
            Console.WriteLine("\n");
            Regex PasswordRegex = new Regex(PasswordPattern);
            var Result = PasswordRegex.IsMatch(input);
            if (Result)
            {
                Console.WriteLine("The Entered Password is Registered Successfully");
            }
            else
            {
                Console.WriteLine("Enter Valid Password");
            }
        }
        //Creating Method for checking the valid Password (Min 8 Character have atleast 1 upeer case and 1 Numeric Number )
        public static void Check_Password_Conatins_Min_8_Characters_Have_1_Uppercase_1_Numeric_Number()
        {
            Console.WriteLine("Enter Password");
            Console.WriteLine("\nPassword Should have min 8 Characters");
            string input = Console.ReadLine();
            //Regex Patter for validating the Password
            string PasswordPattern = @"^(?=.*[A-Z])(?=.*[0-9])(?=.*[a-z]).{8,}$";
            Console.WriteLine("\n");
            Regex PasswordRegex = new Regex(PasswordPattern);
            var Result = PasswordRegex.IsMatch(input);
            if (Result)
            {
                Console.WriteLine("The Entered Password is Registered Successfully");
            }
            else
            {
                Console.WriteLine("Enter Valid Password");
            }
        }
        //Creating Method for checking the valid Password (Min 8 Character have atleast 1 upeer case and 1 Numeric Number )
        public static void Check_Password_Conatins_Min_8_Characters_Have_1_Uppercase_1_Numeric_Number_and_has_1_SpecialCharacter()
        {
            Console.WriteLine("Enter Password");
            Console.WriteLine("\nPassword Should have min 8 Characters");
            string input = Console.ReadLine();
            //Regex Patter for validating the Password
            string PasswordPattern = @"^(?=.*[A-Z])(?=.*[@#$!%^&-+=()])(?=.*[0-9])(?=.*[a-z]).{8,}$";
            Console.WriteLine("\n");
            Regex PasswordRegex = new Regex(PasswordPattern);
            var Result = PasswordRegex.IsMatch(input);
            if (Result)
            {
                Console.WriteLine("The Entered Password is Registered Successfully");
            }
            else
            {
                Console.WriteLine("Enter Valid Password");
            }
        }
    }
}

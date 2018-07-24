using System;
using System.Text.RegularExpressions;

namespace LabNumber7
{
    class Program
    {
        static void Main(string[] args)
        {
            //***INPUT***

            Console.Write("Please enter a valid Name: ");
            string userName = Console.ReadLine();
            NameValidation(userName);
            Console.ReadLine();

            Console.Write("Please enter a valid Email: ");
            string userEmail = Console.ReadLine();
            EmailValidation(userEmail);
            Console.ReadLine();

            Console.Write("Please enter a valid Phone Number: ");
            string userPNumber = Console.ReadLine();
            PhoneValidation(userPNumber);
            Console.ReadLine();

            Console.Write("Please enter a valid Date: ");
            string userDate = Console.ReadLine();
            DateValidation(userDate);
            Console.ReadLine();

            Console.Write("Please enter a valid HTML element: ");
            string htmlElement = Console.ReadLine();
            HTMLValidation(htmlElement);
            Console.ReadLine();
        }


        public static void HTMLValidation(string htmlElement)
        {
            if (Regex.IsMatch(htmlElement, @"^<[a-zA-Z]{1,5}>\s{1,2}<.[a-zA-Z]{1,5}>"))
            {
                Console.WriteLine($"{htmlElement} is a valid HTML Element");
            }
            else
            {
                Console.WriteLine($"Sorry, {htmlElement} is not valid!");
            }
        }

        public static void DateValidation(string userDate)
        {
            if (Regex.IsMatch(userDate, @"^\d{2}.\d{2}.\d{4}"))
            {
                Console.WriteLine($"{userDate} is a valid Date");
            }
            else
            {
                Console.WriteLine($"Sorry, {userDate} is not valid!");
            }
        }

        public static void EmailValidation(string userEmail)
        {
            if (Regex.IsMatch(userEmail, @"^\w{5,30}@\w{5,10}.\w{2,3}$"))
            {
                Console.WriteLine($"{userEmail} is a valid Email");
            }
            else
            {
                Console.WriteLine($"Sorry, {userEmail} is not valid!");
            }
        }

        public static void PhoneValidation(string userPNumber)
        {
            if (Regex.IsMatch(userPNumber, @"^\d{3}-\d{3}-\d{4}$"))
            {
                Console.WriteLine($"{userPNumber} is a valid Phone Number");
            }
            else
            {
                Console.WriteLine($"Sorry, {userPNumber} is not valid!");
            }
        }

        public static void NameValidation(string userName)
        {
            if (Regex.IsMatch(userName, @"^\w[A-za-z]{1,30}$"))
            {
                Console.WriteLine($"{userName} is a valid Name");
            }
            else
            {
                Console.WriteLine($"Sorry, {userName} is not valid!");
            }
        }

        public static string UserResponse()
        {
            string response = Console.ReadLine().ToLower();
            return response;
        }

        public static string UserResponseChecker()
        {
            string input = UserResponse();

            while (input != "y" && input != "n" && input != "yes" && input != "no")
            {
                Console.WriteLine("Error! Input not recognized. Please try again...");
            }

            return input;
        }




    }
}

using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static string firstName = "^[A-Z]{1}[a-z]{2,}$";
        Regex regexName = new Regex(firstName);

        /// <summary>
        /// Validate first name
        /// </summary>
        /// <param name="firstName"></param>
        public void firstNameValidate(string firstName)
        {
            if (regexName.IsMatch(firstName))
            {
                Console.WriteLine("First name is Valid");
            }
            else
            {
                Console.WriteLine("First name is Invalid");
            }
        }

        /// <summary>
        /// Validate last name
        /// </summary>
        /// <param name="lastName"></param>
        public void lastNameValidate(string lastName)
        {
            if (regexName.IsMatch(lastName))
            {
                Console.WriteLine("Last name is Valid.");
            }
            else
            {
                Console.WriteLine("Last name is Invalid.");
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("===============================Welcome to User Registration================================");
            Program pg = new Program();

            //Taking input from user for first name
            Console.WriteLine("Enter Your First Name : ");
            string firstName = Console.ReadLine();
            pg.firstNameValidate(firstName);

            //Taking input from user for last name
            Console.WriteLine("Enter your last name : ");
            string lastName = Console.ReadLine();
            pg.lastNameValidate(lastName);
        }
    }
 }

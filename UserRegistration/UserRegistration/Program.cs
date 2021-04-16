using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static string firstName = "^[A-Z]{1}[a-z]{2,}$";
        Regex regexName = new Regex(firstName);

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
        static void Main(string[] args)
        {
            Console.WriteLine("===============================Welcome to User Registration================================");
            Program pg = new Program();
            Console.WriteLine("Enter Your First Name : ");
            string firstName = Console.ReadLine();
            pg.firstNameValidate(firstName);  
        }
    }
 }

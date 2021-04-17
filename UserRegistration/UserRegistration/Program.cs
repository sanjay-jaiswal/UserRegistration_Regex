using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
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
            
            //Taking email as input and calling method to validate it.
            Console.WriteLine("Enter your Email id : ");
            string emailID = Console.ReadLine();
            pg.emailValidate(emailID);
        }
    }
 }

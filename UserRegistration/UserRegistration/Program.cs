using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============================Welcome to User Registration================================");

            //Creating the object of PatternValidator class
            PatternValidator pv = new PatternValidator();

            //Taking input from user for first name
            Console.WriteLine("Enter Your First Name : ");
            string firstName = Console.ReadLine();
            pv.firstNameValidate(firstName);

            //Taking input from user for last name
            Console.WriteLine("Enter your last name : ");
            string lastName = Console.ReadLine();
            pv.lastNameValidate(lastName);
            
            //Taking email as input and calling method to validate it.
            Console.WriteLine("Enter your Email id : ");
            string emailID = Console.ReadLine();
            pv.emailValidate(emailID);

            Console.WriteLine("Enter your mobile number : ");
            string mobNo = Console.ReadLine();
            pv.mobileValidate(mobNo);

            Console.WriteLine("Enter your Password : ");
            string pass = Console.ReadLine();
            pv.passwordValidate(pass);

            Console.WriteLine("Email samples validation : \n");
            EmailSamples emailSamples = new EmailSamples();
            emailSamples.emailValidate();
        }
    }
 }

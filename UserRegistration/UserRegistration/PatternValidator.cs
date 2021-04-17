using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class PatternValidator
    {
            static string NAME_PATTERN = "^[A-Z][a-z]{2,}$";
            static string EMAIL_PATTERN = "^[0-9a-zA-z]+([._+-][0-9a-zA-z]+)*@[a-zA-Z0-9]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2})$";
            static string MOBILE_PATTERN = "^[0-9]{2}[ ][0-9]{10}$";
            static string PASSWORD_PATTERN = "^[A-ZA-z]{8,}$";

            Regex regexName = new Regex(NAME_PATTERN);
            Regex regEmail = new Regex(EMAIL_PATTERN);
            Regex regexMobile = new Regex(MOBILE_PATTERN);
            Regex regPassword = new Regex(PASSWORD_PATTERN);

        public void firstNameValidate(string firstName)
             {
                if (regexName.IsMatch(firstName))
                {
                    Console.WriteLine("First name is valid.");
                }
                else
                {
                    Console.WriteLine("LFirst name is invalid.");
                }
             }
            public void lastNameValidate(string lastName)
            {
                if (regexName.IsMatch(lastName))
                {
                    Console.WriteLine("Last name is valid.");
                }
                else
                {
                    Console.WriteLine("Last name is invalid.");
                }
            }
            public void emailValidate(string emailPattern)
            {
                if (regEmail.IsMatch(emailPattern))
                {
                    Console.WriteLine("Valid Email Id.");
                }
                else
                {
                    Console.WriteLine("Invalid Email Id.");
                }
            }

          public void mobileValidate(string mob)
          {
            if (regexMobile.IsMatch(mob))
            {
                Console.WriteLine("Mobile number is valid.");
            }
            else
            {
                Console.WriteLine("Mobile number is invalid.");
            }
          }
        public void passwordValidate(string passw)
        {
            if (regPassword.IsMatch(passw))
            {
                Console.WriteLine("Password is valid.");
            }
            else
            {
                Console.WriteLine("Password is invalid.");
            }
        }
    }
}

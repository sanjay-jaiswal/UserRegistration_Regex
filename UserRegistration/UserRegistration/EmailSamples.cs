using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class EmailSamples
    {
        public void emailValidate()
        {
            //Valid email samples
            //All email samples will store in arraylist
            var emailStore = new ArrayList();
            emailStore.Add("abc@yahoo.com");
            emailStore.Add("abc-100@yahoo.com");
            emailStore.Add("abc.100@yahoo.com");
            emailStore.Add("abc111@abc.com");
            emailStore.Add("abc - 100@abc.net");
            emailStore.Add("abc.100@abc.com.au");
            emailStore.Add("abc@1.com");
            emailStore.Add("abc@gmail.com.com");
            emailStore.Add("abc+100@gmail.com");

            //Invalid email saples
            emailStore.Add("abc");
            emailStore.Add("abc@.com.my");
            emailStore.Add("abc123@gmail.a");
            emailStore.Add("abc123@.com");
            emailStore.Add("abc123@.com.com");
            emailStore.Add(".abc@abc.com");
            emailStore.Add("abc()*@gmail.com");
            emailStore.Add("abc@%*.com");
            emailStore.Add("abc..2002@gmail.com");
            emailStore.Add("abc.@gmail.com");
            emailStore.Add("abc@abc@gmail.com");

            String passRegex = "^[\\w!#$%&'*+/=?`{|}~^-]+(?:\\.[\\w!#$%&'*+/=?`{|}~^-]+)*@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z0-9]{2,6}$";
            Regex emailRegex = new Regex(passRegex);
            foreach (string emailSamples in emailStore)
            {
                Console.WriteLine(emailSamples + "=" + emailRegex.IsMatch(emailSamples));
            }
        }
    }
}

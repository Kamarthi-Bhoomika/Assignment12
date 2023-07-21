using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment12

{

    internal class Program

    {
        static void Main(string[] args)
        {
            try
            {
                string text, mobile, email;
                Console.WriteLine("Enter piece of text: ");
                text = Console.ReadLine();
                Console.WriteLine("Enter Email: ");
                email = Console.ReadLine();
                Console.WriteLine("Enter Mobile: ");
                mobile = Console.ReadLine();
                Console.WriteLine("**************************");
                WordCount(text);
                MobileValidation(mobile);
                EmailValidation(email);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error!! " + e.Message);
            }
            finally
            {
                Console.WriteLine("");
                Console.ReadKey();
            }
        }

        public static void WordCount(string text)
        {
            if(text != "")
            {
                int count = text.Trim().Split(' ').Length;
                Console.WriteLine("Word Count in given sentence: " + count);
            }
            else
            {
                Console.WriteLine("No text Found");
            }
        }
        public static void MobileValidation(string mobile)
        {
            if(mobile != "")
            {
                // MObile NUmber: +91-9876545678
                string mobilepattern = @"^(\+?\d{1,4}[\s-])?(?!0+\s+,?$)\d{10}\s*,?$";
                Regex regexmobile = new Regex(mobilepattern);
                foreach (string mob in mobile.Split(' '))
                {
                    if (regexmobile.IsMatch(mob))
                    {
                        Console.WriteLine($"{mob} is a valid mobile number");
                    }
                    else
                    {
                        Console.WriteLine($"{mob} is not a valid mobile number");
                    }
                }
            }
            else
            {
                Console.WriteLine("No numbers Found");
            }
            
        }
        public static void EmailValidation(string email)
        {
            if(email != "")
            {
                // Email
                string emailpattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
                Regex regexemail = new Regex(emailpattern);

                foreach (string id in email.Split(' '))
                {
                    if (regexemail.IsMatch(id))
                    {
                        Console.WriteLine($"{id} is a valid email");
                    }
                    else
                    {
                        Console.WriteLine($"{id} is not a valid email");
                    }
                }
            }
            else
            {
                Console.WriteLine("No Email found");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;


namespace console
{
    public class Email
    {
        class Program
        {
            static void Main(string[] args)
            {
                string[] emailAddresses = { "gostudy@gmail.en", "go_study@bk.en..", "Sgoza@com..gmail", "karim.abd@bk.ru", "selgoz"};
                Console.WriteLine("Is email or not ...");
                Console.WriteLine(" ");
                foreach (var emailAddress in emailAddresses)
                {
                    if (Email.IsValidEmail(emailAddress))
                        Console.WriteLine($"is email: {emailAddress}");
                    else
                        Console.WriteLine($"is not email: {emailAddress}");
                }

                Console.ReadKey();
            }
        }
        public static bool IsValidEmail(string email)
        {
            string cz;
            cz = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, cz))
            {
                if (Regex.Replace(email,cz, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
   
}


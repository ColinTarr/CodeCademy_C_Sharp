using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pswrd_checker { }
namespace tools_pswrd
{
    class pswrdChecker
    {
        public static void Main(string[] args)
        {
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "#?!,-'/`_*$";
            Console.WriteLine("Please Enter Your Password: ");
            string password = Console.ReadLine();
            int score = 0;
            if ((score) >= (minLength))
            {
                score++;
            }

            if (Tools.Contains(password, uppercase))
            {
                score++;
            }

            if (Tools.Contains(password, lowercase))
            {
                score++;
            }

            if (Tools.Contains(password, digits))
            {
                score++;
            }

            if (Tools.Contains(password, specialChars))
            {
                score++;
            }

            Console.WriteLine("The password you entered: " + password);
            Console.WriteLine("Your score is: " + score);

            switch (score)
            {
                case 5:
                case 4:
                    Console.WriteLine("Password strength is extremely strong!");
                    break;
                case 3:
                    Console.WriteLine("Password strength is strong.");
                    break;
                case 2:
                    Console.WriteLine("Password strength is medium.");
                    break;
                case 1:
                    Console.WriteLine("Password strength is weak.");
                    break;
                default:
                    Console.WriteLine("Password strength is too weak!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
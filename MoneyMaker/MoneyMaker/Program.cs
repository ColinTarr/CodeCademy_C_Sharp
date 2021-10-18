using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Enter an amount to convert to coins:");
            string totalAsString = Console.ReadLine();
            double total = Convert.ToDouble(totalAsString);
            Console.WriteLine($"{total} is equal to ...");

            int goldValue = 10;
            int silverValue = 5;

            double goldCoins = Math.Floor(total / goldValue);
            double bronzeCoins = total % goldValue;

            double silverCoins = Math.Floor(bronzeCoins / silverValue);

            Console.WriteLine($"You have {goldCoins} gold coins.");
            Console.WriteLine($"You have {silverCoins} silver coins.");
            Console.WriteLine($"You have {bronzeCoins} bronze coins.");
            Console.ReadLine();
        }
    }
}
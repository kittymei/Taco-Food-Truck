using System;

namespace TacoFoodTruck
{
    class Program
    {
        static string Ask(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }

        static double Price(int quantity)
        {
            double pricePerTaco;

            if (quantity >= 30)
            {
                pricePerTaco = 1.70;
            }
            else if (quantity >= 20)
            {
               pricePerTaco =  1.80;
            }
            else if (quantity >= 10)
            {
                pricePerTaco = 1.90;
            }
            else
            {
                pricePerTaco = 2.05;
            }
            return quantity * pricePerTaco;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Taco Food Truck!");

            string entry = Ask("\nHow many tacos would you like? ");
            int number = int.Parse(entry);
            double total = Price(number);
            Console.WriteLine($"For {number} tacos, your total is: ${total}.");
        }
    }
}






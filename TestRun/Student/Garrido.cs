using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRun.Student
{
    internal class Garrido : Student
    {
        public override void Run()
        {
            Console.Write("Enter your name: ");
            string buyerName = Console.ReadLine();

            Console.Write("Enter the number of apples: ");
            int appleCount = int.Parse(Console.ReadLine());

            Console.Write("Enter the total price for {appleCount} apple(s): ");
            decimal totalPrice = decimal.Parse(Console.ReadLine());

            decimal pricePerApple = totalPrice / appleCount;
            bool isAffordable = pricePerApple <= 15m;

            Console.WriteLine("Hello {buyerName}!");
            Console.WriteLine("Total price for {appleCount} apple(s): {totalPrice:C}");
            Console.WriteLine("Original price (decimal): {totalPrice}");
            Console.WriteLine("Converted price (integer): {(int)totalPrice}");
            Console.WriteLine("Average price per apple: {pricePerApple:F2}");
            Console.WriteLine("Affordable? {isAffordable}");


            if (appleCount > 10)
            {
                Console.WriteLine("Bonus: You qualify for a bulk discount!");
            }

            Console.ReadKey();
        }
    }
}

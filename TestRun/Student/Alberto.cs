using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRun.Student
{
    internal class Alberto : Student
    {
        public override void Run()
        {
            Random rng = new Random();
            float min = 10.0f;
            float max = 100.0f;
            float priceF = (float)(rng.NextDouble() * (max - min) + min);
            float price = (float)Math.Round(priceF, 2);

            bool isConfirm = false;

            while (!isConfirm)
            {
                Console.Write("Enter a Prodcut: ");
                Console.ReadLine();

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                float totalprice = price * quantity;
                float totalVal = (float)Math.Round(totalprice, 2);
                Console.WriteLine("Price per Unit: " + price);
                Console.WriteLine("Total Price: " + totalprice);

                while (!isConfirm)
                {
                    Console.Write("Confirm Purchase (Y/N): ");
                    string userInput = Console.ReadLine().ToUpper();
                    if (userInput == "YES" || userInput == "Y")
                    {
                        isConfirm = true;
                        Console.WriteLine("Purchase Confirmed!");
                    }
                    if (userInput == "NO" || userInput == "N")
                    {
                        Console.WriteLine("Purchase Cancelled. Restarting...");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Type Y and N only...");
                    }
                }
                Console.WriteLine("-=o=-=o=-=o=-=o=-=o=-=o=-=o=-=o=-=o=-=o=-");
            }
            Console.WriteLine("\n Author by: Alberto");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRun.Student
{
    internal class Dayon : Student
    {
        public override void Run()
        {
            Console.Write("Enter your name: ");
            string buyerName = Console.ReadLine();

            Console.Write("Enter the pieces of tangerine: ");
            int tangerinePieces = int.Parse(Console.ReadLine());

            Console.Write("Enter total price of " + tangerinePieces + " tangerine(s): ");
            double tangerineTotalPrice = double.Parse(Console.ReadLine());

            float pricePerTangerine = (float)(tangerineTotalPrice / tangerinePieces);
            bool isAffordable = pricePerTangerine <= 20;

            Console.WriteLine("\nHello " + buyerName + "!");
            Console.WriteLine("The total price of " + tangerinePieces + " tangerine(s) is " + tangerineTotalPrice);
            Console.WriteLine("The value of original price is " + tangerineTotalPrice);
            Console.WriteLine("The value of converted price is " + (int)tangerineTotalPrice);
            Console.WriteLine("Average price per tangerine (float) is " + pricePerTangerine);
            Console.WriteLine("Affordable? " + isAffordable);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRun.Student
{
    internal class Pardillo : Student
    {
        public override void Run()
        {

            string fruit = "Mango";
            int quantity = 5;
            float pricePerPiece = 12.5f;
            bool isRipe = true;

            Console.WriteLine("Fruit: " + fruit);
            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("Price per piece: " + pricePerPiece + " Pesos");

            if (isRipe)
            {
                Console.WriteLine("The fruit is ripe");
            }
            else
            {
                Console.WriteLine("The fruit is not ripe yet");
            }

            Console.WriteLine("\nAuthor by: Pardillo");

        }
   
    }
}


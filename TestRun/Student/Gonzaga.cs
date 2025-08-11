using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRun.Student
{
    internal class Gonzaga : Student
    {
        public override void Run()
        {   
            // remainder to use
            // int, float, string, bool, and console printing
            int age = 1000;
            float weight = 60.3f;
            string name = "Gonzaga";
            bool pooping = false;
            if (!pooping)
            {
                Console.WriteLine($"Ako si {name} at ako ay {age} taong gulang, may timbang na {weight} kg at may kasabihang ang buhay ay kung papaano mo ito papalipasin ng maligaya.");
            }
            
            Console.WriteLine();

            Random random = new Random();
            Console.WriteLine("                   [Dice Game]");
            Console.WriteLine("(kung sino ang mas mataas ang roll ay mananalo)");
            Console.WriteLine("Press Enter to roll the dice...");
            Console.ReadLine();
            Console.WriteLine();
            int min = 1;
            int max = 7;
            int playerRoll = random.Next(min, max); // 1 to 6
            int computerRoll = random.Next(min, max);

            Console.WriteLine($"Ang roll mo ay: {playerRoll}");
            Console.WriteLine($"And roll ng computer ay: {computerRoll}");

            if (playerRoll > computerRoll)
            {
                Console.WriteLine("[wew nanalo]");
            }
            else if (playerRoll < computerRoll)
            {
                Console.WriteLine("[haha talo]");
            }
            else
            {
                Console.WriteLine("[tali]");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
// test update
            Console.WriteLine("Author by: "+ name);
        }
   
    }
}

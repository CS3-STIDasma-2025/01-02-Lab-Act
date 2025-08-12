using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRun.Student
{
    internal class Garcia : Student
    {
        public override void Run()
        {
            string G = "John Guiller R. Garcia";
            int Age = 19;
            int Birthday = 07 / 02 / 2006;
            float weight = 35.6f;
            float height = 5.5f;
            bool Girlfriend = false;

            Console.WriteLine("Running Garcia's code...");
            Console.WriteLine("Hello! my name is: " + G);
            Console.WriteLine("My age is: " + Age);
            Console.WriteLine("My birthday is: " + Birthday);
            Console.WriteLine("My weight is: " + weight);
            Console.WriteLine("My height is: " + height);
            
            Console.WriteLine("Do I have a girlfriend? Please answer 'true' or 'false': ");
            string? answer = Console.ReadLine()?.ToLower();

            // Check for valid input
            if (answer == "true" || answer == "false")
            {
                Girlfriend = Convert.ToBoolean(answer);
                Console.WriteLine((Girlfriend ? "Hmm, Maybe in a alternate universe." : "Correct!, I do not have a Girlfriend."));
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter 'true' or 'false'.");
                
            }
            Console.WriteLine("\nAuthor By: John Guiller R. Garcia");
        }
    }
}

//THIS IS A TEMPLATE FILE 

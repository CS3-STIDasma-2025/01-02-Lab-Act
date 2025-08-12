using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRun.Student
{
    internal class Tolentino : Student
    {
        public override void Run()
        {
            string choice;

            // Variable declaration and asssingment
            int age = 19;
            string name = "Kentzar B. Tolentino";

            // using a float variable to store height
            float height = 5.749f;
            float weight = 72.90f;

            // using a boolean variable to store
            bool isMale = true;
            bool isBSCS = true;

            Console.WriteLine("Choose the introduction type: simple or complex");
            choice = Console.ReadLine().ToLower();

            if (choice == "simple")
            {
                Console.WriteLine("\n--- Simple Introduction ---");
                Console.WriteLine($"Hi! My name is {name}, I am {age} years old");
            }
            else if (choice == "complex")
            {
                Console.WriteLine("\n--- Complex Introduction ---");
                Console.WriteLine($"My name is {name}, I am {age} years old, " +
                                  $"\nI am {height} feet tall and weigh {weight} kg. " +
                                  $"\nis Male: {(isMale ? "true" : "false")}" +
                                  $"\nI am currently enrolled in a BSCS program: {(isBSCS ? "true" : "false")}");


            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 'simple' or 'complex'.");
            }

            Console.WriteLine("\nAuthor: Tolentino");

        }
   
    }
}
 

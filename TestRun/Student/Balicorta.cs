using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace TestRun.Student
{
    internal class Balicorta : Student
    {
        public override void Run()
        {
            Console.WriteLine("Running Mico's code...");

            // int example
            int age = 18;

            // float example
            float grade = 92.5f;

            // string example
            string name = "Mico Balicorta";

            // bool example
            bool passed = grade >= 75;

            // Output
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"Passed: {passed}");

            // Extra logic
            if (passed)
            {
                Console.WriteLine("Congratulations! You passed the course.");
            }
            else
            {
                Console.WriteLine("Better luck next time!");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
            Console.WriteLine("Author by: "+ "Balicorta");
        }
    }
}

//THIS IS A TEMPLATE FILE 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRun.Student
{
    internal class Subion : Student
    {
        public override void Run()
        {
            string name = "Jonalyn A. Subion";
            float weight = 45.6f;
            string height = "4'11\"";
            int age = 19;
            bool isAdult = age >= 18;
            string collegeProgram = "Bachelor of Science in Computer Science";

            Console.WriteLine("=== Personal Information ===");
            Console.WriteLine($"Name           : {name}");
            Console.WriteLine($"College Program: {collegeProgram}");
            Console.WriteLine($"Weight         : {weight} kg");
            Console.WriteLine($"Height         : {height}");
            Console.WriteLine($"Age            : {age}");
            Console.WriteLine($"Is Adult?      : {isAdult}");

            Console.WriteLine("Author by: Subion");

        }
   
    }
}
//THIS IS A TEMPLATE FILE 

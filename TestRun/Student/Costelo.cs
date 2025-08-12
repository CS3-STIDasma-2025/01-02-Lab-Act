using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRun.Student
{
    //   
    internal class Costelo : Student
    {
        public override void Run()

        {
            //use int, string, bool, and float
            int age = 19;
            string name = "Aldrain Costelo";
            bool isAlive = true;
            float weight = 39.5f;


            Console.WriteLine("");

            // Example of using the variables
            Console.WriteLine($"age: {age}");
            Console.WriteLine($"Student Name: {name}");
            Console.WriteLine($"Is the student alive: {isAlive}");
            Console.WriteLine($"Weight: {weight}");
            Console.WriteLine($"Student {name} is {age} years old, weighs {weight} kg, and it is {isAlive} na siya ay bohai pa.");
            Console.WriteLine("                                  ");
            Console.WriteLine($"Authored by: {name}");
        }
    }
}
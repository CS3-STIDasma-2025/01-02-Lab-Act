using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRun.Student
{
    internal class Dupalco : Student
    {
        public Dupalco()
        {
        }

        public override void Run()
        {
            string name = "Ma. Judith Dupalco";

            int age = 19;

            float height = 4.11f;

            bool isStudent = true;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Height: " + height + " feet");
            Console.WriteLine("Is a student? " + isStudent);

            if (isStudent)
            {
                Console.WriteLine(name + " is currently studying.");
            }
            else
            {
                Console.WriteLine(name + " is not a student.");
            }
                Console.WriteLine("Dupalco's code...");

            Console.WriteLine("Author by: [Dupalco]");

        }

    }
}








           
            
        
//THIS IS A TEMPLATE FILE 

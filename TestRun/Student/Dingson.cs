using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRun.Student
{
    internal class Dingson : Student
    {
        public override void Run()

        {
            Console.Write("Are you a student? (true/false): ");
            bool confirmStudent = bool.Parse(Console.ReadLine());

            Console.Write("What is your favorite subject?: ");
            string name = Console.ReadLine();
            Console.Write("What is the hardest subject for you?: ");
            string nameSecond = Console.ReadLine();

            Console.Write("How difficult is " + nameSecond + " for you? (1-10): ");
            int difficult = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is your final grade in " + nameSecond + "?: ");
            float grade = float.Parse(Console.ReadLine());

            Console.WriteLine("\n-------- user input --------");
            Console.WriteLine("You are a Student");
            Console.WriteLine("Hardest subject: " + nameSecond);
            Console.WriteLine("Difficulty of the subject: " + difficult);
            Console.WriteLine("Highest Grade: " + grade);
            Console.WriteLine("\nAuthor by: Dingson");
        }
    }
}
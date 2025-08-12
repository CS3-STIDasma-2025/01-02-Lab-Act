using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRun.Student
{
    internal class Satsatin : Student
    {
        public override void Run()
       
            {
            Console.Write("Enter your age: ");
            int age = GetValidInt();

            Console.Write("Enter your height (in feet): ");
            float height = GetValidFloat();

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Are you a student (yes/no)? ");
            bool isStudent = Console.ReadLine().Trim().ToLower() == "yes";

            Console.Write("Enter your favorite color: ");
            string favoriteColor = Console.ReadLine();

            Console.Write("Enter your favorite hobby: ");
            string hobby = Console.ReadLine();

            Console.WriteLine($"\n--- Your Info ---");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height} ft");
            Console.WriteLine($"Currently a student? {isStudent}");
            Console.WriteLine($"Favorite Color: {favoriteColor}");
            Console.WriteLine($"Favorite Hobby: {hobby}");

            if (isStudent)
            {
                Console.WriteLine("Welcome to the class, student!");
            }
            else
            {
                Console.WriteLine("Welcome, guest!");
            }

            Console.WriteLine("\nAuthor by: Satsatin");
        }

        private int GetValidInt()
        {
            int result;
            while (!int.TryParse(Console.ReadLine(), out result) || result <= 0)
            {
                Console.Write("Please enter a valid positive integer: ");
            }
            return result;
        }

        private float GetValidFloat()
        {
            float result;
            while (!float.TryParse(Console.ReadLine(), out result) || result <= 0)
            {
                Console.Write("Please enter a valid positive number for height: ");
            }
            return result;
        }
    }
}


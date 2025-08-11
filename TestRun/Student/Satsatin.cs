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
            // Get user input for age
            Console.Write("Enter your age: ");
            int age = GetValidInt();

            // Get user input for height
            Console.Write("Enter your height (in feet): ");
            float height = GetValidFloat();

            // Get user input for name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // Get user input for student status
            Console.Write("Are you a student (yes/no)? ");
            bool isStudent = Console.ReadLine().Trim().ToLower() == "yes";

            // Get user input for favorite color
            Console.Write("Enter your favorite color: ");
            string favoriteColor = Console.ReadLine();

            // Get user input for hobby
            Console.Write("Enter your favorite hobby: ");
            string hobby = Console.ReadLine();

            // Printing values using string interpolation
            Console.WriteLine($"\n--- Your Info ---");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height} ft");
            Console.WriteLine($"Currently a student? {isStudent}");
            Console.WriteLine($"Favorite Color: {favoriteColor}");
            Console.WriteLine($"Favorite Hobby: {hobby}");

            // Simple logic using bool
            if (isStudent)
            {
                Console.WriteLine("Welcome to the class, student!");
            }
            else
            {
                Console.WriteLine("Welcome, guest!");
            }

            // End with author
            Console.WriteLine("\nAuthor by: Satsatin");
        }

        // Helper method to get a valid integer input
        private int GetValidInt()
        {
            int result;
            while (!int.TryParse(Console.ReadLine(), out result) || result <= 0)
            {
                Console.Write("Please enter a valid positive integer: ");
            }
            return result;
        }

        // Helper method to get a valid float input
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

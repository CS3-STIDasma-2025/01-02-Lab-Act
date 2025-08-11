using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRun.Student
{
    internal class Marasigan : Student
    {
        public override void Run()
       
            {
            
            Console.Write("Enter your favorite number: ");
            int fav = GetValidInt();

            Console.Write("Enter your height (in meters): ");
            float height = GetValidFloat();
            
            Console.Write("Enter your nickname: ");
            string name = Console.ReadLine();
            
            Console.Write("Are you single (yes/no)? ");
            bool status = Console.ReadLine().Trim().ToLower() == "yes";

            Console.Write("Enter your favorite sports: ");
            string favoriteSports = Console.ReadLine();
           
            Console.Write("Enter your favorite food: ");
            string food = Console.ReadLine();

            Console.WriteLine($"\n--- Your Info ---");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"favorite number: {fav}");
            Console.WriteLine($"Height: {height} meters");
            Console.WriteLine($"Currently a student? {status}");
            Console.WriteLine($"Favorite Sports: {favoriteSports}");
            Console.WriteLine($"Favorite Food: {food}");

            if (status)
            {
                Console.WriteLine("Welcome to the class, student!");
            }
            else
            {
                Console.WriteLine("Welcome, guest!");
            }
           
            Console.WriteLine("\nAuthor by: Marasigan");
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

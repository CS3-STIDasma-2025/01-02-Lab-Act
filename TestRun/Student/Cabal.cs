using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestRun.Student
{
    internal class Cabal : Student
    {
        public override void Run()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your favorite number from 1-99");
            int favNumber = GetValidInt();

            Console.WriteLine("Who is your Favorite F1 Driver?");
            string favDriver = Console.ReadLine();

            Console.WriteLine("What is your favorite F1 Team?");
            string favTeam = Console.ReadLine();

            Console.WriteLine("What is your favorite F1 Circuit?");
            string favCircuit = Console.ReadLine();

            Console.WriteLine("Do you like F1? (yes/no)");
            bool likesF1 = Console.ReadLine().Trim().ToLower() == "yes";

            Console.WriteLine("\n-------- F1 Fan UserID --------");
            Console.WriteLine("Favorite F1 Driver: " + favDriver);
            Console.WriteLine("Favorite F1 Team: " + favTeam);
            Console.WriteLine("Favorite F1 Circuit: " + favCircuit);
            Console.WriteLine("Likes F1: " + likesF1);
        }

        private int GetValidInt()
        {
            int number;
            bool isValid = false;


            while (!isValid)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out number))
                {

                    if (number >= 1 && number <= 99)
                    {
                        isValid = true;
                        return number;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 99.");
                        Console.Write("Try again: ");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.Write("Try again: ");
                }
            }
            return 0;
        }
    }

}


// Edited/Author by John Albert Cabal BSCS 2.1A


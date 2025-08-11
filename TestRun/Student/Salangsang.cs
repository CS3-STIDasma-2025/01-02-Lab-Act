using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRun.Student
{
    internal class Salangsang : Student
    {
        public static void ArimethicCalculator()
        {
            // The bool is for the confirmation of the user to access the calculator
            bool confirmation = false;
            // This is used to change 'yes' or 'no' to bool value
            string tochngconfirmation;
            // This is the string input for the user to choose which operation they want to do
            string input;
            // The float variables are for the numbers that the user will input
            float firstNumber, secondNumber, result;
            // Date variables to display the date at the "Authored by" message
            int day, month, year;
            day = 09;
            month = 08;
            year = 2025;
            
            Console.WriteLine("Welcome to the Arithmetic Calculator!");

            // confirmation loop to check if the user wants to access the calculator
            while (true)
            {
                // Very rudimentary confirmation gate
                Console.WriteLine("Do you want to access the calculator? Yes, or No?");
                tochngconfirmation = Console.ReadLine().ToLower();

                if (tochngconfirmation == "yes")
                {
                    confirmation = true;
                    break;
                }
                else if (tochngconfirmation == "no")
                {
                    confirmation = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                }
            }
            while (confirmation == true)
            {
                // Second gate, asks the user which operation they want to do
                Console.WriteLine("Which operation would you like to do, Addition, Subtraction, Multiplication, Division, or Stop the calculator?");
                // Used to lowercase input for easier comparison
                input = Console.ReadLine().ToLower();

                switch (input)
                {
                    // All of the operations
                    case "addition":
                        Console.Write("Enter the first number to be added: ");
                        firstNumber = float.Parse(Console.ReadLine());
                        Console.Write($"{firstNumber} + ?: ");
                        secondNumber = float.Parse(Console.ReadLine());
                        result = firstNumber + secondNumber;
                        Console.WriteLine($"The result of {firstNumber} + {secondNumber} is: {result}");
                        break;
                    case "subtraction":
                        Console.Write("Enter the first number to be subtracted: ");
                        firstNumber = float.Parse(Console.ReadLine());
                        Console.Write($"{firstNumber} - ?: ");
                        secondNumber = float.Parse(Console.ReadLine());
                        result = firstNumber - secondNumber;
                        Console.WriteLine($"The result of {firstNumber} - {secondNumber} is: {result}");
                        break;
                    case "multiplication":
                        Console.Write("Enter the first number to be multiplied: ");
                        firstNumber = float.Parse(Console.ReadLine());
                        Console.Write($"{firstNumber} * ?: ");
                        secondNumber = float.Parse(Console.ReadLine());
                        result = firstNumber * secondNumber;
                        Console.WriteLine($"The result of {firstNumber} * {secondNumber} is: {result}");
                        break;
                    case "division":
                        Console.Write("Enter the first number to be divided: ");
                        firstNumber = float.Parse(Console.ReadLine());
                        Console.Write($"{firstNumber} / ?: ");
                        secondNumber = float.Parse(Console.ReadLine());
                        result = firstNumber / secondNumber;
                        Console.WriteLine($"The result of {firstNumber} / {secondNumber} is: {result}");
                        break;
                    case "stop":
                        confirmation = false; // Exit the loop if user wants to stop
                        Console.WriteLine("Exiting the calculator.");
                        Console.WriteLine($"\n Authored by: Aaron Salangsang. {day}-{month}-{year}");
                        return; // Exit the method
                    default:
                        Console.WriteLine("Invalid input. Please enter any of the given operations.");
                        break; 
                }
            }

        }
        public override void Run()
        {
            Console.WriteLine("Running Salangsang's code...");
            ArimethicCalculator();

        }
        
    }
   
}

//THIS IS A TEMPLATE FILE 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRun.Student
{
    internal class Dacquel : Student
    {
        public override void Run()
        {
            // Ask for student's name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            double sum = 0;
            int numberOfGrades = 6;

            // Loop to input grades
            for (int i = 1; i <= numberOfGrades; i++)
            {
                Console.Write($"Enter grade #{i}: ");
                double grade = double.Parse(Console.ReadLine());
                sum += grade;
            }

            // Calculate average
            double average = sum / numberOfGrades;

            // Convert average to whole number
            int wholeAverage = (int)average;

            string remarks = null;

            // Determine remarks based on average
            if (wholeAverage >= 1 && wholeAverage < 2)
            {
                remarks = "Excellent";
            }
            else if (wholeAverage >= 2 && wholeAverage < 3)
            {
                remarks = "Great";
            }
            else if (wholeAverage >= 3 && wholeAverage < 4)
            {
                remarks = "Good";
            }
            else if (wholeAverage >= 4 && wholeAverage < 5)
            {
                remarks = "Average";
            }
            else if (wholeAverage == 5)
            {
                remarks = "Passed";
            }
            else if (wholeAverage > 5)
            {
                remarks = "Failed";
            }

            // Output results
            Console.WriteLine($"\nHello, {name}");
            Console.WriteLine($"Your average grade is: {wholeAverage}");
            Console.WriteLine($"Remarks: {remarks}");

            Console.WriteLine("\n--- Author by : Dacquel ---");

            // Wait before closing
            Console.WriteLine("\nPress any key to exit.....");
            Console.ReadKey();

            
        }
   
    }
}

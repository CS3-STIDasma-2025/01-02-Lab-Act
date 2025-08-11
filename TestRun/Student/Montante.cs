using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRun.Student
{
    internal class Montante : Student
    {
        public override void Run()
        {
            Console.WriteLine("Running Montante's code...");
            Console.WriteLine("[---CLS Compatibility Tester---]\n");


            Console.WriteLine("Welcome to the CLS Compatibility Tester!");
            Console.WriteLine("The Common Language Specification (CLS) is a set of basic language features that ensures interoperability between languages in the .NET environment.");
            Console.WriteLine("It is a subset of the Common Type System (CTS), which defines how types are declared, used, and managed.\n");


            string languageName = "Trisha Joyce Montante";
            int numberOfFeatures = 25;
            float compliancePercentage = 82.5f;
            bool isCompliant = false;


            Console.WriteLine("Testing language: " + languageName);
            Console.WriteLine("Number of CLS-required features: " + numberOfFeatures);
            Console.WriteLine("Compliance Check in Progress...\n");


            Console.WriteLine("Do you want to run the CLS compliance test? [Yes/No]");
            string response = Console.ReadLine();

            if (response.ToLower() == "yes")
            {
                Console.WriteLine("\nRunning CLS checks...");
                if (compliancePercentage >= 75.0f)
                {
                    isCompliant = true;
                    Console.WriteLine(languageName + " PASSED the CLS compliance test!");
                }
                else
                {
                    Console.WriteLine(languageName + " FAILED the CLS compliance test!");
                }
                Console.WriteLine("Compliance Percentage: " + compliancePercentage + "%");
                Console.WriteLine("CLS Compliant: " + isCompliant);
            }
            else
            {
                Console.WriteLine("\nTest cancelled. No compliance data available.");
            }

            Console.WriteLine("\nAuthor by: Montante");
        }
    }
}

using System;

namespace TestRun.Student
{
    internal class Gonzales : Student
    {
        public override void Run()
        {
            string carBrand = "Toyota";
            string carModel = "Vios";
            int manufactureYear = 2022;
            float engineSize = 1.3f;

            Console.WriteLine("=== Vehicle Information ===");
            Console.WriteLine($"Brand          : {carBrand}");
            Console.WriteLine($"Model          : {carModel}");
            Console.WriteLine($"Year           : {manufactureYear}");
            Console.WriteLine($"Engine (L)     : {engineSize}");

            if (manufactureYear >= 2023)
            {
                Console.WriteLine("This vehicle is brand new.");
            }
            else
            {
                Console.WriteLine("This vehicle is pre-owned.");
            }

            Console.WriteLine("Record prepared by: Gonzales");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRun.Student
{
    internal class Villar : Student
    {
        public override void Run()
        {
            Console.WriteLine("Running Villar's code...");

            Console.WriteLine("[---Battleship Voyage---]");

            string shipName = "Bedrock The Destroyer";
            string planetName = "Exodus 31A";
            int crewCount = 5;
            float fuelLevel = 67.2f;    
            bool shieldActive = true;

            Console.WriteLine("Initializing launch for: " + shipName);
            Console.WriteLine("Crew Members Onboard: " + crewCount);
            Console.WriteLine("Fuel Level: " + fuelLevel);

            Console.WriteLine("You have selected planet: " + planetName);
            Console.WriteLine("Do you want to continue? [Yes/No]");
            string response = Console.ReadLine();
            
            if (response.ToLower() == "yes")
                {
                    Console.WriteLine("Response confirmed, prepare for your journey.");
                    shieldActive = true;
                    Console.WriteLine("Shield Active: " + shieldActive);
                    Console.WriteLine("Boosting thrusters - Traveling to " + planetName);
                    Console.WriteLine("Fuel Level required: 30.3");
                    fuelLevel -= 30.3f;
                    Console.WriteLine("Fuel Level Remaining: " + fuelLevel);      
                }
            else
                {
                   Console.WriteLine("Exploration ended, returning to base.");  
                }

            Console.WriteLine("Author by: Villar");
        }
    }
}
//THIS IS A TEMPLATE FILE 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRun.Student
{
    internal class Yuri : Student
    {
        public override void Run()
        {
            Console.WriteLine("Running Yuri's code...");
            Console.WriteLine("[--- Arknights Operator Registration ---]");

            // Ask for operator details
            Console.Write("Enter Operator Code Name: ");
            string codeName = Console.ReadLine();

            Console.Write("Enter Faction Name: ");
            string faction = Console.ReadLine();

            Console.Write("Enter Combat Experience:");
            string combatExp = Console.ReadLine();

            // Display entered info
            Console.WriteLine("\n--- Operator Profile ---");
            Console.WriteLine("Code Name: " + codeName);
            Console.WriteLine("Faction: " + faction);
            Console.WriteLine("Combat Experience: " + combatExp);

            // Deployment decision
            Console.Write("\nDo you want to deploy on a mission? [Yes/No]: ");
            string response = Console.ReadLine();

            if (response.ToLower() == "yes")
            {
                Console.WriteLine("Deployment successful! " + codeName + " is on the mission.");
            }
            else
            {
                Console.WriteLine("Waiting for next Operator.");
            }

            Console.WriteLine("\n--- Author by : Reville ---");
        }
   
    }
}

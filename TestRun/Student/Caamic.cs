using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TestRun.Student
{
    internal class Caamic : Student
    {
        public override void Run()
        {


            Console.WriteLine("Running Caamic's code...");
            Console.WriteLine();

            Thread.Sleep(10000);
            Console.WriteLine("Loading...");

            Console.WriteLine();

            Thread.Sleep(2000);
            Console.WriteLine("Almost There...");

            Console.WriteLine();

            Thread.Sleep(5000);
            Console.WriteLine("Finish...");

            Console.WriteLine();


            string myName = "Ivan Alexus Sister Caamic";
            int myAge = 19;
            float myWeight = 55.5f;
            float myHeight = 1.72f;
            bool isAlive  = true;

            short life = 150;
            byte mana = 40;
            byte attack = 90;
            byte defense = 75;
            byte luck = 15;
            byte crit = 30;
            int iq = 30;
            string role = "Suppot Killer";

            Console.WriteLine("HERO CHARACTER LOAD");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Name        : " + myName);
            Console.WriteLine("Role        : " + role);
            Console.WriteLine("Age         : " + myAge + " years old");
            Console.WriteLine("Weight      : " + myWeight + " kg");
            Console.WriteLine("Height      : " + myHeight + " m");
            Console.WriteLine("Status      : " + (isAlive ? "Alive" : "Deceased"));
            Console.WriteLine("------------------------------------");
            Thread.Sleep(5000);
            Console.WriteLine();
            Console.WriteLine("STATS");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Life        : " + life);
            Console.WriteLine("Mana        : " + mana);
            Console.WriteLine("Attack      : " + attack);
            Console.WriteLine("Defense     : " + defense);
            Console.WriteLine("Luck        : " + luck);
            Console.WriteLine("Critical    : " + crit + "%");
            Console.WriteLine("Intelligence: " + iq);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Character loading complete... Let the adventure begin!");
            Console.WriteLine();

            Console.WriteLine("BTW! GCASH NO. KO: 09159359145 - Lagyan niyo nang laman.");

            Console.WriteLine();

            Console.WriteLine("Author by: Caamic");


        }
    }
}

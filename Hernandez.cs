using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRun.Student
{
    internal  class Hernandez : Student
    {
        public override void Run()
        {
            string Fname = "Shawn Hernandez";
            int ranknum = 14;
            float wr = 55.5f;
            bool isLeomord = true;

            Console.WriteLine("I am " + Fname + " and i was a former local server " + ranknum);
            if (isLeomord)
            {
                Console.WriteLine("and i had a win rate of " + wr);

            }
            Console.WriteLine("\n Author by: Hernandez,Shawn");

        }
    }
}
      

        


    


        
     

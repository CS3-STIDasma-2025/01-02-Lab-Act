using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRun.Student
{
    internal class Ruiz : Student
    {
        public override void Run()
        {
            Console.WriteLine("              THIS WEBSITE HAS BEEN SEIZED \n\n\n This domain has been seized by the Federal Bureau of Investigation pursuant to a seizure warrant issued \n by the Cavite District Court of the Philippines, under the authority of 21 P.C §853(f) and 28 P.C §2461(c),\n as part of coordinated law enforcement action by:\n\n          FEDERAL BUREAU OF INVESTIGATION (FBI)\n\n\n");
            string reasonOfSeizure = "Leaking Confidential Documents that will be detrimental \n to our Government if obtained by neighboring countries. ";
            string monthOfSeizure = "AUGUST";
            int yrOfSeizure = 2025;
            int dayOfSeizure = 12;
            float documentsSeized = 10.3F;
            bool isSeized = true;
            if (isSeized == true)
            {
                Console.WriteLine(" INFORMATION FOR THE SEIZED WEBSITE\n\n   -Reason for the Seizure: " + reasonOfSeizure + "\n   -Date of Seizure: " + monthOfSeizure + "/" + dayOfSeizure + "/" + yrOfSeizure + "\n   -Total Document Seized: " + documentsSeized + " GB of Cofidential Documents\n\n\n");
            }
            else
            {
                Console.WriteLine("The website has not been seized at the moment.");
            }
            Console.WriteLine("    Author by: Balajadia");

        }
   
    }
}
//THIS IS A TEMPLATE FILE 

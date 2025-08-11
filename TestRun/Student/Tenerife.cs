using System;

namespace LabActivity
{
    public class Tenerife
    {
        public void Run()
        {
            
            int age = 19;
            float gwa = 1.34f;
            string name = "Richel Tenerife";
            bool isEnrolled = true;

            
            Console.WriteLine("=== Student Info ===");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("GWA: " + gwa);
            Console.WriteLine("Enrolled: " + isEnrolled);

            
            if (isEnrolled)
            {
                Console.WriteLine(name + " is currently enrolled.");
            }
            else
            {
                Console.WriteLine(name + " is not enrolled.");
            }

           
            Console.WriteLine("Author by: Tenerife");
        }
    }
}

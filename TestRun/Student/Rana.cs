using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRun.Student
{
    internal  class Rana : Student
    {
        public override void Run()
        {

            void CenterText(string text)
            {

                int screenWidth = Console.WindowWidth;
                int stringWidth = text.Length;
                int spaces = (screenWidth - stringWidth) / 2;
                if (spaces < 0) spaces = 0;
                string spaceString = new string(' ', spaces);
                Console.WriteLine(spaceString + text);
            }
            // Account for the log in

            string username = "Student12";
            string pass = "Sti_Cs213";
            bool loggedin = false;
                        

            // Prompt for log in
            string sp = "                                        ";
            while (!loggedin)
            {
                Console.Clear();
                CenterText(" QUIZ BEE LOG IN  ");

                Console.WriteLine();
                Console.WriteLine();
                Console.Write(sp +" Enter username:  ");
                string us = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine();
                Console.Write(sp + " Enter password:  ");
                string p = Console.ReadLine();

                if (us == username && p == pass)
                {

                    loggedin = true;
                    Console.Clear();
                    Console.WriteLine();
                    CenterText("lOG IN SUCCESSFUL!");
                    Console.WriteLine();
                    CenterText("WELCOME " + us + "!");
                    Console.WriteLine();
                    CenterText("Press any key to start the quiz...");
                    Console.ReadKey();
                    Console.Clear();

                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    CenterText("INVALID ACCOUNT. PLEASE TRY AGAIN.");
                    System.Threading.Thread.Sleep(2000);
                }
            }
            // START OF THE GAME

            Console.Clear();
            CenterText(" --- WELCOME TO QUIZ BEE! ---");

            int score = 0;

            //MULTIPLE CHOICE

            //Q1
            Console.WriteLine("\n 1. What do you call the brain of a computer?");
            Console.WriteLine(" A. GPU ");
            Console.WriteLine(" B. CPU ");
            Console.WriteLine(" C. MONITOR ");
            Console.WriteLine(" D. SSD ");
            Console.Write(" Answer:  ");
            string ans1 = Console.ReadLine().Trim().ToUpper();
            if (ans1 == "B") score++;
            else if (ans1 != "A" && ans1 != "B" && ans1 != "C" && ans1 != "D")
            {
               
                Console.WriteLine("Invalid answer. Automatic Wrong");
            }

            //Q2
            Console.WriteLine("\n 2. What part of the computer is used for processing computer's graphic image?");
            Console.WriteLine(" A. GPU ");
            Console.WriteLine(" B. CPU ");
            Console.WriteLine(" C. RAM ");
            Console.WriteLine(" D. SSD ");
            Console.Write(" Answer:  ");
            string ans2 = Console.ReadLine().Trim().ToUpper();
            if (ans2 == "A") score++;
            else if (ans2 != "A" && ans2 != "B" && ans2 != "C" && ans2 != "D")
            {
                Console.WriteLine("Invalid answer. Automatic Wrong");
            }

            //Q3
            Console.WriteLine("\n 3. Who is the father of computer?");
            Console.WriteLine(" A. MICHAEL FARADAY ");
            Console.WriteLine(" B. ALESSANDRO VOLTA ");
            Console.WriteLine(" C. GALILEO GALILEI ");
            Console.WriteLine(" D. CHARLES BABBAGE ");
            Console.Write(" Answer:  ");
            string ans3 = Console.ReadLine().Trim().ToUpper();
            if (ans3 == "D") score++;
            else if (ans3 != "A" && ans3 != "B" && ans3 != "C" && ans3 != "D")
            {
                Console.WriteLine("Invalid answer. Automatic Wrong");
            }

            // IDENTIFICATION QUESTIONS

            //Q4
            Console.WriteLine("\n 4. What type of property relation where every element in the set is related to itself? ");
            Console.Write("Answer:  ");
            string ans4 = Console.ReadLine().Trim();
            if (string.Equals(ans4,"Reflexive relation" ,StringComparison.OrdinalIgnoreCase))
                score++;

            //Q5
            Console.WriteLine("\n 5. What shape has three sides?");
            Console.Write("Answer:  ");
            string ans5 = Console.ReadLine().Trim();
            if (string.Equals(ans5, "Triangle", StringComparison.OrdinalIgnoreCase)) 
                score++;

            //SHOW RESULTS
            Console.Clear();
            CenterText(" --- QUIZ COMPLETE! --- ");
            Console.WriteLine();
            Console.WriteLine();
            CenterText($"YOU GOT {score} OUT OF 5!");

            //CALCULATE THE GRADE AS FLOAT AFTER THE SCORE
            float grade = ((float)score / 5f) * 100f;
            Console.WriteLine();
            CenterText($" YOUR GRADE : {grade:F1}%");

            //CHECK IF THE USER PASSED OR NOT

            bool passed = score >= 3;
             if(passed)
            {
                Console.WriteLine();
                CenterText(" CONGRATULATIONS YOU PASSED! KEEP IT UP");
            }
            else
            {
                Console.WriteLine();
                CenterText(" SORRY YOU FAILED, BETTER LUCK NEXT TIME");
            }

             Console.WriteLine();
            CenterText(" Author by: Rana");
        }

    }
}

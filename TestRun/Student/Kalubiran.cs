using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRun.Student
{
    internal class Kalubiran : Student
    {
        public override void Run()
        {
            string[] movies = {
            "Seven Sundays",
            "A Silent Voice",
            "Drawing Closer",
            "Dead Poets Society",
            "I Want To Eat Your Pancreas"
        };

            bool isFinished = true;
            string username;
            string userInput;
            string errorMessage = "Invalid input. Please try again.";
            float ticketPrice = 300.0f;

            Console.WriteLine("Welcome To Ticket World!");
            Console.Write("Please Input Username: ");
            username = Console.ReadLine();

            while (isFinished)
            {
                Console.WriteLine("\nSelect an Action:");
                Console.WriteLine("1 - Purchase Ticket/s");
                Console.WriteLine("2 - See All Movies");
                Console.WriteLine("3 - End");
                userInput = Console.ReadLine();

                while (userInput != "1" && userInput != "2" && userInput != "3")
                {
                    Console.WriteLine(errorMessage);
                    Console.Write("Enter 1, 2, or 3: ");
                    userInput = Console.ReadLine();
                }

                if (userInput == "1")
                {
                    Console.WriteLine("Select a Cinema:");
                    Console.WriteLine("1 - Cinema 1");
                    Console.WriteLine("2 - Cinema 2");
                    string cinema = Console.ReadLine();

                    while (cinema != "1" && cinema != "2")
                    {
                        Console.WriteLine(errorMessage);
                        Console.Write("Enter 1 or 2: ");
                        cinema = Console.ReadLine();
                    }

                    string movieChoice = "";
                    string selectedMovie = "";

                    if (cinema == "1")
                    {
                        Console.WriteLine("Select a Movie:");
                        Console.WriteLine("1 - " + movies[0] + " : Sold Out? true");
                        Console.WriteLine("2 - " + movies[1] + " : Sold Out? false");
                        Console.WriteLine("3 - " + movies[2] + " : Sold Out? false");
                        Console.WriteLine("4 - " + movies[3] + " : Sold Out? true");
                        Console.WriteLine("5 - " + movies[4] + " : Sold Out? false");
                        movieChoice = Console.ReadLine();

                        while (movieChoice != "1" && movieChoice != "2" && movieChoice != "3" && movieChoice != "4" && movieChoice != "5")
                        {
                            Console.WriteLine(errorMessage);
                            Console.Write("Enter a number from 1 to 5: ");
                            movieChoice = Console.ReadLine();
                        }

                        if (movieChoice == "1" || movieChoice == "4")
                        {
                            Console.WriteLine("Tickets are Sold Out.");
                            continue;
                        }

                        selectedMovie = movies[int.Parse(movieChoice) - 1];
                    }
                    else if (cinema == "2")
                    {
                        Console.WriteLine("Select a Movie:");
                        Console.WriteLine("1 - " + movies[0] + " : Sold Out? true");
                        Console.WriteLine("2 - " + movies[1] + " : Sold Out? false");
                        Console.WriteLine("3 - " + movies[2] + " : Sold Out? true");
                        Console.WriteLine("4 - " + movies[3] + " : Sold Out? false");
                        Console.WriteLine("5 - " + movies[4] + " : Sold Out? true");
                        movieChoice = Console.ReadLine();

                        while (movieChoice != "1" && movieChoice != "2" && movieChoice != "3" && movieChoice != "4" && movieChoice != "5")
                        {
                            Console.WriteLine(errorMessage);
                            Console.Write("Enter a number from 1 to 5: ");
                            movieChoice = Console.ReadLine();
                        }

                        if (movieChoice == "1" || movieChoice == "3" || movieChoice == "5")
                        {
                            Console.WriteLine("Tickets are Sold Out.");
                            continue;
                        }

                        selectedMovie = movies[int.Parse(movieChoice) - 1];
                    }

                    Console.WriteLine("Select Time to Watch:");
                    Console.WriteLine("1 - 12:00PM");
                    Console.WriteLine("2 - 5:00PM");
                    string timeChoice = Console.ReadLine();

                    while (timeChoice != "1" && timeChoice != "2")
                    {
                        Console.WriteLine(errorMessage);
                        Console.Write("Enter 1 or 2: ");
                        timeChoice = Console.ReadLine();
                    }

                    string selectedTime = (timeChoice == "1") ? "12:00PM" : "5:00PM";

                    Console.Write("How many tickets would you like to buy? ");
                    string qtyInput = Console.ReadLine();
                    int ticketQuantity;

                    while (!int.TryParse(qtyInput, out ticketQuantity) || ticketQuantity < 1)
                    {
                        Console.WriteLine(errorMessage);
                        Console.Write("Enter a valid ticket quantity: ");
                        qtyInput = Console.ReadLine();
                    }

                    float totalCost = ticketPrice * ticketQuantity;

                    Console.WriteLine("\nTicket Price: ₱" + ticketPrice);
                    Console.WriteLine("Total Cost: ₱" + totalCost);
                    Console.Write("Do you want to confirm your purchase? (yes/no): ");
                    string confirm = Console.ReadLine().ToLower();

                    while (confirm != "yes" && confirm != "no")
                    {
                        Console.WriteLine(errorMessage);
                        Console.Write("Enter 'yes' or 'no': ");
                        confirm = Console.ReadLine().ToLower();
                    }

                    if (confirm == "yes")
                    {
                        Console.Write("Enter payment amount: ₱");
                        string paymentInput = Console.ReadLine();
                        float payment;

                        while (!float.TryParse(paymentInput, out payment) || payment <= 0)
                        {
                            Console.WriteLine(errorMessage);
                            Console.Write("Enter a valid payment: ₱");
                            paymentInput = Console.ReadLine();
                        }

                        if (payment >= totalCost)
                        {
                            float change = payment - totalCost;

                            Console.WriteLine("\nTransaction Complete!");
                            Console.WriteLine("----- RECEIPT -----");
                            Console.WriteLine("Buyer Name: " + username);
                            Console.WriteLine("Cinema No.: " + cinema);
                            Console.WriteLine("Movie: " + selectedMovie);
                            Console.WriteLine("Time of Showing: " + selectedTime);
                            Console.WriteLine("Ticket Quantity: " + ticketQuantity);
                            Console.WriteLine("Total Amount: ₱" + totalCost);
                            Console.WriteLine("Payment: ₱" + payment);
                            if (change > 0)
                            {
                                Console.WriteLine("Change: ₱" + change);
                            }
                            Console.WriteLine("Thank you for trusting Ticket World!");
                            Console.WriteLine("-------------------");
                        }
                        else
                        {
                            float deficit = totalCost - payment;
                            Console.WriteLine("Insufficient payment. You still need ₱" + deficit);
                            Console.WriteLine("Ending program.");
                            isFinished = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Would you like to redo or quit?");
                        Console.WriteLine("1 - Redo");
                        Console.WriteLine("2 - Quit");
                        string choice = Console.ReadLine();

                        while (choice != "1" && choice != "2")
                        {
                            Console.WriteLine(errorMessage);
                            Console.Write("Enter 1 or 2: ");
                            choice = Console.ReadLine();
                        }

                        if (choice == "2")
                        {
                            Console.WriteLine("Thank you for visiting Ticket World!");
                            isFinished = false;
                        }
                    }
                }
                else if (userInput == "2")
                {
                    Console.WriteLine("\nMovie List:");
                    foreach (string movie in movies)
                    {
                        Console.WriteLine(movie);
                    }
                }
                else if (userInput == "3")
                {
                    Console.WriteLine("Thank you for visiting Ticket World!");
                    isFinished = false;
                }
            }
            Console.WriteLine("\nAuthor by: Kalubiran");
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace TestRun.Student
{
    internal class Anda : Student
    {
        public override void Run()
        {
            Game game = new();
        }
    }


























    //  CLASSES FOR THE GAME I DID NOT PUT THIS IN A SEPARATE FILE BECAUSE OF THE STUDENT SELECTOR SYSTEM NEEDS REFRACTORING
    public class Game
    {
        private bool isRunning = false;
        private bool waitingInput = true;
        private InputHandler inputHandler = new InputHandler();
        private PromptHandler promptHandler = new PromptHandler();
        public Game()
        {
            Start();

        }
        private void Start()
        {
            if (!isRunning)
            {
                Console.WriteLine("Game is starting...");
                Console.WriteLine("Welcome to my simple Turn-Based Combat Game");
                isRunning = true;
                Play();
            }
            else
            {
                Console.WriteLine("Game is already running.");
            }
        }
        private void Stop()
        {
            if (isRunning)
            {
                Console.WriteLine("Game is stopping...");
                isRunning = false;
                Console.WriteLine("Thank you for playing! \nAuthor: Anda");
            }
            else
            {
                Console.WriteLine("Game is not running.");
            }
        }
        private void Play()
        {
            if (!isRunning)
            {
                Console.WriteLine("Game is not running. Please start the game first.");
            }
            string? playerName = promptHandler.GetPrompt("Enter your character's name: ");
            if (string.IsNullOrEmpty(playerName))
            {
                Console.WriteLine("Invalid name. Please enter a valid name.");
                return;
            }
            Player player = new(playerName);
            Console.WriteLine($"Welcome, {player.Name}!");
            Enemy enemy = new("Goblin");
            Console.WriteLine($"{player.Name} encounters {enemy.Name}!");
            while (player.Health > 0 && enemy.Health > 0)
            {
                if (waitingInput)
                {
                    Console.WriteLine($"{player.Name}'s turn. Choose an action:");
                    Console.WriteLine("1. Attack");
                    string? input = Console.ReadLine();
                    if (string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid action.");
                        continue;
                    }
                    string action = inputHandler.GetInput(input);
                    if (action == "Attack")
                    {
                        player.Attack(enemy);
                        waitingInput = false;
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.WriteLine(action);
                        continue;
                    }
                }
                else
                {
                    waitingInput = false;
                }
                if (enemy.Health > 0)
                {
                    Console.WriteLine($"{enemy.Name}'s turn.");
                    enemy.Attack(player);
                    waitingInput = true;
                }
            }
            if (player.Health > 0)
            {
                Console.WriteLine($"{player.Name} wins!");
                Stop();
            } else if (enemy.Health > 0)
            {
                Console.WriteLine($"{enemy.Name} wins!");
                Stop();
            }
            else
            {
                Console.WriteLine("It's a draw!");
                Stop();
            }
        }
    }

    internal class Player
    {
        public string Name { get; set; }
        public float Damage { get; set; } = 10f;
        public float Health { get; set; } = 100f;

        public Player(string name)
            {
                Name = name;
            }
            public void Attack(Enemy enemy)
            {
                enemy.TakeDamage(Damage);
            }
        }
    internal class Enemy
        {
            public string Name { get; set; }
            public float Health { get; set; } = 50f;
            public Enemy(string name)
            {
                Name = name;
            }
            public void TakeDamage(float damage)
            {
                Health -= damage;
                Console.WriteLine($"{Name} takes {damage} damage. Remaining health: {Health}");
                if (Health <= 0)
                {
                    Console.WriteLine($"{Name} has been defeated!");
                }
            }
            public void Attack(Player player)
            {
                Console.WriteLine($"{Name} attacks {player.Name}!");
                player.Health -= 10f;
                Console.WriteLine($"{player.Name} takes 10 damage. Remaining health: {player.Health}");
                if (player.Health <= 0)
                {
                    Console.WriteLine($"{player.Name} has been defeated!");
                }
            }
        }

    internal class InputHandler
        {
            public string GetInput(string input)
            {
                switch (input.ToLower())
                {
                    case "1":
                        return "Attack";
                    default:
                        return "Invalid input. Please enter '1' to attack";
                }
            }
        }
    internal class PromptHandler
        {
            public string? GetPrompt(string prompt)
            {
                Console.Write(prompt);
                return Console.ReadLine();
            }
        }
    }




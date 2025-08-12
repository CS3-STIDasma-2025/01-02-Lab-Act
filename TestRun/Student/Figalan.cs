//Prints a display and lets the user input their name, a string
Console.Write("Hello! Welcome! What's your name? ");
string name = Console.ReadLine();
Thread.Sleep(1000); //puts a small delay between lines during execution

//Displays
Console.WriteLine("Hi! So your name is " + name + "?");
Thread.Sleep(1000);//puts a small delay between lines during execution
Console.WriteLine("That's a nice name!");
Thread.Sleep(1000);//puts a small delay between lines during execution
Console.Write("How old are you? ");
Thread.Sleep(1000);//puts a small delay between lines during execution

//Prints a display and lets the user input their age, an int
int age;
age = int.Parse(Console.ReadLine());
Thread.Sleep(1000);//puts a small delay between lines during execution

//Conditional statement for the age
if (age >= 20)
{
    Console.WriteLine("You're quite old..."); //print if 20 or above
}
else
{
    Console.WriteLine("You're quite young..."); //print if 19 and below
}

//Display
Thread.Sleep(1000);//puts a small delay between lines during execution
Console.Write("Do you believe so? (True/False) "); 
Thread.Sleep(1000);//puts a small delay between lines during execution

//Asks for the user to input True or False, a boolean
bool ask;
ask = bool.Parse(Console.ReadLine());
Thread.Sleep(1000);//puts a small delay between lines during execution

//Prints a display and lets the user input their height, a float
Console.Write("How tall are you? (Metre) ");
float height;
height = float.Parse(Console.ReadLine());
Thread.Sleep(1000);//puts a small delay between lines during execution

//Conditional statement for the height
if (height > 1.63 && height < 1.78)
{
    Console.WriteLine("Oh, that's pretty average"); //print if height is higher than 1.63 but lower than 1.78
}else if (height <= 1.63)
{
    Console.WriteLine("Oh, that's quite short..."); //print if height is lower than or equals to 1.63
}
else
{
    Console.WriteLine("Oh, You're tall!"); //print if none of are met
}

//Display
Thread.Sleep(1000);//puts a small delay between lines during execution
Console.WriteLine("Anyways, nice meeting you " + name + "! GOODBYE!"); 
Thread.Sleep(1000);//puts a small delay between lines during execution

using System;

namespace My_Awesome_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Change the appearance

            Console.Title = "Skynet";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 40;

            // Get a conversation going

            Console.WriteLine("Hello, what's your name?");

            Console.ReadLine(); // This make possible to user write in the terminal!

            Console.WriteLine("My name is RX-9000. \nI'm an AI sent from the future to destrou mankind ;)");
            Console.WriteLine("What is your favvoritte color?");

            Console.ReadLine();

            Console.WriteLine("Cool! Mine is destruction.");

            Console.ReadKey();
        }
    }
}
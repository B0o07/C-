using System;

namespace Home_Work_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Change the appearance

            Console.Title = "Soldiers";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 40;

            Console.WriteLine("A soldier by the name...");
            Console.ReadLine();

            Console.WriteLine("are having a conversation with other soldier named...");
            Console.ReadLine();

            Console.WriteLine("Suddenly they here a noise, then when they get closer  to the noise the see...");
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Then they go away.");
        }
    }
}
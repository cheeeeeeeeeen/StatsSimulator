using System;

namespace ConsoleSimulation
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Welcome to The Stats Simulator Console. Please select a command...");
            PrintCommands();
            while (true)
            {
                Console.Write("Command: ");
                CommandReader commandReader = new CommandReader(Console.ReadLine());
                commandReader.Execute();
            }
        }

        public static void PrintCommands()
        {
            Console.WriteLine("Available Commands:");
            Console.WriteLine(" - [0] Perform Attack");
            Console.WriteLine(" - [1] Take Damage");
            Console.WriteLine(" - [exit] Exit the console app");
        }
    }
}
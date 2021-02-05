using System;

namespace ConsoleSimulation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Stats Simulator Console. Please select a command...");
            Console.WriteLine("Available Commands:");
            Console.WriteLine(" - [0] Perform Attack");
            Console.WriteLine(" - [1] Take Damage");
            Console.Write("Command: ");
            CommandReader commandReader = new CommandReader(Console.ReadLine());
            commandReader.Execute();
        }
    }
}
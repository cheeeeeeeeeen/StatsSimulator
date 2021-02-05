using System;

namespace ConsoleSimulation
{
    internal class CommandReader
    {
        private readonly string command = "";

        public CommandReader(string command)
        {
            this.command = command;
        }

        public void Execute()
        {
            switch (command)
            {
                default:
                    Console.WriteLine("This app does nothing for now. Press ENTER to close.");
                    Console.ReadLine();
                    return;
            }
        }
    }
}
using StatsSimulator.Objects;
using System;
using BasicOffense = StatsSimulator.Objects.Offense.Basic;
using BasicDefense = StatsSimulator.Objects.Defense.Basic;

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
                case "0": // Perform Attack
                    Console.Write("Input the character's attack power: ");
                    float attack = float.Parse(Console.ReadLine());
                    Console.Write("Input the target's defense points: ");
                    float defense = float.Parse(Console.ReadLine());
                    BasicOffense offenseCapability = new BasicOffense(attack);
                    BasicDefense defenseCapability = new BasicDefense(defense);
                    Character target = new Character(offenseCapability, defenseCapability);
                    Console.WriteLine($"Damage dealt: {offenseCapability.Perform(target)}");
                    return;

                case "exit": // Exit the console app
                    Environment.Exit(0);
                    return;

                default:
                    Program.PrintCommands();
                    return;
            }
        }
    }
}
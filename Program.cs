using System;

namespace DiceSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");
            int rolls = int.Parse(Console.ReadLine());

            DiceRoller roller = new DiceRoller();
            int[] results = roller.RollDice(rolls);

            Console.WriteLine();
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + rolls + ".");
            Console.WriteLine();

            for (int i = 2; i <= 12; i++)
            {
                double percent = (double)results[i] / rolls * 100;
                int stars = (int)Math.Round(percent);

                Console.Write(i + ": ");
                for (int j = 0; j < stars; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
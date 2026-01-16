using System;

namespace DiceSimulator
{
    public class DiceRoller
    {
        public int[] RollDice(int rolls)
        {
            int[] results = new int[13]; // index 2 through 12 used
            Random rand = new Random();

            for (int i = 0; i < rolls; i++)
            {
                int die1 = rand.Next(1, 7);
                int die2 = rand.Next(1, 7);
                int sum = die1 + die2;
                results[sum]++;
            }

            return results;
        }
    }
}
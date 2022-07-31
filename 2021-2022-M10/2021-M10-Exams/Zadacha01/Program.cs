using System;
using System.Collections.Generic;

namespace Zadacha01
{
    class Program
    {
        static void Main(string[] args)
        {
            int finalSum = 18;
            int currentSum = 0;
            int[] coins = { 10, 10, 5, 5, 2, 2, 1, 1 };
            Queue<int> resultCoins = new Queue<int>();

            for (int i = 0; i < coins.Length; i++)
            {
                if (currentSum + coins[i] > finalSum)
                {
                    continue;
                }
                currentSum += coins[i];
                resultCoins.Enqueue(coins[i]);
                if (currentSum == finalSum)
                {
                    Console.Write("Coins: ");
                    Console.WriteLine(string.Join(", ", resultCoins));
                    Console.WriteLine($"Count = {resultCoins.Count}");
                    return;
                }
            }

            Console.WriteLine("Sum not found");
        }
    }
}

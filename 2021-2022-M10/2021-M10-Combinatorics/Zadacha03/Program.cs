using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadacha03
{
    class Program
    {
        static List<bool[]> sign = new List<bool[]>();
        static bool[] currentSolution;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();
            currentSolution = new bool[n];
            Permute(n, 0);
            foreach (var item in sign)
            {
                var numGuess = new int[n];
                for (int i = 0; i < n; i++)
                {
                    numGuess[i] = (item[i] ? -1 : 1) * numbers[i];
                }
                if (numGuess.Sum() == 0)
                {
                    Console.WriteLine(
                        $"{string.Join(" ", numGuess.Select(x => x>0 ? $"+{x}" : $"{x}"))} = 0");
                }
            }
        }

        private static void Permute(int n, int index)
        {
            if (n == index)
            {
                sign.Add(currentSolution.Clone() as bool[]);
                return;
            }
            currentSolution[index] = true;
            Permute(n, index + 1);
            currentSolution[index] = false;
            Permute(n, index + 1);
        }
    }
}

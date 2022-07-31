using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadacha02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputs = new List<string>();
            var input = Console.ReadLine();
            while (input != "END")
            {
                inputs.Add(input);
                input = Console.ReadLine();
            }

            var board = new int[inputs.Count][];
            for (int i = 0; i < inputs.Count; i++)
            {
                board[i] = inputs[i].Split()
                    .Select(int.Parse).ToArray();
            }

            var max = new int[board.Length][];
            for (int i = 0; i < board.Length; i++)
            {
                max[i] = new int[board.Length + 1];
            }
            max[0][1] = board[0][1];

            for (int i = 1; i < board.Length; i++)
            {
                for (int j = 1; j < board.Length + 1; j++)
                {
                    max[i][j] = Math.Max(board[i][j] + max[i - 1][j - 1], board[i][j] + max[i - 1][j]);
                }
            }

            Console.WriteLine(max.Last().Max());
        }
    }
}

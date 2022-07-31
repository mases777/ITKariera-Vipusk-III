using System;

namespace Zadacha01
{
    class Program
    {
        const int n = 5;
        static int[] elements = new int[] { 0, 1, 2, 3, 4 };
        static bool[] used = new bool[n];
        static int[] perm = new int[n];
        static void Main(string[] args)
        {
            Permute(0);
        }

        private static void Permute(int index)
        {
            if (index >= elements.Length)
            {
                Console.WriteLine(string.Join(" ", perm));
            }
            else
            {
                for (int i = 0; i < elements.Length; i++)
                {
                    if (!used[i])
                    {
                        used[i] = true;
                        perm[index] = elements[i];
                        Permute(index + 1);
                        used[i] = false;
                    }
                }
            }
        }
    }
}

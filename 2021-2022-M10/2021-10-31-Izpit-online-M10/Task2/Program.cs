using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static bool hasPerm = false;
        static List<string> results = new List<string>();
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string[] perm = new string[input.Length];
            bool[] used = new bool[input.Length];
            List<string> strings = new List<string>();
            string line = Console.ReadLine();
            while (line != "end")
            {
                strings.Add(line);
                line = Console.ReadLine();
            }

            Gen(0, input, perm, used, strings);
            if (!hasPerm)
            {
                Console.WriteLine("No permutations...");
            }
            foreach (string item in results.OrderBy(x => x))
            {
                Console.WriteLine(item);
            }

        }

        public static void Gen(int index, string[] str, string[] perm, bool[] used, List<string> strings)
        {
            if (index >= str.Length)
            {
                if (strings.Contains(string.Join("", perm)))
                {
                    results.Add(string.Join(" ", perm));
                    hasPerm = true;
                }
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (!used[i])
                    {
                        used[i] = true;
                        perm[index] = str[i];
                        Gen(index + 1, str, perm, used, strings);
                        used[i] = false;
                    }
                }
            }
        }
    }
}




//class Program
//{
//    static List<char> solutionList = new List<char>();
//    static void Main(string[] args)
//    {
//        var input = Console.ReadLine().Split().ToArray();
//        char[] ch = new char[input.Count()];
//        for (int i = 0; i < ch.Length; i++)
//        {
//            ch[i] = char.Parse(input[i]);
//        }
//        string line = Console.ReadLine();
//        int br = 0;
//        Permute(ch[0], ch[ch.Length - 1]);

//        //while (line != "end")
//        //{
//        //    if (Perm(ch, line))
//        //    {
//        //        Print(ch, line); br++;
//        //    }
//        //    line = Console.ReadLine();
//        //}
//        //if (br == 0) Console.WriteLine("No permutations…");
//    }

//    //public static bool Perm(char[] a, string line)
//    //{
//    //    int j, pom, i = line.Length;
//    //    while (a[i] < a[i - 1]) i--;
//    //    j = i; i--;
//    //    if (i == 0) return false;
//    //    while (a[j] > a[i]) j++;
//    //    pom = a[i]; a[i] = a[j - 1]; a[j - 1] = pom;
//    //    for (j = i + 1; j <= (i + 1 + n) / 2; j++)
//    //    {
//    //        pom = a[j];
//    //        a[j] = a[i + 1 + n - j];
//    //        a[i + 1 + n - j] = pom;
//    //    }
//    //    return true;
//    //}
//    public static void Print(char[] a, string line)
//    {
//        for (int i = 1; i <= line.Length; i++)
//        {
//            Console.Write(a[i] + " ");
//        }
//        Console.WriteLine();
//    }

//    static List<char> currentSolution = new List<char>();

//    private static void Permute(char ind, char n)
//    {
//        if (currentSolution.Count == (n-ind))
//        {
//            solutionList = currentSolution;
//            //for (int i = 0; i < n; i++)
//            //{
//            //    Console.Write("{0,2}", currentSolution[i]);
//            //}
//            Console.WriteLine();
//            return;
//        }

//        for (char i = ind; i <= n; i++)
//        {
//            if (!currentSolution.Contains(i))
//            {
//                currentSolution.Add(i);
//                Permute(ind++, n);
//                currentSolution.Remove(i);
//            }
//        }

//    }



//    //static void Main(string[] args)
//    //{
//    //    const int max = 9; int n;
//    //    do
//    //    {
//    //        n = int.Parse(Console.ReadLine());

//    //    } while (n < 1 || n > max);
//    //    int[] a = new int[n + 2];
//    //    for (int i = 1; i <= n; i++)

//    //        a[i] = i;
//    //    a[0] = a[n + 1] = 0;
//    //    do Print(a, n); while (Perm(a, n));
//    //    Console.ReadKey(true);
//    //}
//    //public static void Print(int[] a, int n)
//    //{
//    //    for (int i = 1; i <= n; i++)
//    //    {
//    //        Console.Write(a[i] + " ");
//    //    }
//    //    Console.WriteLine();
//    //}
//    //public static bool Perm(int[] a, int n)
//    //{
//    //    int j, pom, i = n;
//    //    while (a[i] < a[i - 1]) i--;
//    //    j = i; i--;
//    //    if (i == 0) return false;
//    //    while (a[j] > a[i]) j++;
//    //    pom = a[i]; a[i] = a[j - 1]; a[j - 1] = pom;
//    //    for (j = i + 1; j <= (i + 1 + n) / 2; j++)
//    //    {
//    //        pom = a[j];
//    //        a[j] = a[i + 1 + n - j];
//    //        a[i + 1 + n - j] = pom;
//    //    }
//    //    return true;

//    //}
//}


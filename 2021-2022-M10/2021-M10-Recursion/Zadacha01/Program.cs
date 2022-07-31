using System;

namespace Zadacha01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Gcd(a, b));
            Console.WriteLine(Lcm(a, b));
        }

        private static int Gcd(int a, int b)
        {
            if (a == b)
            {
                return a;
            }
            if (a > b)
            {
                return Gcd(a - b, b);
            }
            else
            {
                return Gcd(a, b - a);
            }
        }

        private static int Lcm(int a, int b)
        {
            return (a * b) / Gcd(a, b);
        }
    }
}

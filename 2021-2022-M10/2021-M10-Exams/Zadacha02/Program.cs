using System;

namespace Zadacha02
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 7, q = 9, r = 0;

            while (p > 1)
            {
                r = (p + q) / p;  // r=(7+9)/7=2
                Console.Write($"1/{r} + ");

                p = p * r - q;
                q = q * r;

                int m = gcd(p, q);
                p = p / m;
                q = q / m;
            }
            Console.WriteLine($"1/{q}");
        }

        private static int gcd(int p, int q)
        {
            if (p > q)
            {
                return gcd(p - q, q);
            }
            else if (q > p)
            {
                return gcd(p, q - p);
            }
            return p;
        }
    }
}

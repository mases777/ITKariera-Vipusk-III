using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadacha03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> w = new List<int> { 7, 3, 4, 5 };
            List<int> v = new List<int> { 42, 12, 40, 25 };

            int maxCapacity = 10;
            int maxValue = 0;

            var weights = GetCombination(w);
            var prices = GetCombination(v);
            int vi = 0;

            foreach (var item in weights)
            {
                int sumPrices = prices[vi].Sum();
                int sumWeights = item.Sum();
                vi++;

                Console.Write(string.Join(" + ", item));
                Console.WriteLine($" = {sumWeights} kg / {sumPrices}$");

                if (sumWeights <= maxCapacity && sumPrices > maxValue)
                {
                    maxValue = sumPrices;
                }
            }
            Console.WriteLine($"Maximum value: {maxValue}$");
        }

        private static List<List<int>> GetCombination(List<int> list)
        {
            var resultList = new List<List<int>>();
            double count = Math.Pow(2, list.Count);
            for (int i = 1; i <= count - 1; i++)
            {
                var nextList = new List<int>();
                string str = Convert.ToString(i, 2).PadLeft(list.Count, '0');
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j] == '1')
                    {
                        nextList.Add(list[j]);
                    }
                }
                resultList.Add(nextList);
            }

            return resultList;
        }
    }
}

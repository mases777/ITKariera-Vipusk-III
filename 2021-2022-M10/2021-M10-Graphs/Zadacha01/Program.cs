using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadacha01
{
    class Program
    {
        static List<int> currentSolution = new List<int>();
        static List<List<int>> allSolution = new List<List<int>>();
        static List<int> visited = new List<int>();
        static Dictionary<int, List<int>> nodes;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            nodes = new Dictionary<int, List<int>>();
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine()
                    .Split(new[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                nodes[line[0]] = line.Skip(1).ToList();
            }
            var searchedPaths = new List<(int start, int finish)>();
            for (int i = 0; i < m; i++)
            {
                var line = Console.ReadLine()
                    .Split(new[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                searchedPaths.Add((line[0], line[1]));
            }
            for (int i = 0; i < m; i++)
            {
                currentSolution = new List<int>();
                allSolution = new List<List<int>>();
                visited = new List<int>();
                Solve(searchedPaths[i].start, searchedPaths[i].finish);
                var min = (allSolution.Count > 0) ? allSolution.Select(x => x.Count).Min() : -1;
                Console.WriteLine($"{{{searchedPaths[i].start}, {searchedPaths[i].finish}}} -> {min}");
            }

        }

        public static void Solve(int start, int finish)
        {
            if (start == finish)
            {
                allSolution.Add(currentSolution.ToList());
                return;
            }
            var toVisit = nodes[start].Where(x => !visited.Contains(x));
            foreach (var item in toVisit)
            {
                visited.Add(start);
                currentSolution.Add(item);
                Solve(item, finish);
                currentSolution.Remove(item);
                visited.Remove(start);
            }
        }
    }
}

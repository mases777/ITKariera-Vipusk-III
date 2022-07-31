using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Program
    {
        static List<string> connections = new List<string>();
        static List<string> insides = new List<string>();
        static List<string> old = new List<string>();
        static List<string> foundConnections = new List<string>();
        static List<string> allConnections = new List<string>();
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            while (line != "end")
            {
                connections.Add(line.Remove(1, 1));
                string inner = line.Split(" ")[1];
                if (!allConnections.Contains(line.Split(" ")[0])) allConnections.Add(line.Split(" ")[0]);
                if (!allConnections.Contains(inner)) allConnections.Add(inner);
                if (!insides.Contains(inner))
                    insides.Add(inner);
                line = Console.ReadLine();
            }

            for (int i = 0; i < insides.Count; i++)
            {
                for (int j = 0; j < connections.Count; j++)
                {
                    if (connections[j][1].ToString() == insides[i])
                    {
                        string reversed = connections[j][1] + "" + connections[j][0];
                        string normal = connections[j][0] + "" + connections[j][1];
                        if (insides.Contains(connections[j][0].ToString()) && connections.Contains(reversed) && !old.Contains(normal))
                        {
                            old.Add(reversed);
                            foundConnections.Add(insides[i] + " <-> " + connections[j][0].ToString());
                        }
                    }
                }
            }

            if (foundConnections.Count == 0)
            {
                Console.WriteLine("Disconnected");
            }
            else
                foreach (var all in allConnections)
                {
                    foreach (string item in foundConnections.OrderBy(x => x))
                    {
                        if (all.Contains(item[0]))
                        {
                            Console.WriteLine(item);
                        }
                    }
                }
        }
    }
}

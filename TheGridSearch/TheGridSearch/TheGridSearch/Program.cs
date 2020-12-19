using System;

namespace TheGridSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static string GridSearch(string[] G, string[] P)
        {
            for (int i = 0; i < G.Length; i++)
            {
                if (P.Length > G.Length - i) return "NO";
                for (int j = 0; j <= G[i].Length - P[0].Length; j++)
                {
                    if (G[i].Substring(j, P[0].Length) == P[0])
                    {
                        var found = true;
                        for (int k = 0; k < P.Length; k++)
                        {
                            if (G[i + k].Substring(j, P[k].Length) == P[k]) continue;
                            found = false;
                            break;
                        }
                        if (found) return "YES";
                    }
                }
            }
            return "NO";
        }
    }
}

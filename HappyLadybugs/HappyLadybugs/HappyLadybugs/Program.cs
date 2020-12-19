using System;
using System.Collections.Generic;
using System.Linq;

namespace HappyLadybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = "RRGGBBXX";
            Console.WriteLine(HappyLadybugs(b));
        }
        static string HappyLadybugs(string b)
        {
            var dict = new Dictionary<char, int>();
            bool isSeperate = false, hasSpace = false;
            for (int i = 0; i < b.Length; i++)
            {
                if (!char.IsLetter(b[i]))
                {
                    hasSpace = true;
                    continue;
                }
                if (!dict.ContainsKey(b[i]))
                    dict[b[i]] = 1;
                else
                {
                    dict[b[i]]++;
                    if (i != 0 && b[i] != b[i - 1])
                        isSeperate = true;
                }
            }
            if (dict.Any(x => x.Value < 2)) return "NO";
            if (!isSeperate) return "YES";
            return hasSpace ? "YES" : "NO";
        }
    }
}

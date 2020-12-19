using System;
using System.Collections.Generic;

namespace QueensAttackII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4, k = 0, r_q = 4, c_q = 4;
            int[][] obstacles = new int[0][];
            Console.WriteLine(QueensAttack(n, k, r_q, c_q, obstacles));
        }
        static int QueensAttack(int n, int k, int r_q, int c_q, int[][] obstacles)
        {
            int[] dr = {-1, 1, 0, 0, -1, 1, -1, 1};
            int[] dc = {0, 0, -1, 1, -1, -1, 1, 1};
            var res = 0;
            var set = new HashSet<string>();
            foreach (var obstacle in obstacles)
                set.Add($"{n - obstacle[0]}:{obstacle[1] - 1}");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    int newR = n - r_q + dr[i] * j;
                    int newC = c_q - 1 + dc[i] * j;
                    if (newR < 0 || newR >= n || newC < 0 || newC >= n || set.Contains($"{newR}:{newC}"))
                        break;
                    res++;
                }
            }
            return res;
        }
    }
}

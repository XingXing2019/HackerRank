using System;

namespace Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "feed the dog";
            Console.WriteLine(Encryption(s));
        }
        static string Encryption(string s)
        {
            var newS = s.Replace(" ", "");
            var col = Math.Ceiling(Math.Sqrt(newS.Length));
            var row = Math.Ceiling(newS.Length / col);
            var letters = new char[(int) row][];
            for (int i = 0; i < letters.Length; i++)
                letters[i] = new char[(int) col];
            int r = 0, c = 0;
            foreach (var letter in newS)
            {
                letters[r][c++] = letter;
                if (c >= col)
                {
                    c = 0;
                    r++;
                }
            }
            var res = "";
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (letters[j][i] != 0)
                        res += letters[j][i];
                }
                res += " ";
            }
            return res;
        }
    }
}

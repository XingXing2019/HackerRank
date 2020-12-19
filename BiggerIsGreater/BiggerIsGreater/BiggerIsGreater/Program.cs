using System;

namespace BiggerIsGreater
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = "dkhc";
            Console.WriteLine(BiggerIsGreater(w));
        }
        static string BiggerIsGreater(string w)
        {
            var letters = w.ToCharArray();
            for (int i = letters.Length - 2; i >= 0; i--)
            {
                if (letters[i + 1] > letters[i])
                {
                    int min = int.MaxValue, pos = 0;
                    for (int j = i + 1; j < letters.Length; j++)
                    {
                        if (letters[j] < min && letters[j] > letters[i])
                        {
                            min = letters[j];
                            pos = j;
                        }
                    }
                    var temp = letters[pos];
                    letters[pos] = letters[i];
                    letters[i] = temp;
                    Array.Sort(letters, i + 1, letters.Length - i - 1);
                    return string.Join("", letters);
                }
            }
            return "no answer";
        }
    }
}

using System;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static string TimeConversion(string s)
        {
            if (s.Substring(s.Length - 2) == "AM")
                return s.Substring(0, 2) == "12" ? "00" + s.Substring(2, s.Length - 4) : s.Substring(0, s.Length - 2);
            return s.Substring(0, 2) == "12"
                ? s.Substring(0, s.Length - 2)
                : (int.Parse(s.Substring(0, 2)) + 12) + s.Substring(2, s.Length - 4);
        }
    }
}

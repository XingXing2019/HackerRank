using System;
using System.Linq;

namespace AppleAndOrange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static void CountApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int appleCount = apples.Count(apple => a + apple >= s && a + apple <= t);
            int orangeCount = oranges.Count(orange => b + orange >= s && b + orange <= t);
            Console.WriteLine(appleCount);
            Console.WriteLine(orangeCount);
        }
    }
}

using System;
using System.Collections.Generic;

namespace BirthdayCakeCandles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static int BirthdayCakeCandles(List<int> candles)
        {
            if (candles.Count == 0) return 0;
            var dict = new Dictionary<int, int>();
            var highest = candles[0];
            foreach (var candle in candles)
            {
                highest = Math.Max(highest, candle);
                if (!dict.ContainsKey(candle))
                    dict[candle] = 0;
                dict[candle]++;
            }
            return dict[highest];
        }
    }
}

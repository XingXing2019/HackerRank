using System;
using System.Collections.Generic;

namespace GradingStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new List<int> {73, 67, 38, 33};
            Console.WriteLine(GradingStudents(grades));
        }
        public static List<int> GradingStudents(List<int> grades)
        {
            var res = new List<int>();
            foreach (var grade in grades)
            {
                if (grade >= 38 && (grade / 5 + 1) * 5 - grade < 3)
                    res.Add((grade / 5 + 1) * 5);
                else
                    res.Add(grade);
            }
            return res;
        }
    }
}

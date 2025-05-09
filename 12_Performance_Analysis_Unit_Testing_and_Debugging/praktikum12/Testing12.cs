using System;
using System.Collections.Generic;

namespace praktikum12
{
    public class Testing12
    {
        public static string DetermineGrade(int number)
        {
            if (number > 100 || number < 0) return null;
            Dictionary<int, string> gradeDictionary = new Dictionary<int, string>()
            {
                { 90, "A" },
                { 80, "B" },
                { 70, "C" },
                { 60, "D" },
                { 50, "E" },
                { 40, "F" }
            };

            foreach (KeyValuePair<int, string> grade in gradeDictionary.OrderByDescending(grade => grade.Key))
            {
                if (number >= grade.Key)
                {
                    return grade.Value;
                }
            }

            return "F"; // Default grade jika nilai di bawah semua threshold
        }

        public static void Main(string[] args)
        {
            var nilai = 90;
            string grade = DetermineGrade(nilai);
            Console.WriteLine($"Grade untuk nilai {nilai} adalah: {grade}");
            Console.ReadKey();
        }
    }
}
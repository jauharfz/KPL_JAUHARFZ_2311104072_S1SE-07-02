using System;
using tpmodul2_2311104072.AnalyzeLetter;
using tpmodul2_2311104072.AnalyzeNumber;

namespace tpmodul2_2311104072
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bagian A: Analisis Huruf
            ILetterAnalyzer letterAnalyzer = new LetterAnalyzer();
            Console.Write("Masukkan satu huruf: ");
            string input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input) && char.IsLetter(input[0]))
            {
                char letter = input[0];
                string result = letterAnalyzer.AnalyzeLetter(letter);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Input tidak valid. Harap masukkan satu huruf.");
            }

            Console.WriteLine();
            Console.ReadKey();

            // Bagian B: Menampilkan bilangan genap
            IEvenNumberGenerator evenNumberGenerator = new EvenNumberGenerator();
            int[] evenNumbers = evenNumberGenerator.GenerateEvenNumbers(start: 2, count: 5);

            for (int i = 0; i < evenNumbers.Length; i++)
            {
                Console.WriteLine($"Angka genap {i + 1} : {evenNumbers[i]}");
            }
            Console.ReadKey();
        }
    }
}

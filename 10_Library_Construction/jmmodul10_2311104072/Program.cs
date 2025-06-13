using System;
using MathLibraries;

namespace ConsoleApp
{
  class Program
  {
      static void Main(string[] args)
      {
          Console.WriteLine("=== MATH LIBRARIES DEMO ===");
          Console.WriteLine();

          // Demo FPB
          Console.WriteLine("1. FAKTOR PERSEKUTUAN TERBESAR (FPB)");
          Console.WriteLine("-----------------------------------");
          
          int a1 = 60, b1 = 45;
          int fpbResult = Calculator.FPB(a1, b1);
          Console.WriteLine($"FPB({a1}, {b1}) = {fpbResult}");
          
          a1 = 48; b1 = 18;
          fpbResult = Calculator.FPB(a1, b1);
          Console.WriteLine($"FPB({a1}, {b1}) = {fpbResult}");
          
          Console.WriteLine();

          // Demo KPK
          Console.WriteLine("2. KELIPATAN PERSEKUTUAN TERKECIL (KPK)");
          Console.WriteLine("---------------------------------------");
          
          int a2 = 12, b2 = 8;
          int kpkResult = Calculator.KPK(a2, b2);
          Console.WriteLine($"KPK({a2}, {b2}) = {kpkResult}");
          
          a2 = 15; b2 = 20;
          kpkResult = Calculator.KPK(a2, b2);
          Console.WriteLine($"KPK({a2}, {b2}) = {kpkResult}");
          
          Console.WriteLine();

          // Demo Turunan
          Console.WriteLine("3. TURUNAN PERSAMAAN POLINOMIAL");
          Console.WriteLine("-------------------------------");
          
          // Contoh: x³ + 4x² - 12x + 9
          int[] persamaan1 = {1, 4, -12, 9};
          string turunanResult = Calculator.Turunan(persamaan1);
          Console.WriteLine("Persamaan: x³ + 4x² - 12x + 9");
          Console.WriteLine($"Turunan: {turunanResult}");
          
          // Contoh lain: 2x⁴ - 3x³ + 5x² - 7x + 1
          int[] persamaan2 = {2, -3, 5, -7, 1};
          turunanResult = Calculator.Turunan(persamaan2);
          Console.WriteLine();
          Console.WriteLine("Persamaan: 2x⁴ - 3x³ + 5x² - 7x + 1");
          Console.WriteLine($"Turunan: {turunanResult}");
          
          Console.WriteLine();

          // Demo Integral
          Console.WriteLine("4. INTEGRAL PERSAMAAN POLINOMIAL");
          Console.WriteLine("--------------------------------");
          
          // Contoh: 4x³ + 6x² - 12x + 9
          int[] persamaan3 = {4, 6, -12, 9};
          string integralResult = Calculator.Integral(persamaan3);
          Console.WriteLine("Persamaan: 4x³ + 6x² - 12x + 9");
          Console.WriteLine($"Integral: {integralResult}");
          
          // Contoh lain: 3x² + 8x - 12
          int[] persamaan4 = {3, 8, -12};
          integralResult = Calculator.Integral(persamaan4);
          Console.WriteLine();
          Console.WriteLine("Persamaan: 3x² + 8x - 12");
          Console.WriteLine($"Integral: {integralResult}");
          
          Console.WriteLine();

          // Interactive testing
          Console.WriteLine("5. TESTING INTERAKTIF");
          Console.WriteLine("--------------------");
          
          Console.Write("Masukkan dua bilangan untuk FPB dan KPK (pisahkan dengan spasi): ");
          string input = Console.ReadLine();
          
          if (!string.IsNullOrEmpty(input))
          {
              string[] numbers = input.Split(' ');
              if (numbers.Length >= 2 && 
                  int.TryParse(numbers[0], out int num1) && 
                  int.TryParse(numbers[1], out int num2))
              {
                  Console.WriteLine($"FPB({num1}, {num2}) = {Calculator.FPB(num1, num2)}");
                  Console.WriteLine($"KPK({num1}, {num2}) = {Calculator.KPK(num1, num2)}");
              }
              else
              {
                  Console.WriteLine("Input tidak valid!");
              }
          }

          Console.WriteLine();
          Console.WriteLine("=== DEMO SELESAI ===");
          Console.WriteLine("Tekan sembarang tombol untuk keluar...");
          Console.ReadKey();
      }
  }
}
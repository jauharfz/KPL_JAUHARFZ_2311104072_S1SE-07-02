namespace MathLibraries;

using System;
using System.Text;

public class Calculator
{
    /// <summary>
    /// Mencari Faktor Persekutuan Terbesar (FPB) dari dua bilangan
    /// </summary>
    /// <param name="input1">Bilangan pertama</param>
    /// <param name="input2">Bilangan kedua</param>
    /// <returns>FPB dari kedua bilangan</returns>
    public static int FPB(int input1, int input2)
    {
        // Menggunakan algoritma Euclidean
        input1 = Math.Abs(input1);
        input2 = Math.Abs(input2);

        while (input2 != 0)
        {
            int temp = input2;
            input2 = input1 % input2;
            input1 = temp;
        }

        return input1;
    }

    /// <summary>
    /// Mencari Kelipatan Persekutuan Terkecil (KPK) dari dua bilangan
    /// </summary>
    /// <param name="input1">Bilangan pertama</param>
    /// <param name="input2">Bilangan kedua</param>
    /// <returns>KPK dari kedua bilangan</returns>
    public static int KPK(int input1, int input2)
    {
        // KPK = (a * b) / FPB(a, b)
        return Math.Abs(input1 * input2) / FPB(input1, input2);
    }

    /// <summary>
    /// Mendapatkan hasil turunan dari persamaan polinomial
    /// </summary>
    /// <param name="persamaan">Array koefisien dari pangkat tertinggi ke terendah</param>
    /// <returns>String representasi turunan</returns>
    public static string Turunan(int[] persamaan)
    {
        if (persamaan == null || persamaan.Length == 0)
            return "0";

        if (persamaan.Length == 1)
            return "0"; // Turunan konstanta adalah 0

        StringBuilder result = new StringBuilder();
        bool isFirst = true;

        // Proses turunan: d/dx(ax^n) = n*ax^(n-1)
        for (int i = 0; i < persamaan.Length - 1; i++)
        {
            int koefisien = persamaan[i];
            int pangkat = persamaan.Length - 1 - i; // Pangkat saat ini
            int koefisienTurunan = koefisien * pangkat;

            if (koefisienTurunan == 0)
                continue;

            // Tambahkan tanda
            if (!isFirst)
            {
                if (koefisienTurunan > 0)
                    result.Append(" + ");
                else
                {
                    result.Append(" - ");
                    koefisienTurunan = Math.Abs(koefisienTurunan);
                }
            }
            else
            {
                if (koefisienTurunan < 0)
                {
                    result.Append("-");
                    koefisienTurunan = Math.Abs(koefisienTurunan);
                }

                isFirst = false;
            }

            // Tambahkan koefisien dan variabel
            int pangkatTurunan = pangkat - 1;

            if (pangkatTurunan == 0)
            {
                // Konstanta
                result.Append(koefisienTurunan);
            }
            else if (pangkatTurunan == 1)
            {
                // x pangkat 1
                if (koefisienTurunan == 1)
                    result.Append("x");
                else
                    result.Append($"{koefisienTurunan}x");
            }
            else
            {
                // x pangkat > 1
                if (koefisienTurunan == 1)
                    result.Append($"x{pangkatTurunan}");
                else
                    result.Append($"{koefisienTurunan}x{pangkatTurunan}");
            }
        }

        return result.Length == 0 ? "0" : result.ToString();
    }

    /// <summary>
    /// Mendapatkan hasil integral dari persamaan polinomial
    /// </summary>
    /// <param name="persamaan">Array koefisien dari pangkat tertinggi ke terendah</param>
    /// <returns>String representasi integral</returns>
    public static string Integral(int[] persamaan)
    {
        if (persamaan == null || persamaan.Length == 0)
            return "C";

        StringBuilder result = new StringBuilder();
        bool isFirst = true;

        // Proses integral: ∫ax^n dx = (a/(n+1))x^(n+1)
        for (int i = 0; i < persamaan.Length; i++)
        {
            int koefisien = persamaan[i];
            if (koefisien == 0)
                continue;

            int pangkat = persamaan.Length - 1 - i; // Pangkat saat ini
            int pangkatIntegral = pangkat + 1;

            // Tambahkan tanda
            if (!isFirst)
            {
                if (koefisien > 0)
                    result.Append(" + ");
                else
                {
                    result.Append(" - ");
                    koefisien = Math.Abs(koefisien);
                }
            }
            else
            {
                if (koefisien < 0)
                {
                    result.Append("-");
                    koefisien = Math.Abs(koefisien);
                }

                isFirst = false;
            }

            // Hitung koefisien integral
            // Untuk menyederhanakan, kita asumsikan hasilnya selalu integer
            if (pangkatIntegral == 1)
            {
                // x pangkat 1
                if (koefisien == 1)
                    result.Append("x");
                else
                    result.Append($"{koefisien}x");
            }
            else
            {
                // x pangkat > 1
                // Koefisien integral = koefisien / (pangkat + 1)
                // Untuk contoh yang diberikan, kita asumsikan hasilnya sudah sesuai
                if (koefisien == pangkatIntegral)
                    result.Append($"x{pangkatIntegral}");
                else
                {
                    // Sederhanakan pecahan jika memungkinkan
                    int fpb = FPB(koefisien, pangkatIntegral);
                    int pembilang = koefisien / fpb;
                    int penyebut = pangkatIntegral / fpb;

                    if (penyebut == 1)
                        result.Append($"{pembilang}x{pangkatIntegral}");
                    else if (pembilang == 1)
                        result.Append($"x{pangkatIntegral}/{penyebut}");
                    else
                        result.Append($"{pembilang}x{pangkatIntegral}/{penyebut}");
                }
            }
        }

        // Tambahkan konstanta integrasi
        if (result.Length == 0)
            result.Append("C");
        else
            result.Append(" + C");

        return result.ToString();
    }
}
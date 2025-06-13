using System;

namespace jmmodul13_2311104072;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== IMPLEMENTASI DESIGN PATTERN SINGLETON ===");
        Console.WriteLine();

        // A. Membuat dua variable dengan tipe PusatDataSingleton
        PusatDataSingleton data1 = PusatDataSingleton.GetDataSingleton();
        PusatDataSingleton data2 = PusatDataSingleton.GetDataSingleton();

        // Verifikasi bahwa kedua variable merujuk ke instance yang sama
        Console.WriteLine($"Apakah data1 dan data2 adalah instance yang sama? {ReferenceEquals(data1, data2)}");
        Console.WriteLine();

        // C. Menambahkan data melalui data1
        Console.WriteLine("=== Menambahkan Data Melalui data1 ===");
        data1.AddSebuahData("jauharfz");
        data1.AddSebuahData("pradana");
        data1.AddSebuahData("izzati");
        data1.AddSebuahData("rizaldy");
        data1.AddSebuahData("zaidan");
        data1.AddSebuahData("gide");
        Console.WriteLine();

        // D. Print data melalui data2
        Console.WriteLine("=== Print Data Melalui data2 ===");
        data2.PrintSemuaData();
        Console.WriteLine();

        // E. Hapus data asisten praktikum melalui data2
        Console.WriteLine("=== Menghapus Data Asisten Praktikum ===");
        data2.HapusSebuahData(5); // Index 3 untuk "Asisten Praktikum - Budi"
        Console.WriteLine();

        // F. Print data melalui data1 (seharusnya asisten sudah terhapus)
        Console.WriteLine("=== Print Data Melalui data1 (Setelah Penghapusan) ===");
        data1.PrintSemuaData();
        Console.WriteLine();

        // G. Print jumlah elemen dari kedua variable
        Console.WriteLine("=== Jumlah Elemen dalam List ===");
        Console.WriteLine($"Jumlah elemen di data1: {data1.GetSemuaData().Count}");
        Console.WriteLine($"Jumlah elemen di data2: {data2.GetSemuaData().Count}");
        Console.WriteLine();

        // Demonstrasi tambahan - menunjukkan bahwa perubahan di satu variable
        // mempengaruhi variable lainnya karena mereka adalah instance yang sama
        Console.WriteLine("=== Demonstrasi Singleton Behavior ===");
        data1.AddSebuahData("Data Baru dari data1");
        Console.WriteLine("Data ditambahkan melalui data1, tapi akan terlihat di data2:");
        data2.PrintSemuaData();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
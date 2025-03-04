using System;
using System.Collections.Generic;
using tpmodul4_2311104072.ListKodePos;

namespace TableDrivenExample
{

    // Kelas utama program
    class Program
    {
        static void Main(string[] args)
        {
            // Menggunakan interface untuk mendeklarasikan dependency (Dependency Inversion)
            IKodePos kodePosService = new KodePos();

            Console.Write("Masukkan nama kelurahan: ");
            string kelurahanInput = Console.ReadLine();

            int? kodePos = kodePosService.GetKodePos(kelurahanInput);

            if (kodePos.HasValue)
            {
                Console.WriteLine($"Kode pos untuk {kelurahanInput} adalah: {kodePos.Value}");
            }
            else
            {
                Console.WriteLine("Kelurahan tidak ditemukan.");
            }
        }
    }
}

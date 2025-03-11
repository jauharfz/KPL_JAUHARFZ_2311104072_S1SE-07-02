using System;
using System.Collections.Generic;
using tpmodul4_2311104072.DoorMachine;
using tpmodul4_2311104072.PostalCodeList;

namespace TableDrivenExample
{

    // =========================================================
    // Kelas utama program
    // =========================================================
    class Program
    {
        static void Main(string[] args)
        {
            // Contoh penggunaan Table-Driven (KodePos)
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

            Console.WriteLine();

            // Contoh penggunaan State-Based Construction (DoorMachine)
            DoorMachine doorMachine = new DoorMachine();

            // Simulasi transisi state
            Console.WriteLine("Tekan ENTER untuk membuka pintu...");
            Console.ReadLine();
            doorMachine.BukaPintu();    // Terkunci -> Terbuka

            Console.WriteLine("Tekan ENTER untuk mengunci pintu...");
            Console.ReadLine();
            doorMachine.KunciPintu();  // Terbuka -> Terkunci

            Console.WriteLine("\nTekan ENTER untuk keluar...");
            Console.ReadLine();
        }
    }
}

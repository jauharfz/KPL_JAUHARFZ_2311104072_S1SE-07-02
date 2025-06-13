using System;

namespace jmmodul7_2311104072;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Jurnal Modul 7 - Kelompok 5"); 
        Console.WriteLine("==============================");

        // Panggil ReadJSON untuk DataMahasiswa
        DataMahasiswa_2311104072 dataMhs = new DataMahasiswa_2311104072(); 
        dataMhs.ReadJSON();

        // Panggil ReadJSON untuk TeamMembers
        TeamMembers_2311104072 team = new TeamMembers_2311104072(); 
        team.ReadJSON();

        // Panggil ReadJSON untuk GlossaryItem
        GlossaryItem_2311104072 glossary = new GlossaryItem_2311104072(); 
        glossary.ReadJSON();

        Console.WriteLine("\nTekan tombol apapun untuk keluar...");
        Console.ReadKey();
    }
}
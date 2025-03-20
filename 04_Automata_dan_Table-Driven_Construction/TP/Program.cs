using System;
using System.Collections.Generic;
using tpmodul4_2311104072.DoorMachine;
using tpmodul4_2311104072.PostalCodeList;

namespace TableDrivenExample
{
    class Program
    {
        static void Main(string[] args)
        {
            /*IKodePos kodePos = new KodePos();
            var kelurahanInput = Console.ReadLine();
            Console.WriteLine(kodePos.GetKodePos(kelurahanInput));*/

            DoorMachine current = new DoorMachine();
            while (true)
            {
                Console.WriteLine("Anda hanya punya 3 pilihan: ");
                Console.WriteLine("1.Ketik buka untuk membuka pintu");
                Console.WriteLine("2.Ketik tutup untuk menutup pintu");
                Console.WriteLine("3. Ketik keluar untuk keluar");
                current.showState();
                var userInput = Console.ReadLine();
                if (string.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine("TIMDAK BOMLEH KOMSONMG!");
                    Console.WriteLine();
                    continue;
                }

                if (userInput.Equals("buka", StringComparison.OrdinalIgnoreCase))
                {
                    current.terbuka();
                }
                else if (userInput.Equals("kunci", StringComparison.OrdinalIgnoreCase))
                {
                    current.terkunci();
                }
                else if (userInput.Equals("keluar", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("GET - !");
                    break;
                }
                else
                {
                    Console.WriteLine("mff input yang anda masukan timdak vamlid");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
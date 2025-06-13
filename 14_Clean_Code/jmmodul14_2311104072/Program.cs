using System;
using System.Collections.Generic;
using System.Threading;

namespace jmmodul14_2311104072;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== OBSERVER PATTERN IMPLEMENTATION ===");
        Console.WriteLine("Nama: Jauhar Fajar Zuhair");
        Console.WriteLine("NIM: 2311104072");
        Console.WriteLine("Kelas: S1SE-07-02");
        Console.WriteLine("========================================\n");

        // The client code.
        var subject = new Subject();
        var observerA = new ConcreteObserverA();
        subject.Attach(observerA);

        var observerB = new ConcreteObserverB();
        subject.Attach(observerB);

        subject.SomeBusinessLogic();
        subject.SomeBusinessLogic();

        subject.Detach(observerB);

        subject.SomeBusinessLogic();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
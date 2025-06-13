namespace jmmodul13_2311104072;

using System;
using System.Collections.Generic;

public class PusatDataSingleton
{
    private static PusatDataSingleton _instance = null;
    private static readonly object _lock = new object();

    public List<string> DataTersimpan { get; private set; }

    // Private constructor
    private PusatDataSingleton()
    {
        DataTersimpan = new List<string>();
    }

    // Thread-safe singleton instance getter
    public static PusatDataSingleton GetDataSingleton()
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new PusatDataSingleton();
                }
            }
        }

        return _instance;
    }

    public List<string> GetSemuaData()
    {
        return DataTersimpan;
    }

    public void PrintSemuaData()
    {
        Console.WriteLine("=== Data yang Tersimpan ===");
        if (DataTersimpan.Count == 0)
        {
            Console.WriteLine("Tidak ada data yang tersimpan.");
            return;
        }

        for (int i = 0; i < DataTersimpan.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {DataTersimpan[i]}");
        }

        Console.WriteLine("===========================");
    }

    public void AddSebuahData(string input)
    {
        if (!string.IsNullOrWhiteSpace(input))
        {
            DataTersimpan.Add(input);
            Console.WriteLine($"Data '{input}' berhasil ditambahkan.");
        }
        else
        {
            Console.WriteLine("Input tidak valid. Data tidak ditambahkan.");
        }
    }

    public void HapusSebuahData(int index)
    {
        if (index >= 0 && index < DataTersimpan.Count)
        {
            string removedData = DataTersimpan[index];
            DataTersimpan.RemoveAt(index);
            Console.WriteLine($"Data '{removedData}' berhasil dihapus.");
        }
        else
        {
            Console.WriteLine("Index tidak valid. Data tidak dihapus.");
        }
    }
}
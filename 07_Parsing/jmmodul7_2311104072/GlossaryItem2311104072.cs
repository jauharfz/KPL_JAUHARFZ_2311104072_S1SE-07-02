namespace jmmodul7_2311104072;

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization; // Diperlukan untuk [JsonPropertyName] jika nama properti C# berbeda dari JSON

// Kelas root untuk jurnal7_3_2311104072.json
public class GlossaryRoot_2311104072 
{
    public Glossary glossary { get; set; }
}

public class Glossary
{
    public string title { get; set; }
    public GlossDiv GlossDiv { get; set; } // Nama properti C# sama dengan JSON
}

public class GlossDiv
{
    public string title { get; set; }
    public GlossList GlossList { get; set; } // Nama properti C# sama dengan JSON
}

public class GlossList
{
    public GlossEntry GlossEntry { get; set; } // Nama properti C# sama dengan JSON
}

public class GlossEntry
{
    public string ID { get; set; }
    public string SortAs { get; set; }
    public string GlossTerm { get; set; }
    public string Acronym { get; set; }
    public string Abbrev { get; set; }
    public GlossDef GlossDef { get; set; } // Nama properti C# sama dengan JSON
    public string GlossSee { get; set; }
}

public class GlossDef
{
    public string para { get; set; }

    // JSON memiliki "GlossSeeAlso" sebagai array string
    public List<string> GlossSeeAlso { get; set; }
}

// Kelas terpisah untuk method ReadJSON sesuai instruksi 6B
public class GlossaryItem_2311104072
{
    // Method ReadJSON (Instruksi 6C)
    public void ReadJSON()
    {
        string jsonFilePath = "jurnal7_3_2311104072.json"; 
        Console.WriteLine($"\n--- Membaca Data Glossary dari {jsonFilePath} ---");

        try
        {
            if (!File.Exists(jsonFilePath))
            {
                Console.WriteLine($"Error: File {jsonFilePath} tidak ditemukan.");
                return;
            }

            string jsonData = File.ReadAllText(jsonFilePath);
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            // Deserialize ke kelas root
            GlossaryRoot_2311104072 root = JsonSerializer.Deserialize<GlossaryRoot_2311104072>(jsonData, options);

            // Print hanya bagian GlossEntry (Instruksi 6D - Format Bebas)
            if (root?.glossary?.GlossDiv?.GlossList?.GlossEntry != null)
            {
                GlossEntry entry = root.glossary.GlossDiv.GlossList.GlossEntry;
                Console.WriteLine("GlossEntry Details:");
                Console.WriteLine($"  ID: {entry.ID}");
                Console.WriteLine($"  SortAs: {entry.SortAs}");
                Console.WriteLine($"  GlossTerm: {entry.GlossTerm}");
                Console.WriteLine($"  Acronym: {entry.Acronym}");
                Console.WriteLine($"  Abbrev: {entry.Abbrev}");
                if (entry.GlossDef != null)
                {
                    Console.WriteLine("  GlossDef:");
                    Console.WriteLine($"    para: {entry.GlossDef.para}");
                    if (entry.GlossDef.GlossSeeAlso != null && entry.GlossDef.GlossSeeAlso.Count > 0)
                    {
                        Console.WriteLine($"    GlossSeeAlso: {string.Join(", ", entry.GlossDef.GlossSeeAlso)}");
                    }
                }

                Console.WriteLine($"  GlossSee: {entry.GlossSee}");
            }
            else
            {
                Console.WriteLine("Gagal menemukan GlossEntry dalam data atau gagal deserialisasi.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Terjadi error saat membaca JSON: {ex.Message}");
        }
    }
}
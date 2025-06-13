namespace jmmodul7_2311104072;

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

// Kelas untuk menampung data dari jurnal7_2_2311104072.json
public class TeamMembers_2311104072 
{
    // Properti utama: daftar anggota
    public List<Member> members { get; set; }

    // Nested class untuk satu anggota
    public class Member
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }

    // Method ReadJSON (Instruksi 4D)
    public void ReadJSON()
    {
        string jsonFilePath = "jurnal7_2_2311104072.json";
        Console.WriteLine($"\n--- Membaca Data Anggota Tim dari {jsonFilePath} ---");

        try
        {
            if (!File.Exists(jsonFilePath))
            {
                Console.WriteLine($"Error: File {jsonFilePath} tidak ditemukan.");
                return;
            }

            string jsonData = File.ReadAllText(jsonFilePath);
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            // Deserialize root object yang berisi list 'members'
            TeamMembers_2311104072 teamData = JsonSerializer.Deserialize<TeamMembers_2311104072>(jsonData, options);

            // Print hasil sesuai format (Instruksi 4E)
            if (teamData != null && teamData.members != null && teamData.members.Count > 0)
            {
                Console.WriteLine("Team member list:");
                foreach (var member in teamData.members)
                {
                    Console.WriteLine(
                        $"{member.nim} {member.firstName} {member.lastName} ({member.age} {member.gender})");
                }
            }
            else
            {
                Console.WriteLine("Tidak ada data anggota tim atau gagal deserialisasi.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Terjadi error saat membaca JSON: {ex.Message}");
        }
    }
}
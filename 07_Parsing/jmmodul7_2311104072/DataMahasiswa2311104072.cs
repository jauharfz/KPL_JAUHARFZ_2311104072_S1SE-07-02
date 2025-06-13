namespace jmmodul7_2311104072;

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

// Kelas untuk menampung data dari jurnal7_1_2311104072.json
public class DataMahasiswa_2311104072 
{
    // Properti sesuai struktur JSON
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public Address address { get; set; }
    public List<Course> courses { get; set; }

    // Nested class untuk address
    public class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }

    // Nested class untuk course
    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    // Method ReadJSON (Instruksi 2D)
    public void ReadJSON()
    {
        string jsonFilePath = "jurnal7_1_2311104072.json"; 
        Console.WriteLine($"\n--- Membaca Data Mahasiswa dari {jsonFilePath} ---");

        try
        {
            if (!File.Exists(jsonFilePath))
            {
                Console.WriteLine($"Error: File {jsonFilePath} tidak ditemukan.");
                return;
            }

            string jsonData = File.ReadAllText(jsonFilePath);

            // Opsi untuk case-insensitive property matching
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            DataMahasiswa_2311104072 data = JsonSerializer.Deserialize<DataMahasiswa_2311104072>(jsonData, options);

            // Print hasil deserialisasi (Instruksi 2E - Format Bebas)
            if (data != null)
            {
                Console.WriteLine($"Nama Lengkap: {data.firstName} {data.lastName}");
                Console.WriteLine($"Jenis Kelamin: {data.gender}");
                Console.WriteLine($"Umur: {data.age}");
                if (data.address != null)
                {
                    Console.WriteLine("Alamat:");
                    Console.WriteLine($"  Jalan: {data.address.streetAddress}");
                    Console.WriteLine($"  Kota: {data.address.city}");
                    Console.WriteLine($"  Provinsi: {data.address.state}");
                }

                if (data.courses != null && data.courses.Count > 0)
                {
                    Console.WriteLine("Mata Kuliah:");
                    foreach (var course in data.courses)
                    {
                        Console.WriteLine($"  - {course.code}: {course.name}");
                    }
                }
                else
                {
                    Console.WriteLine("Tidak ada data mata kuliah.");
                }
            }
            else
            {
                Console.WriteLine("Gagal deserialisasi data mahasiswa.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Terjadi error saat membaca JSON: {ex.Message}");
        }
    }
}
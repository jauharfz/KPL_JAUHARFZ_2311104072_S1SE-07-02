using jmmodul15_2311104072.Models;

namespace jmmodul15_2311104072.Services;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

public static class FileService
{
    private static readonly string FilePath = "users.json";

    // Membaca semua user dari file JSON
    public static List<User> LoadUsers()
    {
        try
        {
            if (!File.Exists(FilePath))
            {
                return new List<User>();
            }

            string jsonString = File.ReadAllText(FilePath);
            if (string.IsNullOrEmpty(jsonString))
            {
                return new List<User>();
            }

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<List<User>>(jsonString, options) ?? new List<User>();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error membaca file users: {ex.Message}");
        }
    }

    // Menyimpan semua user ke file JSON
    public static void SaveUsers(List<User> users)
    {
        try
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(users, options);
            File.WriteAllText(FilePath, jsonString);
        }
        catch (Exception ex)
        {
            throw new Exception($"Error menyimpan file users: {ex.Message}");
        }
    }

    // Menambah user baru
    public static bool RegisterUser(string username, string password)
    {
        try
        {
            var users = LoadUsers();

            // Cek apakah username sudah ada
            if (users.Any(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
            {
                return false; // Username sudah ada
            }

            // Hash password dan tambahkan user baru
            string hashedPassword = PasswordService.HashPassword(password);
            users.Add(new User(username, hashedPassword));

            SaveUsers(users);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    // Login user
    public static bool LoginUser(string username, string password)
    {
        try
        {
            var users = LoadUsers();
            var user = users.FirstOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));

            if (user == null)
            {
                return false; // User tidak ditemukan
            }

            return PasswordService.VerifyPassword(password, user.PasswordHash);
        }
        catch (Exception)
        {
            return false;
        }
    }
}
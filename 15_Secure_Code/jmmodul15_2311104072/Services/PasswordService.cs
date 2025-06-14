namespace jmmodul15_2311104072.Services;

using System;
using System.Security.Cryptography;
using System.Text;

public static class PasswordService
{
    // B. Password Management - Password hashing dengan SHA256
    public static string HashPassword(string password)
    {
        try
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Tambahkan salt untuk keamanan tambahan
                string saltedPassword = password + "SecureApp2024Salt";

                // Compute hash dari password yang sudah di-salt
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword));

                // Convert byte array ke string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Error saat hashing password: {ex.Message}");
        }
    }

    // Verifikasi password dengan hash yang tersimpan
    public static bool VerifyPassword(string password, string hash)
    {
        try
        {
            string hashOfInput = HashPassword(password);
            return hashOfInput.Equals(hash, StringComparison.OrdinalIgnoreCase);
        }
        catch (Exception)
        {
            return false;
        }
    }
}
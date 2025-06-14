namespace jmmodul15_2311104072.Services;

using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class ValidationService
{
    // A. Input Validation - Validasi panjang data
    public static bool ValidateLength(string input, int minLength = 3, int maxLength = 20)
    {
        if (string.IsNullOrEmpty(input))
            return false;

        return input.Length >= minLength && input.Length <= maxLength;
    }

    // A. Input Validation - Validasi range data (hanya alfabet ASCII dan angka)
    public static bool ValidateUsernameFormat(string username)
    {
        if (string.IsNullOrEmpty(username))
            return false;

        // Hanya boleh huruf alfabet ASCII dan angka
        return Regex.IsMatch(username, @"^[a-zA-Z0-9]+$");
    }

    // B. Password Management - Password rules
    public static ValidationResult ValidatePassword(string password, string username = "")
    {
        var result = new ValidationResult();

        // Minimal 8 karakter, maksimal 20 karakter
        if (!ValidateLength(password, 8, 20))
        {
            result.IsValid = false;
            result.ErrorMessage += "Password harus antara 8-20 karakter. ";
        }

        // Harus mengandung minimal 1 huruf besar
        if (!password.Any(char.IsUpper))
        {
            result.IsValid = false;
            result.ErrorMessage += "Password harus mengandung minimal 1 huruf besar. ";
        }

        // Harus mengandung minimal 1 angka
        if (!password.Any(char.IsDigit))
        {
            result.IsValid = false;
            result.ErrorMessage += "Password harus mengandung minimal 1 angka. ";
        }

        // Harus mengandung minimal 1 karakter khusus
        if (!Regex.IsMatch(password, @"[!@#$%^&*(),.?""':;{}|<>]"))
        {
            result.IsValid = false;
            result.ErrorMessage += "Password harus mengandung minimal 1 karakter khusus (!@#$%^&*). ";
        }

        // Password tidak boleh mengandung username
        if (!string.IsNullOrEmpty(username) &&
            password.ToLower().Contains(username.ToLower()))
        {
            result.IsValid = false;
            result.ErrorMessage += "Password tidak boleh mengandung username. ";
        }

        return result;
    }

    // A. Input Validation - Handling data invalid
    public static ValidationResult ValidateUsername(string username)
    {
        var result = new ValidationResult();

        try
        {
            // Validasi panjang
            if (!ValidateLength(username, 3, 20))
            {
                result.IsValid = false;
                result.ErrorMessage += "Username harus antara 3-20 karakter. ";
            }

            // Validasi format
            if (!ValidateUsernameFormat(username))
            {
                result.IsValid = false;
                result.ErrorMessage += "Username hanya boleh mengandung huruf dan angka. ";
            }
        }
        catch (Exception ex)
        {
            result.IsValid = false;
            result.ErrorMessage = $"Error validasi username: {ex.Message}";
        }

        return result;
    }
}

public class ValidationResult
{
    public bool IsValid { get; set; } = true;
    public string ErrorMessage { get; set; } = "";
}
namespace jmmodul15_2311104072.Models;

using System;
using System.Text.Json.Serialization;

public class User
{
    [JsonPropertyName("username")] public string Username { get; set; }

    [JsonPropertyName("passwordHash")] public string PasswordHash { get; set; }

    [JsonPropertyName("registrationDate")] public DateTime RegistrationDate { get; set; }

    public User()
    {
        RegistrationDate = DateTime.Now;
    }

    public User(string username, string passwordHash)
    {
        Username = username;
        PasswordHash = passwordHash;
        RegistrationDate = DateTime.Now;
    }
}
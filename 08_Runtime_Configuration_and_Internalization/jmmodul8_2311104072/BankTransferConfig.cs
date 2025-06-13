namespace jmmodul8_2311104072;

using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

public class BankTransferConfig
{
  public string Lang { get; set; } = "en";
  public TransferSettings Transfer { get; set; } = new TransferSettings();
  public List<string> Methods { get; set; } = new List<string> 
  { 
      "RTO (real-time)", "SKN", "RTGS", "BI FAST" 
  };
  public ConfirmationSettings Confirmation { get; set; } = new ConfirmationSettings();

  private const string ConfigFileName = "bank_transfer_config.json";

  public static BankTransferConfig LoadConfig()
  {
      if (File.Exists(ConfigFileName))
      {
          try
          {
              string jsonString = File.ReadAllText(ConfigFileName);
              var options = new JsonSerializerOptions
              {
                  PropertyNameCaseInsensitive = true
              };
              return JsonSerializer.Deserialize<BankTransferConfig>(jsonString, options) ?? GetDefaultConfig();
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Error loading config: {ex.Message}");
              return GetDefaultConfig();
          }
      }
      else
      {
          var defaultConfig = GetDefaultConfig();
          defaultConfig.SaveConfig();
          return defaultConfig;
      }
  }

  public void SaveConfig()
  {
      try
      {
          var options = new JsonSerializerOptions
          {
              WriteIndented = true,
              PropertyNamingPolicy = JsonNamingPolicy.CamelCase
          };
          string jsonString = JsonSerializer.Serialize(this, options);
          File.WriteAllText(ConfigFileName, jsonString);
      }
      catch (Exception ex)
      {
          Console.WriteLine($"Error saving config: {ex.Message}");
      }
  }

  // Method baru untuk update bahasa saat runtime
  public void UpdateLanguage(string newLang)
  {
      if (newLang == "en" || newLang == "id")
      {
          this.Lang = newLang;
          this.SaveConfig();
      }
  }

  // Method baru untuk update threshold saat runtime
  public void UpdateThreshold(long newThreshold)
  {
      this.Transfer.Threshold = newThreshold;
      this.SaveConfig();
  }

  // Method baru untuk update fee saat runtime
  public void UpdateFees(int lowFee, int highFee)
  {
      this.Transfer.LowFee = lowFee;
      this.Transfer.HighFee = highFee;
      this.SaveConfig();
  }

  private static BankTransferConfig GetDefaultConfig()
  {
      return new BankTransferConfig
      {
          Lang = "en",
          Transfer = new TransferSettings
          {
              Threshold = 25000000,
              LowFee = 6500,
              HighFee = 15000
          },
          Methods = new List<string> { "RTO (real-time)", "SKN", "RTGS", "BI FAST" },
          Confirmation = new ConfirmationSettings
          {
              En = "yes",
              Id = "ya"
          }
      };
  }
}

public class TransferSettings
{
  public long Threshold { get; set; } = 25000000;
  public int LowFee { get; set; } = 6500;
  public int HighFee { get; set; } = 15000;
}

public class ConfirmationSettings
{
  public string En { get; set; } = "yes";
  public string Id { get; set; } = "ya";
}
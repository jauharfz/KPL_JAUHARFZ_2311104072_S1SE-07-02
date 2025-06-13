using System;

namespace jmmodul8_2311104072;

class Program
{
  static void Main(string[] args)
  {
      // Load konfigurasi
      var config = BankTransferConfig.LoadConfig();
      
      // Step 0: Pilih bahasa saat runtime
      Console.WriteLine("=== Bank Transfer Application ===");
      Console.WriteLine("Choose your language / Pilih bahasa:");
      Console.WriteLine("1. English");
      Console.WriteLine("2. Indonesian");
      Console.Write("Enter your choice (1 or 2): ");
      
      string langChoice = Console.ReadLine();
      
      // Update konfigurasi bahasa berdasarkan pilihan user
      if (langChoice == "1")
      {
          config.Lang = "en";
      }
      else if (langChoice == "2")
      {
          config.Lang = "id";
      }
      else
      {
          Console.WriteLine("Invalid choice. Using default language (English).");
          config.Lang = "en";
      }
      
      // Simpan perubahan konfigurasi
      config.SaveConfig();
      
      Console.WriteLine(); // Empty line for better readability
      
      // Step 1: Tampilkan pesan input berdasarkan bahasa yang dipilih
      string inputMessage = config.Lang == "en" 
          ? "Please insert the amount of money to transfer:" 
          : "Masukkan jumlah uang yang akan di-transfer:";
      
      Console.WriteLine(inputMessage);
      
      // Input jumlah transfer
      if (!long.TryParse(Console.ReadLine(), out long transferAmount) || transferAmount <= 0)
      {
          string errorMessage = config.Lang == "en" 
              ? "Invalid amount entered." 
              : "Jumlah yang dimasukkan tidak valid.";
          Console.WriteLine(errorMessage);
          return;
      }
      
      // Step 2: Hitung biaya transfer
      int transferFee = transferAmount <= config.Transfer.Threshold 
          ? config.Transfer.LowFee 
          : config.Transfer.HighFee;
      
      long totalAmount = transferAmount + transferFee;
      
      // Tampilkan biaya dan total
      if (config.Lang == "en")
      {
          Console.WriteLine($"Transfer fee = {transferFee:N0}");
          Console.WriteLine($"Total amount = {totalAmount:N0}");
      }
      else
      {
          Console.WriteLine($"Biaya transfer = {transferFee:N0}");
          Console.WriteLine($"Total biaya = {totalAmount:N0}");
      }
      
      // Step 3: Tampilkan pilihan metode transfer
      string methodMessage = config.Lang == "en" 
          ? "Select transfer method:" 
          : "Pilih metode transfer:";
      
      Console.WriteLine(methodMessage);
      
      // Tampilkan daftar metode dengan numbering
      for (int i = 0; i < config.Methods.Count; i++)
      {
          Console.WriteLine($"{i + 1}. {config.Methods[i]}");
      }
      
      // Input pilihan metode
      if (!int.TryParse(Console.ReadLine(), out int methodChoice) || 
          methodChoice < 1 || methodChoice > config.Methods.Count)
      {
          string errorMessage = config.Lang == "en" 
              ? "Invalid method selection." 
              : "Pilihan metode tidak valid.";
          Console.WriteLine(errorMessage);
          return;
      }
      
      string selectedMethod = config.Methods[methodChoice - 1];
      string selectedMessage = config.Lang == "en" 
          ? $"Selected method: {selectedMethod}" 
          : $"Metode yang dipilih: {selectedMethod}";
      Console.WriteLine(selectedMessage);
      
      // Step 4: Konfirmasi transaksi
      string confirmationKeyword = config.Lang == "en" ? config.Confirmation.En : config.Confirmation.Id;
      string confirmationMessage = config.Lang == "en" 
          ? $"Please type \"{confirmationKeyword}\" to confirm the transaction:" 
          : $"Ketik \"{confirmationKeyword}\" untuk mengkonfirmasi transaksi:";
      
      Console.WriteLine(confirmationMessage);
      string userConfirmation = Console.ReadLine()?.Trim();
      
      // Step 5: Hasil konfirmasi
      if (string.Equals(userConfirmation, confirmationKeyword, StringComparison.OrdinalIgnoreCase))
      {
          string successMessage = config.Lang == "en" 
              ? "The transfer is completed" 
              : "Proses transfer berhasil";
          Console.WriteLine(successMessage);
      }
      else
      {
          string cancelMessage = config.Lang == "en" 
              ? "Transfer is cancelled" 
              : "Transfer dibatalkan";
          Console.WriteLine(cancelMessage);
      }
      
      // Tampilkan informasi konfigurasi yang digunakan
      Console.WriteLine();
      string configInfo = config.Lang == "en" 
          ? "Configuration used:" 
          : "Konfigurasi yang digunakan:";
      Console.WriteLine($"=== {configInfo} ===");
      Console.WriteLine($"Language: {config.Lang}");
      Console.WriteLine($"Threshold: {config.Transfer.Threshold:N0}");
      Console.WriteLine($"Low Fee: {config.Transfer.LowFee:N0}");
      Console.WriteLine($"High Fee: {config.Transfer.HighFee:N0}");
  }
}
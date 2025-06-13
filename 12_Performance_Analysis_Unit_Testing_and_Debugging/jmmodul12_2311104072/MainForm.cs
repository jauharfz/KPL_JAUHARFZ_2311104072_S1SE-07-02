namespace jmmodul12_2311104072;

using System;
using System.Windows.Forms;


  public partial class MainForm : Form
  {
      public MainForm()
      {
          InitializeComponent();
      }

      /// <summary>
      /// Calculates power value with custom rules
      /// </summary>
      /// <param name="a">Base number</param>
      /// <param name="b">Exponent number</param>
      /// <returns>
      /// Power result or error codes:
      /// -1: Negative exponent
      /// -2: Input out of bounds (a > 100 or b > 10)
      /// -3: Result overflow
      /// </returns>
      public long CalculatePowerValue(int a, int b)
      {
          // Rule i: If b is 0, always return 1 (even if a is 0)
          if (b == 0)
              return 1;

          // Rule ii: If b is negative, return -1
          if (b < 0)
              return -1;

          // Rule iii: If b > 10 or a > 100, return -2
          if (b > 10 || a > 100)
              return -2;

          // Calculate power using iteration
          try
          {
              checked // Enable overflow checking
              {
                  long result = 1;
                  for (int i = 0; i < b; i++)
                  {
                      result *= a;
                  }
                  return result;
              }
          }
          catch (OverflowException)
          {
              // Rule iv: If result exceeds max positive integer, return -3
              return -3;
          }
      }

      private void buttonCalculate_Click(object sender, EventArgs e)
      {
          try
          {
              // Parse input values
              if (!int.TryParse(textBoxBase.Text, out int baseValue))
              {
                  labelResult.Text = "Result: Invalid base input!";
                  labelResult.ForeColor = Color.Red;
                  return;
              }

              if (!int.TryParse(textBoxExponent.Text, out int exponentValue))
              {
                  labelResult.Text = "Result: Invalid exponent input!";
                  labelResult.ForeColor = Color.Red;
                  return;
              }

              // Calculate power
              long result = CalculatePowerValue(baseValue, exponentValue);

              // Display result based on return value
              string resultText = result switch
              {
                  -1 => "Error: Negative exponent not allowed",
                  -2 => "Error: Input out of bounds (base > 100 or exponent > 10)",
                  -3 => "Error: Result overflow",
                  _ => $"{baseValue}^{exponentValue} = {result}"
              };

              labelResult.Text = $"Result: {resultText}";
              labelResult.ForeColor = result < 0 ? Color.Red : Color.Blue;
          }
          catch (Exception ex)
          {
              labelResult.Text = $"Result: Error - {ex.Message}";
              labelResult.ForeColor = Color.Red;
          }
      }
  }

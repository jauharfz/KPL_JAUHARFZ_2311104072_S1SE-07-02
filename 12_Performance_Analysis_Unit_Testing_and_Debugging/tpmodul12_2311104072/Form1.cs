using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("TestProject_TP")]
namespace tpmodul12_2311104072;

//tasklist -> fokus pengecekan number dulu 
//terus tinggal implement logic
public partial class Form1 : Form
{
    internal string userInput = default;

    public Form1()
    {
        InitializeComponent();
        textBox.TextAlign = HorizontalAlignment.Left;
    }

    private void TextBox_Type(object sender, EventArgs e)
    {
        TextBox textBox = (TextBox)sender;
        userInput = textBox.Text;
    }

    private void SubmitButton_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        if (int.TryParse(userInput, out int number))
        {
            resultLabel.Text = FindNumberSign(number);
        }
        else
        {
            resultLabel.Text = "Hanya boleh input angka saja";
        }
    }

    public string FindNumberSign(int a)
    {
        string temp;
        if (a == 0)
        {
            Console.WriteLine("Zero");
            return "Cannot Power 0";
        }
        else if (a < 0) Console.WriteLine("Negative");
        else if (a > 0) Console.WriteLine("Positive");

        return $"{Math.Pow(a, 2)}";
    }
}
namespace _03_GUI_Builder_dan_GitHub;

public partial class Form1 : Form
{
    private double angkaPertama = 0;
    private string currentInput = "";
    private double angkaKedua = 0;
    private  double hasil = 0;

    public Form1()
    {
        InitializeComponent();
        resultBox.ReadOnly = true;
        resultBox.TextAlign = HorizontalAlignment.Right;
    }

    private void AngkaButton_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        currentInput += button.Text;
        resultBox.Text += button.Text;
    }
    private void Add_Click(object sender, EventArgs e)
    {
        if (hasil != 0)
        {
            resultBox.Text += "+";
            currentInput = "";
        }
        if (!string.IsNullOrEmpty(currentInput))
        {
            angkaPertama = double.Parse(currentInput);
            currentInput = "";
            resultBox.Text += "+";
        }
    }

    private void Results_Click(object sender, EventArgs e)
    {
       
        if (!string.IsNullOrEmpty(currentInput) && angkaPertama != 0)
        {
            angkaKedua = double.Parse(currentInput);
            hasil = angkaPertama + angkaKedua;
            resultBox.Text = hasil.ToString();
            angkaPertama = hasil;
        }
        else
        {
            resultBox.Text = "";
            currentInput = "";
        }
        


        /*switch (operatorOperasi)
        {
            case"+":
                hasil = angkaPertama + angkaKedua;
                break;
            default:
                break;
        }*/
        /*resultBox.Text = hasil.ToString();*/
        /*angkaPertama = hasil;
        operatorOperasi = "";*/
    }
}
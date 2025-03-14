namespace _03_GUI_Builder_dan_GitHub;

public partial class Form1 : Form
{
    private double angkaPertama = 0;
    private string operatorOperasi = " ";
    private double angkaKedua = 0;
    public Form1()
    {
        InitializeComponent();
        resultBox.ReadOnly = true;
        resultBox.TextAlign = HorizontalAlignment.Right;
    }
    private void AngkaButton_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        resultBox.Text += button.Text;
    }

    private void Add_Click(object sender, EventArgs e)
    {
        angkaPertama = double.Parse(resultBox.Text);
        operatorOperasi = "+";
        angkaKedua = double.Parse(resultBox.Text);
        resultBox.Text = angkaPertama + operatorOperasi; //display for second number
    }

    private void Results_Click(object sender, EventArgs e)
    {
       
        double hasil = 0;

        switch (operatorOperasi)
        {
            case"+":
                hasil = angkaPertama + angkaKedua;
                break;
            default:
                break;
        }
        resultBox.Text = hasil.ToString();
        /*angkaPertama = hasil;
        operatorOperasi = "";*/
    }
}
namespace _03_GUI_Builder_dan_GitHub;

public partial class Form1 : Form
{
    private string currentInput = "";
    private double lastNumber;
    private double results;

    public Form1()
    {
        InitializeComponent();
        resultBox.ReadOnly = true;
        resultBox.TextAlign = HorizontalAlignment.Right;
    }

    private void AngkaButton_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        if (button.Text == "0" && string.IsNullOrEmpty(resultBox.Text))
        {
            return;
        }
        currentInput += button.Text;
        resultBox.Text += button.Text;
    }

    private void Add_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(currentInput))
        {
            results += double.Parse(currentInput);
            currentInput = "";
            resultBox.Text += "+";
        }
    }

    private void Results_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(currentInput) && results != 0 )
        {
            lastNumber = double.Parse(currentInput);
            results += lastNumber;
            resultBox.Text = results.ToString();
            currentInput = results.ToString();
            results = 0;
        }
        else
        {
            resultBox.Text = "";
            currentInput = "";
            results = 0;
        }
    }
}
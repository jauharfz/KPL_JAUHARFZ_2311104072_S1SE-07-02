namespace tpmodul3_2311104072;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    public void generateText(object sender, EventArgs e)
    {
        label1.Text = textBox1.Text;
    }

    
}
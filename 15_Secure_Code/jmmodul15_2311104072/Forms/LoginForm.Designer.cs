namespace jmmodul15_2311104072;

partial class LoginForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.Size = new Size(400, 300);
        this.Text = "Secure Login Application";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;

        // Title
        lblTitle = new Label()
        {
            Text = "SECURE LOGIN SYSTEM",
            Font = new Font("Arial", 14, FontStyle.Bold),
            Location = new Point(100, 20),
            Size = new Size(200, 25),
            TextAlign = ContentAlignment.MiddleCenter
        };

        // Username
        lblUsername = new Label()
        {
            Text = "Username:",
            Location = new Point(50, 80),
            Size = new Size(80, 20)
        };

        txtUsername = new TextBox()
        {
            Location = new Point(140, 78),
            Size = new Size(180, 25),
            MaxLength = 20
        };

        // Password
        lblPassword = new Label()
        {
            Text = "Password:",
            Location = new Point(50, 120),
            Size = new Size(80, 20)
        };

        txtPassword = new TextBox()
        {
            Location = new Point(140, 118),
            Size = new Size(180, 25),
            UseSystemPasswordChar = true,
            MaxLength = 20
        };

        // Status Label
        lblStatus = new Label()
        {
            Location = new Point(50, 160),
            Size = new Size(280, 40),
            ForeColor = Color.Red,
            Text = ""
        };

        // Buttons
        btnLogin = new Button()
        {
            Text = "Login",
            Location = new Point(140, 210),
            Size = new Size(80, 35),
            BackColor = Color.LightGreen,
            Font = new Font("Arial", 10, FontStyle.Bold)
        };
        btnLogin.Click += BtnLogin_Click;

        btnRegister = new Button()
        {
            Text = "Daftar",
            Location = new Point(240, 210),
            Size = new Size(80, 35),
            BackColor = Color.LightBlue,
            Font = new Font("Arial", 10, FontStyle.Bold)
        };
        btnRegister.Click += BtnRegister_Click;

        // Add controls to form
        this.Controls.AddRange(new Control[]
        {
            lblTitle, lblUsername, txtUsername, lblPassword, txtPassword,
            lblStatus, btnLogin, btnRegister
        });

        // Set Enter key untuk login
        this.AcceptButton = btnLogin;
    }

    #endregion
}
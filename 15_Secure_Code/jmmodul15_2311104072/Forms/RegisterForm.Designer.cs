namespace jmmodul15_2311104072;

partial class RegisterForm
{
   private void InitializeComponent()
    {
        this.Size = new Size(400, 350);
        this.Text = "Registrasi User";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;

        // Title
        lblTitle = new Label()
        {
            Text = "REGISTRASI USER",
            Font = new Font("Arial", 14, FontStyle.Bold),
            Location = new Point(120, 20),
            Size = new Size(160, 25),
            TextAlign = ContentAlignment.MiddleCenter
        };

        // Username
        lblUsername = new Label()
        {
            Text = "Username:",
            Location = new Point(30, 70),
            Size = new Size(80, 20)
        };

        txtUsername = new TextBox()
        {
            Location = new Point(120, 68),
            Size = new Size(200, 25),
            MaxLength = 20
        };
        txtUsername.TextChanged += TxtUsername_TextChanged;

        // Password
        lblPassword = new Label()
        {
            Text = "Password:",
            Location = new Point(30, 110),
            Size = new Size(80, 20)
        };

        txtPassword = new TextBox()
        {
            Location = new Point(120, 108),
            Size = new Size(200, 25),
            UseSystemPasswordChar = true,
            MaxLength = 20
        };
        txtPassword.TextChanged += TxtPassword_TextChanged;

        // Confirm Password
        lblConfirmPassword = new Label()
        {
            Text = "Konfirmasi:",
            Location = new Point(30, 150),
            Size = new Size(80, 20)
        };

        txtConfirmPassword = new TextBox()
        {
            Location = new Point(120, 148),
            Size = new Size(200, 25),
            UseSystemPasswordChar = true,
            MaxLength = 20
        };

        // Validation Label
        lblValidation = new Label()
        {
            Location = new Point(30, 190),
            Size = new Size(320, 60),
            ForeColor = Color.Red,
            Text = ""
        };

        // Buttons
        btnRegister = new Button()
        {
            Text = "Daftar",
            Location = new Point(120, 270),
            Size = new Size(80, 30),
            BackColor = Color.LightBlue
        };
        btnRegister.Click += BtnRegister_Click;

        btnCancel = new Button()
        {
            Text = "Batal",
            Location = new Point(220, 270),
            Size = new Size(80, 30),
            BackColor = Color.LightGray
        };
        btnCancel.Click += BtnCancel_Click;

        // Add controls to form
        this.Controls.AddRange(new Control[]
        {
            lblTitle, lblUsername, txtUsername, lblPassword, txtPassword,
            lblConfirmPassword, txtConfirmPassword, lblValidation,
            btnRegister, btnCancel
        });
    }
}
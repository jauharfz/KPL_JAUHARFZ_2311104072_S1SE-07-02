using jmmodul15_2311104072.Services;

namespace jmmodul15_2311104072;

using System;
using System.Drawing;
using System.Windows.Forms;

public partial class LoginForm : Form
{
    private TextBox txtUsername;
    private TextBox txtPassword;
    private Button btnLogin;
    private Button btnRegister;
    private Label lblTitle;
    private Label lblUsername;
    private Label lblPassword;
    private Label lblStatus;

    public LoginForm()
    {
        InitializeComponent();
    }

    

    private void BtnLogin_Click(object sender, EventArgs e)
    {
        try
        {
            lblStatus.Text = "";

            // Validasi input kosong
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                lblStatus.Text = "Username dan password harus diisi!";
                lblStatus.ForeColor = Color.Red;
                return;
            }

            // Validasi format username
            var usernameValidation = ValidationService.ValidateUsername(txtUsername.Text);
            if (!usernameValidation.IsValid)
            {
                lblStatus.Text = "Format username tidak valid!";
                lblStatus.ForeColor = Color.Red;
                return;
            }

            // Proses login
            bool loginSuccess = FileService.LoginUser(txtUsername.Text, txtPassword.Text);

            if (loginSuccess)
            {
                lblStatus.Text = "Login berhasil!";
                lblStatus.ForeColor = Color.Green;

                MessageBox.Show($"Selamat datang, {txtUsername.Text}!", "Login Berhasil",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset form
                txtUsername.Clear();
                txtPassword.Clear();
                lblStatus.Text = "";
            }
            else
            {
                lblStatus.Text = "Username atau password salah!";
                lblStatus.ForeColor = Color.Red;
                txtPassword.Clear();
            }
        }
        catch (Exception ex)
        {
            lblStatus.Text = $"Error: {ex.Message}";
            lblStatus.ForeColor = Color.Red;
        }
    }

    private void BtnRegister_Click(object sender, EventArgs e)
    {
        try
        {
            RegisterForm registerForm = new RegisterForm();
            DialogResult result = registerForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                lblStatus.Text = "Registrasi berhasil! Silakan login.";
                lblStatus.ForeColor = Color.Green;
            }
        }
        catch (Exception ex)
        {
            lblStatus.Text = $"Error membuka form registrasi: {ex.Message}";
            lblStatus.ForeColor = Color.Red;
        }
    }
}
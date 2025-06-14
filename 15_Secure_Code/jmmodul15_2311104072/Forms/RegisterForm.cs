using jmmodul15_2311104072.Services;

namespace jmmodul15_2311104072;

using System;
using System.Drawing;
using System.Windows.Forms;

public partial class RegisterForm : Form
{
    private TextBox txtUsername;
    private TextBox txtPassword;
    private TextBox txtConfirmPassword;
    private Button btnRegister;
    private Button btnCancel;
    private Label lblTitle;
    private Label lblUsername;
    private Label lblPassword;
    private Label lblConfirmPassword;
    private Label lblValidation;

    public RegisterForm()
    {
        InitializeComponent();
    }

    

    private void TxtUsername_TextChanged(object sender, EventArgs e)
    {
        ValidateInput();
    }

    private void TxtPassword_TextChanged(object sender, EventArgs e)
    {
        ValidateInput();
    }

    private void ValidateInput()
    {
        string validationMessage = "";

        // Validasi Username
        var usernameValidation = ValidationService.ValidateUsername(txtUsername.Text);
        if (!usernameValidation.IsValid)
        {
            validationMessage += usernameValidation.ErrorMessage + "\n";
        }

        // Validasi Password
        if (!string.IsNullOrEmpty(txtPassword.Text))
        {
            var passwordValidation = ValidationService.ValidatePassword(txtPassword.Text, txtUsername.Text);
            if (!passwordValidation.IsValid)
            {
                validationMessage += passwordValidation.ErrorMessage + "\n";
            }
        }

        lblValidation.Text = validationMessage;
        lblValidation.ForeColor = string.IsNullOrEmpty(validationMessage) ? Color.Green : Color.Red;
    }

    private void BtnRegister_Click(object sender, EventArgs e)
    {
        try
        {
            // Validasi input kosong
            if (string.IsNullOrEmpty(txtUsername.Text) ||
                string.IsNullOrEmpty(txtPassword.Text) ||
                string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                MessageBox.Show("Semua field harus diisi!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi username
            var usernameValidation = ValidationService.ValidateUsername(txtUsername.Text);
            if (!usernameValidation.IsValid)
            {
                MessageBox.Show(usernameValidation.ErrorMessage, "Error Validasi Username",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi password
            var passwordValidation = ValidationService.ValidatePassword(txtPassword.Text, txtUsername.Text);
            if (!passwordValidation.IsValid)
            {
                MessageBox.Show(passwordValidation.ErrorMessage, "Error Validasi Password",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi konfirmasi password
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password dan konfirmasi password tidak sama!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Proses registrasi
            bool success = FileService.RegisterUser(txtUsername.Text, txtPassword.Text);

            if (success)
            {
                MessageBox.Show("Registrasi berhasil!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Username sudah terdaftar!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Terjadi error: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void BtnCancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
}
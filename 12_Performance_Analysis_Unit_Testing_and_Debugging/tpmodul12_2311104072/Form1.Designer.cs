namespace tpmodul12_2311104072;

partial class Form1
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        textBox = new System.Windows.Forms.TextBox();
        submitButton = new System.Windows.Forms.Button();
        resultLabel = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // textBox
        // 
        textBox.Location = new System.Drawing.Point(226, 175);
        textBox.Name = "textBox";
        textBox.Size = new System.Drawing.Size(232, 27);
        textBox.TabIndex = 0;
        textBox.TextChanged += TextBox_Type;
        // 
        // submitButton
        // 
        submitButton.Location = new System.Drawing.Point(478, 176);
        submitButton.Name = "submitButton";
        submitButton.Size = new System.Drawing.Size(124, 26);
        submitButton.TabIndex = 1;
        submitButton.Text = "Submit";
        submitButton.UseVisualStyleBackColor = true;
        submitButton.Click += SubmitButton_Click;
        // 
        // resultLabel
        // 
        resultLabel.Location = new System.Drawing.Point(226, 213);
        resultLabel.Name = "resultLabel";
        resultLabel.Size = new System.Drawing.Size(231, 21);
        resultLabel.TabIndex = 2;
        resultLabel.Text = "= ";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(resultLabel);
        Controls.Add(submitButton);
        Controls.Add(textBox);
        Text = "\"ds\"";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox textBox;
    private System.Windows.Forms.Button submitButton;
    private System.Windows.Forms.Label resultLabel;

    #endregion
}
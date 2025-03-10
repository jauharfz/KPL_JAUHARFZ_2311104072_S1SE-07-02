namespace tpmodul3_2311104072;

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
        button1 = new System.Windows.Forms.Button();
        textBox1 = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(451, 131);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(144, 49);
        button1.TabIndex = 0;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        button1.Click += generateText;
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(190, 131);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(233, 49);
        textBox1.TabIndex = 1;
        textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(190, 201);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(404, 48);
        label1.TabIndex = 2;
        label1.Text = "label1";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(label1);
        Controls.Add(textBox1);
        Controls.Add(button1);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.Button button1;

    #endregion
}
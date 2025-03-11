namespace _03_GUI_Builder_dan_GitHub;

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
        Zero = new System.Windows.Forms.Button();
        Four = new System.Windows.Forms.Button();
        Five = new System.Windows.Forms.Button();
        Six = new System.Windows.Forms.Button();
        Add = new System.Windows.Forms.Button();
        Results = new System.Windows.Forms.Button();
        One = new System.Windows.Forms.Button();
        Two = new System.Windows.Forms.Button();
        Three = new System.Windows.Forms.Button();
        resultBox = new System.Windows.Forms.TextBox();
        Nine = new System.Windows.Forms.Button();
        Eight = new System.Windows.Forms.Button();
        Seven = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // Zero
        // 
        Zero.Font = new System.Drawing.Font("D-DIN Condensed", 19.799997F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Zero.Location = new System.Drawing.Point(357, 338);
        Zero.Name = "Zero";
        Zero.Size = new System.Drawing.Size(87, 76);
        Zero.TabIndex = 4;
        Zero.Text = "0";
        Zero.UseVisualStyleBackColor = true;
        Zero.Click += AngkaButton_Click;
        // 
        // Four
        // 
        Four.Font = new System.Drawing.Font("D-DIN", 19.799997F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Four.Location = new System.Drawing.Point(264, 174);
        Four.Name = "Four";
        Four.Size = new System.Drawing.Size(87, 76);
        Four.TabIndex = 0;
        Four.Text = "4";
        Four.UseVisualStyleBackColor = true;
        Four.Click += AngkaButton_Click;
        // 
        // Five
        // 
        Five.Font = new System.Drawing.Font("D-DIN", 19.799997F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Five.Location = new System.Drawing.Point(357, 174);
        Five.Name = "Five";
        Five.Size = new System.Drawing.Size(87, 76);
        Five.TabIndex = 1;
        Five.Text = "5";
        Five.UseVisualStyleBackColor = true;
        Five.Click += AngkaButton_Click;
        // 
        // Six
        // 
        Six.Font = new System.Drawing.Font("D-DIN", 19.799997F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Six.Location = new System.Drawing.Point(450, 174);
        Six.Name = "Six";
        Six.Size = new System.Drawing.Size(87, 76);
        Six.TabIndex = 2;
        Six.Text = "6";
        Six.UseVisualStyleBackColor = true;
        Six.Click += AngkaButton_Click;
        // 
        // Add
        // 
        Add.Font = new System.Drawing.Font("D-DIN", 19.799997F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Add.Location = new System.Drawing.Point(264, 338);
        Add.Name = "Add";
        Add.Size = new System.Drawing.Size(87, 76);
        Add.TabIndex = 3;
        Add.Text = "+";
        Add.UseVisualStyleBackColor = true;
        Add.Click += Add_Click;
        // 
        // Results
        // 
        Results.Font = new System.Drawing.Font("D-DIN", 19.799997F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Results.Location = new System.Drawing.Point(450, 338);
        Results.Name = "Results";
        Results.Size = new System.Drawing.Size(87, 76);
        Results.TabIndex = 5;
        Results.Text = "=";
        Results.UseVisualStyleBackColor = true;
        Results.Click += Results_Click;
        // 
        // One
        // 
        One.Font = new System.Drawing.Font("D-DIN", 19.799997F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        One.Location = new System.Drawing.Point(264, 92);
        One.Name = "One";
        One.Size = new System.Drawing.Size(87, 76);
        One.TabIndex = 6;
        One.Text = "1";
        One.UseVisualStyleBackColor = true;
        One.Click += AngkaButton_Click;
        // 
        // Two
        // 
        Two.Font = new System.Drawing.Font("D-DIN", 19.799997F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Two.Location = new System.Drawing.Point(357, 92);
        Two.Name = "Two";
        Two.Size = new System.Drawing.Size(87, 76);
        Two.TabIndex = 7;
        Two.Text = "2";
        Two.UseVisualStyleBackColor = true;
        Two.Click += AngkaButton_Click;
        // 
        // Three
        // 
        Three.Font = new System.Drawing.Font("D-DIN", 19.799997F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Three.Location = new System.Drawing.Point(450, 92);
        Three.Name = "Three";
        Three.Size = new System.Drawing.Size(87, 76);
        Three.TabIndex = 8;
        Three.Text = "3";
        Three.UseVisualStyleBackColor = true;
        Three.Click += AngkaButton_Click;
        // 
        // resultBox
        // 
        resultBox.Font = new System.Drawing.Font("D-DIN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        resultBox.Location = new System.Drawing.Point(264, 33);
        resultBox.Multiline = true;
        resultBox.Name = "resultBox";
        resultBox.Size = new System.Drawing.Size(273, 53);
        resultBox.TabIndex = 10;
        // 
        // Nine
        // 
        Nine.Font = new System.Drawing.Font("D-DIN", 19.799997F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Nine.Location = new System.Drawing.Point(450, 256);
        Nine.Name = "Nine";
        Nine.Size = new System.Drawing.Size(87, 76);
        Nine.TabIndex = 13;
        Nine.Text = "9";
        Nine.UseVisualStyleBackColor = true;
        Nine.Click += AngkaButton_Click;
        // 
        // Eight
        // 
        Eight.Font = new System.Drawing.Font("D-DIN", 19.799997F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Eight.Location = new System.Drawing.Point(357, 256);
        Eight.Name = "Eight";
        Eight.Size = new System.Drawing.Size(87, 76);
        Eight.TabIndex = 12;
        Eight.Text = "8";
        Eight.UseVisualStyleBackColor = true;
        Eight.Click += AngkaButton_Click;
        // 
        // Seven
        // 
        Seven.Font = new System.Drawing.Font("D-DIN", 19.799997F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Seven.Location = new System.Drawing.Point(264, 256);
        Seven.Name = "Seven";
        Seven.Size = new System.Drawing.Size(87, 76);
        Seven.TabIndex = 11;
        Seven.Text = "7";
        Seven.UseVisualStyleBackColor = true;
        Seven.Click += AngkaButton_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(Nine);
        Controls.Add(Eight);
        Controls.Add(Seven);
        Controls.Add(resultBox);
        Controls.Add(Three);
        Controls.Add(Two);
        Controls.Add(One);
        Controls.Add(Results);
        Controls.Add(Add);
        Controls.Add(Six);
        Controls.Add(Five);
        Controls.Add(Four);
        Controls.Add(Zero);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button Nine;
    private System.Windows.Forms.Button Eight;
    private System.Windows.Forms.Button Seven;

    private System.Windows.Forms.Button Four;
    private System.Windows.Forms.Button Five;
    private System.Windows.Forms.Button Six;
    private System.Windows.Forms.Button Add;
    private System.Windows.Forms.Button Zero;
    private System.Windows.Forms.Button Results;
    private System.Windows.Forms.Button One;
    private System.Windows.Forms.Button Two;
    private System.Windows.Forms.Button Three;
    private System.Windows.Forms.TextBox resultBox;

    #endregion
}
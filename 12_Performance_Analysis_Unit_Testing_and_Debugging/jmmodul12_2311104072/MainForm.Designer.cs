namespace jmmodul12_2311104072;


  partial class MainForm
  {
      private System.ComponentModel.IContainer components = null;
      private TextBox textBoxBase;
      private TextBox textBoxExponent;
      private Button buttonCalculate;
      private Label labelResult;
      private Label labelBase;
      private Label labelExponent;
      private Label labelTitle;

      protected override void Dispose(bool disposing)
      {
          if (disposing && (components != null))
          {
              components.Dispose();
          }
          base.Dispose(disposing);
      }

      private void InitializeComponent()
      {
          this.textBoxBase = new TextBox();
          this.textBoxExponent = new TextBox();
          this.buttonCalculate = new Button();
          this.labelResult = new Label();
          this.labelBase = new Label();
          this.labelExponent = new Label();
          this.labelTitle = new Label();
          this.SuspendLayout();
          
          // labelTitle
          this.labelTitle.AutoSize = true;
          this.labelTitle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
          this.labelTitle.Location = new Point(80, 20);
          this.labelTitle.Name = "labelTitle";
          this.labelTitle.Size = new Size(240, 26);
          this.labelTitle.TabIndex = 0;
          this.labelTitle.Text = "Power Calculator";
          
          // labelBase
          this.labelBase.AutoSize = true;
          this.labelBase.Font = new Font("Microsoft Sans Serif", 10F);
          this.labelBase.Location = new Point(50, 80);
          this.labelBase.Name = "labelBase";
          this.labelBase.Size = new Size(90, 17);
          this.labelBase.TabIndex = 1;
          this.labelBase.Text = "Base (a):";
          
          // textBoxBase
          this.textBoxBase.Font = new Font("Microsoft Sans Serif", 10F);
          this.textBoxBase.Location = new Point(150, 77);
          this.textBoxBase.Name = "textBoxBase";
          this.textBoxBase.Size = new Size(150, 23);
          this.textBoxBase.TabIndex = 2;
          
          // labelExponent
          this.labelExponent.AutoSize = true;
          this.labelExponent.Font = new Font("Microsoft Sans Serif", 10F);
          this.labelExponent.Location = new Point(50, 120);
          this.labelExponent.Name = "labelExponent";
          this.labelExponent.Size = new Size(90, 17);
          this.labelExponent.TabIndex = 3;
          this.labelExponent.Text = "Exponent (b):";
          
          // textBoxExponent
          this.textBoxExponent.Font = new Font("Microsoft Sans Serif", 10F);
          this.textBoxExponent.Location = new Point(150, 117);
          this.textBoxExponent.Name = "textBoxExponent";
          this.textBoxExponent.Size = new Size(150, 23);
          this.textBoxExponent.TabIndex = 4;
          
          // buttonCalculate
          this.buttonCalculate.Font = new Font("Microsoft Sans Serif", 10F);
          this.buttonCalculate.Location = new Point(150, 160);
          this.buttonCalculate.Name = "buttonCalculate";
          this.buttonCalculate.Size = new Size(100, 30);
          this.buttonCalculate.TabIndex = 5;
          this.buttonCalculate.Text = "Calculate";
          this.buttonCalculate.UseVisualStyleBackColor = true;
          this.buttonCalculate.Click += new EventHandler(this.buttonCalculate_Click);
          
          // labelResult
          this.labelResult.AutoSize = true;
          this.labelResult.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
          this.labelResult.ForeColor = Color.Blue;
          this.labelResult.Location = new Point(50, 220);
          this.labelResult.Name = "labelResult";
          this.labelResult.Size = new Size(65, 20);
          this.labelResult.TabIndex = 6;
          this.labelResult.Text = "Result: ";
          
          // MainForm
          this.AutoScaleDimensions = new SizeF(7F, 15F);
          this.AutoScaleMode = AutoScaleMode.Font;
          this.ClientSize = new Size(400, 300);
          this.Controls.Add(this.labelResult);
          this.Controls.Add(this.buttonCalculate);
          this.Controls.Add(this.textBoxExponent);
          this.Controls.Add(this.labelExponent);
          this.Controls.Add(this.textBoxBase);
          this.Controls.Add(this.labelBase);
          this.Controls.Add(this.labelTitle);
          this.FormBorderStyle = FormBorderStyle.FixedSingle;
          this.MaximizeBox = false;
          this.Name = "MainForm";
          this.StartPosition = FormStartPosition.CenterScreen;
          this.Text = "Power Calculator - Modul 12";
          this.ResumeLayout(false);
          this.PerformLayout();
      }
  }

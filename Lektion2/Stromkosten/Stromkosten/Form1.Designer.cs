namespace Stromkosten
{
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CalculateButton = new Button();
            Ausgabewert = new TextBox();
            EingabeFeld = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)EingabeFeld).BeginInit();
            SuspendLayout();
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(563, 281);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(247, 54);
            CalculateButton.TabIndex = 0;
            CalculateButton.Text = "Berechnen";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // Ausgabewert
            // 
            Ausgabewert.Location = new Point(310, 398);
            Ausgabewert.Name = "Ausgabewert";
            Ausgabewert.Size = new Size(500, 39);
            Ausgabewert.TabIndex = 1;
            Ausgabewert.TextAlign = HorizontalAlignment.Right;
            Ausgabewert.TextChanged += Ausgabe_TextChanged;
            // 
            // EingabeFeld
            // 
            EingabeFeld.Location = new Point(700, 215);
            EingabeFeld.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            EingabeFeld.Name = "EingabeFeld";
            EingabeFeld.Size = new Size(110, 39);
            EingabeFeld.TabIndex = 2;
            EingabeFeld.ValueChanged += EingabeFeld_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 584);
            Controls.Add(EingabeFeld);
            Controls.Add(Ausgabewert);
            Controls.Add(CalculateButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)EingabeFeld).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CalculateButton;
        private TextBox Ausgabewert;
        private NumericUpDown EingabeFeld;
    }
}

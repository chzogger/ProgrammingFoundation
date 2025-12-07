namespace WinFormsApp1
{
    partial class Stromverbrauch
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
            EingabeWert = new NumericUpDown();
            WertBox = new TextBox();
            ButtonCalculate = new Button();
            ((System.ComponentModel.ISupportInitialize)EingabeWert).BeginInit();
            SuspendLayout();
            // 
            // EingabeWert
            // 
            EingabeWert.Location = new Point(543, 119);
            EingabeWert.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            EingabeWert.Name = "EingabeWert";
            EingabeWert.Size = new Size(193, 39);
            EingabeWert.TabIndex = 0;
            EingabeWert.ValueChanged += wert_ValueChanged;
            // 
            // WertBox
            // 
            WertBox.Location = new Point(490, 482);
            WertBox.Name = "WertBox";
            WertBox.Size = new Size(293, 39);
            WertBox.TabIndex = 1;
            WertBox.TextChanged += numericUpDown1_ValueChanged;
            // 
            // ButtonCalculate
            // 
            ButtonCalculate.Location = new Point(534, 244);
            ButtonCalculate.Name = "ButtonCalculate";
            ButtonCalculate.Size = new Size(193, 61);
            ButtonCalculate.TabIndex = 2;
            ButtonCalculate.Text = "Berechnen";
            ButtonCalculate.UseVisualStyleBackColor = true;
            ButtonCalculate.Click += ButtonCalculate_Click;
            // 
            // Stromverbrauch
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 559);
            Controls.Add(ButtonCalculate);
            Controls.Add(WertBox);
            Controls.Add(EingabeWert);
            Name = "Stromverbrauch";
            Text = "Verbrauch berechnen";
            ((System.ComponentModel.ISupportInitialize)EingabeWert).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown EingabeWert;
        private TextBox WertBox;
        private Button ButtonCalculate;
    }
}

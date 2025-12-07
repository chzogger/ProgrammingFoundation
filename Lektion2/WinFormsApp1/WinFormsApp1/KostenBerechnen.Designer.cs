namespace WinFormsApp1
{
    partial class KostenBerechnen
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
            Ausgabewert = new TextBox();
            BerechnenButton = new Button();
            Eingabewert = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Eingabewert).BeginInit();
            SuspendLayout();
            // 
            // Ausgabewert
            // 
            Ausgabewert.Location = new Point(144, 340);
            Ausgabewert.MaxLength = 50;
            Ausgabewert.Name = "Ausgabewert";
            Ausgabewert.Size = new Size(389, 39);
            Ausgabewert.TabIndex = 0;
            Ausgabewert.TextChanged += Ausgabewert_TextChanged;
            // 
            // BerechnenButton
            // 
            BerechnenButton.Location = new Point(288, 229);
            BerechnenButton.Name = "BerechnenButton";
            BerechnenButton.Size = new Size(245, 49);
            BerechnenButton.TabIndex = 1;
            BerechnenButton.Text = "Berechnen";
            BerechnenButton.UseVisualStyleBackColor = true;
            BerechnenButton.Click += BerechnenButton_Click;
            // 
            // Eingabewert
            // 
            Eingabewert.Location = new Point(419, 136);
            Eingabewert.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            Eingabewert.Name = "Eingabewert";
            Eingabewert.Size = new Size(114, 39);
            Eingabewert.TabIndex = 2;
            Eingabewert.ValueChanged += Eingabewert_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 138);
            label1.Name = "label1";
            label1.Size = new Size(203, 32);
            label1.TabIndex = 3;
            label1.Text = "Verbrauch in kWh";
            // 
            // KostenBerechnen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 450);
            Controls.Add(label1);
            Controls.Add(Eingabewert);
            Controls.Add(BerechnenButton);
            Controls.Add(Ausgabewert);
            Name = "KostenBerechnen";
            Text = "Berechne deine Kosten";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Eingabewert).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Ausgabewert;
        private Button BerechnenButton;
        private NumericUpDown Eingabewert;
        private Label label1;
    }
}

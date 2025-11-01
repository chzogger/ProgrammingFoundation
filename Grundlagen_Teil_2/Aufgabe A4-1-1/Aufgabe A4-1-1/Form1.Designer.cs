namespace Aufgabe_A4_1_1
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
            label1 = new Label();
            label2 = new Label();
            HokusBokusButton = new Button();
            LabelErgebnis = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 80);
            label1.Name = "label1";
            label1.Size = new Size(87, 32);
            label1.TabIndex = 0;
            label1.Text = "Zahl A:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 150);
            label2.Name = "label2";
            label2.Size = new Size(86, 32);
            label2.TabIndex = 1;
            label2.Text = "Zahl B:";
            // 
            // HokusBokusButton
            // 
            HokusBokusButton.Location = new Point(208, 223);
            HokusBokusButton.Name = "HokusBokusButton";
            HokusBokusButton.Size = new Size(200, 48);
            HokusBokusButton.TabIndex = 4;
            HokusBokusButton.Text = "Hokus Bokus";
            HokusBokusButton.UseVisualStyleBackColor = true;
            HokusBokusButton.Click += HokusBokus_Click;
            // 
            // LabelErgebnis
            // 
            LabelErgebnis.AutoSize = true;
            LabelErgebnis.Location = new Point(208, 323);
            LabelErgebnis.Name = "LabelErgebnis";
            LabelErgebnis.Size = new Size(0, 32);
            LabelErgebnis.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Cursor = Cursors.PanSW;
            numericUpDown1.Location = new Point(208, 73);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(177, 39);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Cursor = Cursors.PanSW;
            numericUpDown2.Location = new Point(208, 143);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(177, 39);
            numericUpDown2.TabIndex = 7;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 562);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(LabelErgebnis);
            Controls.Add(HokusBokusButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button HokusBokusButton;
        private Label LabelErgebnis;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
    }
}

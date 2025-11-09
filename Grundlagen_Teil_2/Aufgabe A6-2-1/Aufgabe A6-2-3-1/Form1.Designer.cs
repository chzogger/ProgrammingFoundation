namespace Aufgabe_A6_2_3_1
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
            BtnGgT = new Button();
            label1 = new Label();
            label2 = new Label();
            Num1 = new NumericUpDown();
            Num2 = new NumericUpDown();
            BxggT = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Num1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Num2).BeginInit();
            SuspendLayout();
            // 
            // BtnGgT
            // 
            BtnGgT.Location = new Point(78, 269);
            BtnGgT.Name = "BtnGgT";
            BtnGgT.Size = new Size(218, 80);
            BtnGgT.TabIndex = 0;
            BtnGgT.Text = "Bestimme GgT";
            BtnGgT.UseVisualStyleBackColor = true;
            BtnGgT.Click += BtnGgT_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 65);
            label1.Name = "label1";
            label1.Size = new Size(85, 32);
            label1.TabIndex = 1;
            label1.Text = "1. Zahl";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 125);
            label2.Name = "label2";
            label2.Size = new Size(85, 32);
            label2.TabIndex = 2;
            label2.Text = "2. Zahl";
            // 
            // Num1
            // 
            Num1.Location = new Point(279, 65);
            Num1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            Num1.Name = "Num1";
            Num1.Size = new Size(225, 39);
            Num1.TabIndex = 3;
            Num1.ValueChanged += Num1_ValueChanged;
            // 
            // Num2
            // 
            Num2.Location = new Point(279, 136);
            Num2.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            Num2.Name = "Num2";
            Num2.Size = new Size(225, 39);
            Num2.TabIndex = 4;
            Num2.ValueChanged += Num2_ValueChanged;
            // 
            // BxggT
            // 
            BxggT.Location = new Point(370, 290);
            BxggT.Name = "BxggT";
            BxggT.Size = new Size(170, 39);
            BxggT.TabIndex = 5;
            BxggT.TextChanged += BxggT_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 427);
            Controls.Add(BxggT);
            Controls.Add(Num2);
            Controls.Add(Num1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnGgT);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Num1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Num2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnGgT;
        private Label label1;
        private Label label2;
        private NumericUpDown Num1;
        private NumericUpDown Num2;
        private TextBox BxggT;
    }
}

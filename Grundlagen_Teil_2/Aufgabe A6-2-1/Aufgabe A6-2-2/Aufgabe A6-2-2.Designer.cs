namespace Aufgabe_A6_2_2
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
            DezNum = new NumericUpDown();
            CalcBtn = new Button();
            Result = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)DezNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 65);
            label1.Name = "label1";
            label1.Size = new Size(228, 32);
            label1.TabIndex = 0;
            label1.Text = "Ganze Dezimalzahl: ";
            // 
            // DezNum
            // 
            DezNum.Location = new Point(414, 58);
            DezNum.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            DezNum.Name = "DezNum";
            DezNum.Size = new Size(192, 39);
            DezNum.TabIndex = 1;
            DezNum.TextAlign = HorizontalAlignment.Center;
            // 
            // CalcBtn
            // 
            CalcBtn.Location = new Point(107, 164);
            CalcBtn.Name = "CalcBtn";
            CalcBtn.Size = new Size(291, 71);
            CalcBtn.TabIndex = 2;
            CalcBtn.Text = "Binärwert berechnen";
            CalcBtn.UseVisualStyleBackColor = true;
            CalcBtn.Click += CalcBtn_Click;
            // 
            // Result
            // 
            Result.Location = new Point(327, 511);
            Result.Name = "Result";
            Result.Size = new Size(479, 39);
            Result.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 514);
            label2.Name = "label2";
            label2.Size = new Size(171, 32);
            label2.TabIndex = 4;
            label2.Text = "Ihre Binärzahl: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 678);
            Controls.Add(label2);
            Controls.Add(Result);
            Controls.Add(CalcBtn);
            Controls.Add(DezNum);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DezNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown DezNum;
        private Button CalcBtn;
        private TextBox Result;
        private Label label2;
    }
}

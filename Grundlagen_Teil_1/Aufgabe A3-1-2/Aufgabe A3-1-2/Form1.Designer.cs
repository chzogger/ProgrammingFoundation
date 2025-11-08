namespace Aufgabe_A3_1_2
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
            MyMonth = new NumericUpDown();
            label1 = new Label();
            MonthLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)MyMonth).BeginInit();
            SuspendLayout();
            // 
            // MyMonth
            // 
            MyMonth.Location = new Point(501, 104);
            MyMonth.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            MyMonth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            MyMonth.Name = "MyMonth";
            MyMonth.Size = new Size(154, 39);
            MyMonth.TabIndex = 0;
            MyMonth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            MyMonth.ValueChanged += MyMonth_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 111);
            label1.Name = "label1";
            label1.Size = new Size(244, 32);
            label1.TabIndex = 1;
            label1.Text = "Wählen Sie eine Zahl:";
            label1.Click += Form1_Load;
            // 
            // MonthLabel
            // 
            MonthLabel.AutoSize = true;
            MonthLabel.Location = new Point(215, 292);
            MonthLabel.Name = "MonthLabel";
            MonthLabel.Size = new Size(0, 32);
            MonthLabel.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 580);
            Controls.Add(MonthLabel);
            Controls.Add(label1);
            Controls.Add(MyMonth);
            Name = "Form1";
            Text = "Form1";
            TopMost = true;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)MyMonth).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown MyMonth;
        private Label label1;
        private Label MonthLabel;
    }
}

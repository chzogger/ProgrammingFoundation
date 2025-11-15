namespace Aufgabe_A9_2_4
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
            BtnBiggestNr = new Button();
            BtnSmallestNr = new Button();
            BtnAverage = new Button();
            LblBiggestNr = new Label();
            LblSmallest = new Label();
            LblAverage = new Label();
            BxNumbers = new TextBox();
            SuspendLayout();
            // 
            // BtnBiggestNr
            // 
            BtnBiggestNr.Location = new Point(67, 159);
            BtnBiggestNr.Name = "BtnBiggestNr";
            BtnBiggestNr.Size = new Size(218, 56);
            BtnBiggestNr.TabIndex = 0;
            BtnBiggestNr.Text = "Grösste Zahl: ";
            BtnBiggestNr.UseVisualStyleBackColor = true;
            BtnBiggestNr.Click += BtnBiggestNr_Click;
            // 
            // BtnSmallestNr
            // 
            BtnSmallestNr.Location = new Point(67, 237);
            BtnSmallestNr.Name = "BtnSmallestNr";
            BtnSmallestNr.Size = new Size(218, 56);
            BtnSmallestNr.TabIndex = 1;
            BtnSmallestNr.Text = "Kleinste Zahl: ";
            BtnSmallestNr.UseVisualStyleBackColor = true;
            BtnSmallestNr.Click += BtnSmallestNr_Click;
            // 
            // BtnAverage
            // 
            BtnAverage.Location = new Point(67, 315);
            BtnAverage.Name = "BtnAverage";
            BtnAverage.Size = new Size(218, 56);
            BtnAverage.TabIndex = 2;
            BtnAverage.Text = "Durchschnitt: ";
            BtnAverage.UseVisualStyleBackColor = true;
            BtnAverage.Click += BtnAverage_Click;
            // 
            // LblBiggestNr
            // 
            LblBiggestNr.AutoSize = true;
            LblBiggestNr.Location = new Point(305, 171);
            LblBiggestNr.Name = "LblBiggestNr";
            LblBiggestNr.Size = new Size(0, 32);
            LblBiggestNr.TabIndex = 3;
            // 
            // LblSmallest
            // 
            LblSmallest.AutoSize = true;
            LblSmallest.Location = new Point(305, 249);
            LblSmallest.Name = "LblSmallest";
            LblSmallest.Size = new Size(0, 32);
            LblSmallest.TabIndex = 4;
            // 
            // LblAverage
            // 
            LblAverage.AutoSize = true;
            LblAverage.Location = new Point(305, 327);
            LblAverage.Name = "LblAverage";
            LblAverage.Size = new Size(0, 32);
            LblAverage.TabIndex = 5;
            // 
            // BxNumbers
            // 
            BxNumbers.Location = new Point(67, 64);
            BxNumbers.Name = "BxNumbers";
            BxNumbers.Size = new Size(656, 39);
            BxNumbers.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 451);
            Controls.Add(BxNumbers);
            Controls.Add(LblAverage);
            Controls.Add(LblSmallest);
            Controls.Add(LblBiggestNr);
            Controls.Add(BtnAverage);
            Controls.Add(BtnSmallestNr);
            Controls.Add(BtnBiggestNr);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnBiggestNr;
        private Button BtnSmallestNr;
        private Button BtnAverage;
        private Label LblBiggestNr;
        private Label LblSmallest;
        private Label LblAverage;
        private TextBox BxNumbers;
    }
}

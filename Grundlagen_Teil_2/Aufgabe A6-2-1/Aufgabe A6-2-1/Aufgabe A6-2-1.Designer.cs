namespace Aufgabe_A6_2_1
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
            BtnGenerate = new Button();
            label1 = new Label();
            MyNumber = new TextBox();
            BtnStart = new Button();
            NumbersOutput = new TextBox();
            SuspendLayout();
            // 
            // BtnGenerate
            // 
            BtnGenerate.Location = new Point(329, 34);
            BtnGenerate.Name = "BtnGenerate";
            BtnGenerate.Size = new Size(261, 48);
            BtnGenerate.TabIndex = 0;
            BtnGenerate.Text = "Generiere Zufallszahl";
            BtnGenerate.UseVisualStyleBackColor = true;
            BtnGenerate.Click += BtnGenerate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 42);
            label1.Name = "label1";
            label1.Size = new Size(72, 32);
            label1.TabIndex = 1;
            label1.Text = "Zahl: ";
            // 
            // MyNumber
            // 
            MyNumber.Location = new Point(120, 39);
            MyNumber.Name = "MyNumber";
            MyNumber.Size = new Size(152, 39);
            MyNumber.TabIndex = 2;
            MyNumber.TextChanged += MyNumber_TextChanged;
            // 
            // BtnStart
            // 
            BtnStart.Location = new Point(628, 34);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(150, 48);
            BtnStart.TabIndex = 3;
            BtnStart.Text = "Start";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click;
            // 
            // NumbersOutput
            // 
            NumbersOutput.Location = new Point(103, 142);
            NumbersOutput.Multiline = true;
            NumbersOutput.Name = "NumbersOutput";
            NumbersOutput.ScrollBars = ScrollBars.Vertical;
            NumbersOutput.Size = new Size(593, 519);
            NumbersOutput.TabIndex = 4;
            NumbersOutput.TextChanged += NumbersOutput_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 728);
            Controls.Add(NumbersOutput);
            Controls.Add(BtnStart);
            Controls.Add(MyNumber);
            Controls.Add(label1);
            Controls.Add(BtnGenerate);
            Name = "Form1";
            Text = "Aufgabe A6-2-1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnGenerate;
        private Label label1;
        private TextBox MyNumber;
        private Button BtnStart;
        private TextBox NumbersOutput;
    }
}

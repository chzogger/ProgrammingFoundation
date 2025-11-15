namespace Aufgabe_A9_2_1
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
            button1 = new Button();
            BxNumbers = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(55, 32);
            button1.Name = "button1";
            button1.Size = new Size(169, 50);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnStart_Click;
            // 
            // BxNumbers
            // 
            BxNumbers.Location = new Point(55, 116);
            BxNumbers.Margin = new Padding(0);
            BxNumbers.Multiline = true;
            BxNumbers.Name = "BxNumbers";
            BxNumbers.Size = new Size(203, 766);
            BxNumbers.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 956);
            Controls.Add(BxNumbers);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox BxNumbers;
    }
}

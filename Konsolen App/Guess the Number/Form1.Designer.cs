namespace Guess_the_Number
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
            LblOutpt = new Label();
            BxNumber = new TextBox();
            BtnSubmit = new Button();
            BtnGenerate = new Button();
            SuspendLayout();
            // 
            // LblOutpt
            // 
            LblOutpt.AutoSize = true;
            LblOutpt.Location = new Point(141, 224);
            LblOutpt.Name = "LblOutpt";
            LblOutpt.Size = new Size(0, 32);
            LblOutpt.TabIndex = 0;
            // 
            // BxNumber
            // 
            BxNumber.Location = new Point(365, 124);
            BxNumber.Name = "BxNumber";
            BxNumber.Size = new Size(67, 39);
            BxNumber.TabIndex = 1;
            BxNumber.TextChanged += BxNumber_TextChanged;
            // 
            // BtnSubmit
            // 
            BtnSubmit.Location = new Point(470, 111);
            BtnSubmit.Name = "BtnSubmit";
            BtnSubmit.Size = new Size(243, 64);
            BtnSubmit.TabIndex = 3;
            BtnSubmit.Text = "Viel Glück!";
            BtnSubmit.UseVisualStyleBackColor = true;
            BtnSubmit.Click += BtnSubmit_Click;
            // 
            // BtnGenerate
            // 
            BtnGenerate.Location = new Point(83, 106);
            BtnGenerate.Name = "BtnGenerate";
            BtnGenerate.Size = new Size(259, 75);
            BtnGenerate.TabIndex = 4;
            BtnGenerate.Text = "generiere Zufallszahl";
            BtnGenerate.UseVisualStyleBackColor = true;
            BtnGenerate.Click += BtnGenerate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 385);
            Controls.Add(BtnGenerate);
            Controls.Add(BtnSubmit);
            Controls.Add(BxNumber);
            Controls.Add(LblOutpt);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblOutpt;
        private TextBox BxNumber;
        private Button BtnSubmit;
        private Button BtnGenerate;
    }
}

namespace Aufgabe_A13_1
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
            label3 = new Label();
            label4 = new Label();
            BxFirstname = new TextBox();
            BxLastname = new TextBox();
            BxAge = new TextBox();
            BxCounter = new TextBox();
            BtnCreate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 90);
            label1.Name = "label1";
            label1.Size = new Size(109, 32);
            label1.TabIndex = 0;
            label1.Text = "Vorname";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 295);
            label2.Name = "label2";
            label2.Size = new Size(76, 32);
            label2.TabIndex = 1;
            label2.Text = "Alter: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 189);
            label3.Name = "label3";
            label3.Size = new Size(129, 32);
            label3.TabIndex = 2;
            label3.Text = "Nachname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 399);
            label4.Name = "label4";
            label4.Size = new Size(291, 32);
            label4.TabIndex = 3;
            label4.Text = "Anzahl erzeugter Objekte:";
            // 
            // BxFirstname
            // 
            BxFirstname.Location = new Point(298, 96);
            BxFirstname.Name = "BxFirstname";
            BxFirstname.Size = new Size(191, 39);
            BxFirstname.TabIndex = 4;
            // 
            // BxLastname
            // 
            BxLastname.Location = new Point(298, 189);
            BxLastname.Name = "BxLastname";
            BxLastname.Size = new Size(191, 39);
            BxLastname.TabIndex = 5;
            // 
            // BxAge
            // 
            BxAge.Location = new Point(298, 295);
            BxAge.Name = "BxAge";
            BxAge.Size = new Size(191, 39);
            BxAge.TabIndex = 6;
            // 
            // BxCounter
            // 
            BxCounter.Location = new Point(406, 396);
            BxCounter.Name = "BxCounter";
            BxCounter.Size = new Size(83, 39);
            BxCounter.TabIndex = 7;
            // 
            // BtnCreate
            // 
            BtnCreate.Location = new Point(621, 154);
            BtnCreate.Name = "BtnCreate";
            BtnCreate.Size = new Size(246, 198);
            BtnCreate.TabIndex = 8;
            BtnCreate.Text = "Erzeuge neues Personen- Objekt";
            BtnCreate.UseVisualStyleBackColor = true;
            BtnCreate.Click += BtnCreate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 546);
            Controls.Add(BtnCreate);
            Controls.Add(BxCounter);
            Controls.Add(BxAge);
            Controls.Add(BxLastname);
            Controls.Add(BxFirstname);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox BxFirstname;
        private TextBox BxLastname;
        private TextBox BxAge;
        private TextBox BxCounter;
        private Button BtnCreate;
    }
}

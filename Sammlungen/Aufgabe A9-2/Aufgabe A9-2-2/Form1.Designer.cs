namespace Aufgabe_A9_2_2
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
            LblSize = new Label();
            BxSize = new TextBox();
            label1 = new Label();
            BxIndex = new TextBox();
            LblValue = new Label();
            BxValue = new TextBox();
            button1 = new Button();
            label2 = new Label();
            BxOutput = new TextBox();
            SuspendLayout();
            // 
            // BtnGenerate
            // 
            BtnGenerate.Location = new Point(548, 33);
            BtnGenerate.Name = "BtnGenerate";
            BtnGenerate.Size = new Size(226, 71);
            BtnGenerate.TabIndex = 0;
            BtnGenerate.Text = "Daten generieren";
            BtnGenerate.UseVisualStyleBackColor = true;
            BtnGenerate.Click += BtnGenerate_Click;
            // 
            // LblSize
            // 
            LblSize.AutoSize = true;
            LblSize.Location = new Point(12, 56);
            LblSize.Name = "LblSize";
            LblSize.Size = new Size(227, 32);
            LblSize.TabIndex = 1;
            LblSize.Text = "Gewünschte Grösse:";
            // 
            // BxSize
            // 
            BxSize.Location = new Point(241, 56);
            BxSize.Name = "BxSize";
            BxSize.Size = new Size(126, 39);
            BxSize.TabIndex = 2;
            BxSize.TextChanged += BxSize_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 189);
            label1.Name = "label1";
            label1.Size = new Size(164, 32);
            label1.TabIndex = 3;
            label1.Text = "Index Wählen:";
            // 
            // BxIndex
            // 
            BxIndex.Location = new Point(241, 186);
            BxIndex.Name = "BxIndex";
            BxIndex.Size = new Size(126, 39);
            BxIndex.TabIndex = 4;
            // 
            // LblValue
            // 
            LblValue.AutoSize = true;
            LblValue.Location = new Point(385, 189);
            LblValue.Name = "LblValue";
            LblValue.Size = new Size(230, 32);
            LblValue.TabIndex = 5;
            LblValue.Text = "Gespeicherter Wert: ";
            // 
            // BxValue
            // 
            BxValue.Location = new Point(648, 186);
            BxValue.Name = "BxValue";
            BxValue.Size = new Size(126, 39);
            BxValue.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(45, 266);
            button1.Name = "button1";
            button1.Size = new Size(746, 51);
            button1.TabIndex = 7;
            button1.Text = "Wert am gewünschten Index auslesen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += IndexAusgeben_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 342);
            label2.Name = "label2";
            label2.Size = new Size(214, 32);
            label2.TabIndex = 8;
            label2.Text = "Erfolgte Abfragen: ";
            // 
            // BxOutput
            // 
            BxOutput.Location = new Point(260, 363);
            BxOutput.Multiline = true;
            BxOutput.Name = "BxOutput";
            BxOutput.Size = new Size(533, 211);
            BxOutput.TabIndex = 9;
            BxOutput.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 617);
            Controls.Add(BxOutput);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(BxValue);
            Controls.Add(LblValue);
            Controls.Add(BxIndex);
            Controls.Add(label1);
            Controls.Add(BxSize);
            Controls.Add(LblSize);
            Controls.Add(BtnGenerate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnGenerate;
        private Label LblSize;
        private TextBox BxSize;
        private Label label1;
        private TextBox BxIndex;
        private Label LblValue;
        private TextBox BxValue;
        private Button button1;
        private Label label2;
        private TextBox BxOutput;
    }
}

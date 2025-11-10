namespace ArrayUebung1
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
            MyNumberAppend = new NumericUpDown();
            BtnHinzufügen = new Button();
            BtnAusgeben = new Button();
            Ausgabeliste = new TextBox();
            DeleteNumber = new NumericUpDown();
            BtnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)MyNumberAppend).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DeleteNumber).BeginInit();
            SuspendLayout();
            // 
            // MyNumberAppend
            // 
            MyNumberAppend.Location = new Point(69, 63);
            MyNumberAppend.Name = "MyNumberAppend";
            MyNumberAppend.Size = new Size(274, 39);
            MyNumberAppend.TabIndex = 0;
            MyNumberAppend.ValueChanged += MyNumberAppend_ValueChanged;
            // 
            // BtnHinzufügen
            // 
            BtnHinzufügen.Location = new Point(69, 131);
            BtnHinzufügen.Name = "BtnHinzufügen";
            BtnHinzufügen.Size = new Size(281, 51);
            BtnHinzufügen.TabIndex = 1;
            BtnHinzufügen.Text = "Hinzufügen";
            BtnHinzufügen.UseVisualStyleBackColor = true;
            BtnHinzufügen.Click += BtnHinzufuegen_Click;
            // 
            // BtnAusgeben
            // 
            BtnAusgeben.Location = new Point(69, 206);
            BtnAusgeben.Name = "BtnAusgeben";
            BtnAusgeben.Size = new Size(281, 51);
            BtnAusgeben.TabIndex = 2;
            BtnAusgeben.Text = "Ausgeben";
            BtnAusgeben.UseVisualStyleBackColor = true;
            BtnAusgeben.Click += BtnAusgeben_Click;
            // 
            // Ausgabeliste
            // 
            Ausgabeliste.Location = new Point(65, 302);
            Ausgabeliste.Multiline = true;
            Ausgabeliste.Name = "Ausgabeliste";
            Ausgabeliste.Size = new Size(304, 463);
            Ausgabeliste.TabIndex = 3;
            Ausgabeliste.TextChanged += Ausgabeliste_TextChanged;
            // 
            // DeleteNumber
            // 
            DeleteNumber.Location = new Point(69, 812);
            DeleteNumber.Name = "DeleteNumber";
            DeleteNumber.Size = new Size(274, 39);
            DeleteNumber.TabIndex = 4;
            DeleteNumber.ValueChanged += DeleteNumber_ValueChanged;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(69, 903);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(281, 51);
            BtnDelete.TabIndex = 5;
            BtnDelete.Text = "Entfernen";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 1063);
            Controls.Add(BtnDelete);
            Controls.Add(DeleteNumber);
            Controls.Add(Ausgabeliste);
            Controls.Add(BtnAusgeben);
            Controls.Add(BtnHinzufügen);
            Controls.Add(MyNumberAppend);
            Name = "Form1";
            Text = "ArrayUebung";
            ((System.ComponentModel.ISupportInitialize)MyNumberAppend).EndInit();
            ((System.ComponentModel.ISupportInitialize)DeleteNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown MyNumberAppend;
        private Button BtnHinzufügen;
        private Button BtnAusgeben;
        private TextBox Ausgabeliste;
        private NumericUpDown DeleteNumber;
        private Button BtnDelete;
    }
}

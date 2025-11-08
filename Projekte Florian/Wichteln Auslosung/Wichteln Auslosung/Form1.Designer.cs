namespace Wichteln_Auslosung
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
            BtFlo = new Button();
            BtLia = new Button();
            BtAndi = new Button();
            BtMam = new Button();
            BtGrosi = new Button();
            BtMarco = new Button();
            BtDelia = new Button();
            BtSarah = new Button();
            label1 = new Label();
            TxtPerson = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // BtFlo
            // 
            BtFlo.Location = new Point(96, 99);
            BtFlo.Name = "BtFlo";
            BtFlo.Size = new Size(204, 70);
            BtFlo.TabIndex = 0;
            BtFlo.Text = "Florian";
            BtFlo.UseVisualStyleBackColor = true;
            BtFlo.Click += BtFlo_Click;
            // 
            // BtLia
            // 
            BtLia.Location = new Point(96, 211);
            BtLia.Name = "BtLia";
            BtLia.Size = new Size(204, 73);
            BtLia.TabIndex = 1;
            BtLia.Text = "Lia";
            BtLia.UseVisualStyleBackColor = true;
            BtLia.Click += BtLia_Click;
            // 
            // BtAndi
            // 
            BtAndi.Location = new Point(96, 330);
            BtAndi.Name = "BtAndi";
            BtAndi.Size = new Size(204, 76);
            BtAndi.TabIndex = 2;
            BtAndi.Text = "Andreas";
            BtAndi.UseVisualStyleBackColor = true;
            BtAndi.Click += BtAndi_Click;
            // 
            // BtMam
            // 
            BtMam.Location = new Point(96, 458);
            BtMam.Name = "BtMam";
            BtMam.Size = new Size(204, 74);
            BtMam.TabIndex = 3;
            BtMam.Text = "Valerie";
            BtMam.UseVisualStyleBackColor = true;
            BtMam.Click += BtMam_Click;
            // 
            // BtGrosi
            // 
            BtGrosi.Location = new Point(410, 99);
            BtGrosi.Name = "BtGrosi";
            BtGrosi.Size = new Size(216, 70);
            BtGrosi.TabIndex = 4;
            BtGrosi.Text = "Grosi";
            BtGrosi.UseVisualStyleBackColor = true;
            BtGrosi.Click += BtGrosi_Click;
            // 
            // BtMarco
            // 
            BtMarco.Location = new Point(410, 211);
            BtMarco.Name = "BtMarco";
            BtMarco.Size = new Size(216, 73);
            BtMarco.TabIndex = 5;
            BtMarco.Text = "Marco";
            BtMarco.UseVisualStyleBackColor = true;
            BtMarco.Click += BtMarco_Click;
            // 
            // BtDelia
            // 
            BtDelia.Location = new Point(410, 330);
            BtDelia.Name = "BtDelia";
            BtDelia.Size = new Size(216, 78);
            BtDelia.TabIndex = 6;
            BtDelia.Text = "Delia";
            BtDelia.UseVisualStyleBackColor = true;
            BtDelia.Click += BtDelia_Click;
            // 
            // BtSarah
            // 
            BtSarah.Location = new Point(410, 458);
            BtSarah.Name = "BtSarah";
            BtSarah.Size = new Size(216, 74);
            BtSarah.TabIndex = 7;
            BtSarah.Text = "Sarah";
            BtSarah.UseVisualStyleBackColor = true;
            BtSarah.Click += BtSarah_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 620);
            label1.Name = "label1";
            label1.Size = new Size(157, 32);
            label1.TabIndex = 8;
            label1.Text = "Du wichtelst: ";
            // 
            // TxtPerson
            // 
            TxtPerson.Location = new Point(397, 617);
            TxtPerson.Name = "TxtPerson";
            TxtPerson.Size = new Size(229, 39);
            TxtPerson.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(180, 732);
            button1.Name = "button1";
            button1.Size = new Size(243, 68);
            button1.TabIndex = 10;
            button1.Text = "Auslosen";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 842);
            Controls.Add(button1);
            Controls.Add(TxtPerson);
            Controls.Add(label1);
            Controls.Add(BtSarah);
            Controls.Add(BtDelia);
            Controls.Add(BtMarco);
            Controls.Add(BtGrosi);
            Controls.Add(BtMam);
            Controls.Add(BtAndi);
            Controls.Add(BtLia);
            Controls.Add(BtFlo);
            Name = "Form1";
            Text = "Wichteln Auslosung";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtFlo;
        private Button BtLia;
        private Button BtAndi;
        private Button BtMam;
        private Button BtGrosi;
        private Button BtMarco;
        private Button BtDelia;
        private Button BtSarah;
        private Label label1;
        private TextBox TxtPerson;
        private Button button1;
    }
}

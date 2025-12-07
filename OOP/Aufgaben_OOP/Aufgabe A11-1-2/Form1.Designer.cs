namespace Aufgabe_A11_1_2
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
            Tab2Page = new TabControl();
            Tab1 = new TabPage();
            LbLProducts = new Label();
            BtnSave = new Button();
            TxtEKP = new TextBox();
            TxtVKP = new TextBox();
            TxtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Tab2 = new TabPage();
            TxBoxManage = new TextBox();
            Tab2Page.SuspendLayout();
            Tab1.SuspendLayout();
            Tab2.SuspendLayout();
            SuspendLayout();
            // 
            // Tab2Page
            // 
            Tab2Page.Controls.Add(Tab1);
            Tab2Page.Controls.Add(Tab2);
            Tab2Page.Location = new Point(37, 102);
            Tab2Page.Name = "Tab2Page";
            Tab2Page.SelectedIndex = 0;
            Tab2Page.Size = new Size(867, 605);
            Tab2Page.TabIndex = 0;
            Tab2Page.Selected += Tab2_Selected;
            // 
            // Tab1
            // 
            Tab1.Controls.Add(LbLProducts);
            Tab1.Controls.Add(BtnSave);
            Tab1.Controls.Add(TxtEKP);
            Tab1.Controls.Add(TxtVKP);
            Tab1.Controls.Add(TxtName);
            Tab1.Controls.Add(label3);
            Tab1.Controls.Add(label2);
            Tab1.Controls.Add(label1);
            Tab1.Location = new Point(8, 46);
            Tab1.Name = "Tab1";
            Tab1.Padding = new Padding(3);
            Tab1.Size = new Size(851, 551);
            Tab1.TabIndex = 0;
            Tab1.Text = "Produkte erstellen";
            Tab1.UseVisualStyleBackColor = true;
           
            // 
            // LbLProducts
            // 
            LbLProducts.AutoSize = true;
            LbLProducts.Location = new Point(63, 379);
            LbLProducts.Name = "LbLProducts";
            LbLProducts.Size = new Size(268, 32);
            LbLProducts.TabIndex = 13;
            LbLProducts.Text = "Gespeicherte Produkte: ";
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(282, 254);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(231, 42);
            BtnSave.TabIndex = 12;
            BtnSave.Text = "Speichern";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // TxtEKP
            // 
            TxtEKP.Location = new Point(282, 130);
            TxtEKP.Name = "TxtEKP";
            TxtEKP.Size = new Size(231, 39);
            TxtEKP.TabIndex = 11;
            // 
            // TxtVKP
            // 
            TxtVKP.Location = new Point(282, 186);
            TxtVKP.Name = "TxtVKP";
            TxtVKP.Size = new Size(231, 39);
            TxtVKP.TabIndex = 10;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(282, 69);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(231, 39);
            TxtName.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 189);
            label3.Name = "label3";
            label3.Size = new Size(167, 32);
            label3.TabIndex = 8;
            label3.Text = "Verkaufspreis: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 133);
            label2.Name = "label2";
            label2.Size = new Size(165, 32);
            label2.TabIndex = 7;
            label2.Text = "Einkaufspreis: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 76);
            label1.Name = "label1";
            label1.Size = new Size(169, 32);
            label1.TabIndex = 6;
            label1.Text = "Produktname: ";
            // 
            // Tab2
            // 
            Tab2.Controls.Add(TxBoxManage);
            Tab2.Location = new Point(8, 46);
            Tab2.Name = "Tab2";
            Tab2.Padding = new Padding(3);
            Tab2.Size = new Size(851, 551);
            Tab2.TabIndex = 1;
            Tab2.Text = "Produkte verwalten";
            Tab2.UseVisualStyleBackColor = true;
            Tab2.Click += Tab2_Click;
            // 
            // TxBoxManage
            // 
            TxBoxManage.Location = new Point(17, 27);
            TxBoxManage.Multiline = true;
            TxBoxManage.Name = "TxBoxManage";
            TxBoxManage.Size = new Size(799, 491);
            TxBoxManage.TabIndex = 0;
            TxBoxManage.TextChanged += TxBoxManage_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 791);
            Controls.Add(Tab2Page);
            Name = "Form1";
            Text = "Form1";
            Tab2Page.ResumeLayout(false);
            Tab1.ResumeLayout(false);
            Tab1.PerformLayout();
            Tab2.ResumeLayout(false);
            Tab2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Tab2Page;
        private TabPage Tab1;
        private TabPage Tab2;
        private Label LbLProducts;
        private Button BtnSave;
        private TextBox TxtEKP;
        private TextBox TxtVKP;
        private TextBox TxtName;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TxBoxManage;
    }
}

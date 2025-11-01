namespace Aufgabe_A4_2_1
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
            AusführenButton = new Button();
            Number1 = new NumericUpDown();
            Number2 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            AusgabeFeld = new Label();
            ((System.ComponentModel.ISupportInitialize)Number1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Number2).BeginInit();
            SuspendLayout();
            // 
            // AusführenButton
            // 
            AusführenButton.Location = new Point(262, 375);
            AusführenButton.Name = "AusführenButton";
            AusführenButton.Size = new Size(340, 75);
            AusführenButton.TabIndex = 0;
            AusführenButton.Text = "Bestimme die grössere Zahl";
            AusführenButton.UseVisualStyleBackColor = true;
            AusführenButton.Click += AusführenButton_Click;
            // 
            // Number1
            // 
            Number1.Location = new Point(241, 112);
            Number1.Name = "Number1";
            Number1.Size = new Size(443, 39);
            Number1.TabIndex = 1;
            Number1.ValueChanged += Number1_ValueChanged;
            // 
            // Number2
            // 
            Number2.Location = new Point(241, 220);
            Number2.Name = "Number2";
            Number2.Size = new Size(443, 39);
            Number2.TabIndex = 2;
            Number2.ValueChanged += Number2_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 114);
            label1.Name = "label1";
            label1.Size = new Size(85, 32);
            label1.TabIndex = 3;
            label1.Text = "Zahl 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 227);
            label2.Name = "label2";
            label2.Size = new Size(85, 32);
            label2.TabIndex = 4;
            label2.Text = "Zahl 2:";
            // 
            // AusgabeFeld
            // 
            AusgabeFeld.AutoSize = true;
            AusgabeFeld.Location = new Point(238, 50);
            AusgabeFeld.Name = "AusgabeFeld";
            AusgabeFeld.Size = new Size(0, 32);
            AusgabeFeld.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 642);
            Controls.Add(AusgabeFeld);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Number2);
            Controls.Add(Number1);
            Controls.Add(AusführenButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Number1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Number2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AusführenButton;
        private NumericUpDown Number1;
        private NumericUpDown Number2;
        private Label label1;
        private Label label2;
        private Label AusgabeFeld;
    }
}

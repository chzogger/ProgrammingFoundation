namespace Aufgabe_A4_2_4
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
            Number1 = new TextBox();
            Number2 = new TextBox();
            OperandBox = new TextBox();
            ResultBox = new TextBox();
            CalcButton = new Button();
            DeleteButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 69);
            label1.Name = "label1";
            label1.Size = new Size(92, 32);
            label1.TabIndex = 0;
            label1.Text = "Zahl 1: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 134);
            label2.Name = "label2";
            label2.Size = new Size(92, 32);
            label2.TabIndex = 1;
            label2.Text = "Zahl 2: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 193);
            label3.Name = "label3";
            label3.Size = new Size(119, 32);
            label3.TabIndex = 2;
            label3.Text = "Operand: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 252);
            label4.Name = "label4";
            label4.Size = new Size(110, 32);
            label4.TabIndex = 3;
            label4.Text = "Resultat: ";
            // 
            // Number1
            // 
            Number1.Location = new Point(184, 69);
            Number1.Name = "Number1";
            Number1.Size = new Size(142, 39);
            Number1.TabIndex = 4;
            Number1.TextChanged += Number1_TextChanged;
            // 
            // Number2
            // 
            Number2.Location = new Point(184, 131);
            Number2.Name = "Number2";
            Number2.Size = new Size(142, 39);
            Number2.TabIndex = 5;
            Number2.TextChanged += Number2_TextChanged;
            // 
            // OperandBox
            // 
            OperandBox.Location = new Point(184, 193);
            OperandBox.Name = "OperandBox";
            OperandBox.Size = new Size(73, 39);
            OperandBox.TabIndex = 6;
            OperandBox.TextChanged += OperandBox_TextChanged;
            // 
            // ResultBox
            // 
            ResultBox.Location = new Point(184, 252);
            ResultBox.Name = "ResultBox";
            ResultBox.Size = new Size(142, 39);
            ResultBox.TabIndex = 7;
            ResultBox.TextChanged += ResultBox_TextChanged;
            // 
            // CalcButton
            // 
            CalcButton.Location = new Point(184, 312);
            CalcButton.Name = "CalcButton";
            CalcButton.Size = new Size(223, 49);
            CalcButton.TabIndex = 8;
            CalcButton.Text = "Rechne!";
            CalcButton.UseVisualStyleBackColor = true;
            CalcButton.Click += CalcButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(184, 386);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(231, 40);
            DeleteButton.TabIndex = 9;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 450);
            Controls.Add(DeleteButton);
            Controls.Add(CalcButton);
            Controls.Add(ResultBox);
            Controls.Add(OperandBox);
            Controls.Add(Number2);
            Controls.Add(Number1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Mein Rechner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Number1;
        private TextBox Number2;
        private TextBox OperandBox;
        private TextBox ResultBox;
        private Button CalcButton;
        private Button DeleteButton;
    }
}

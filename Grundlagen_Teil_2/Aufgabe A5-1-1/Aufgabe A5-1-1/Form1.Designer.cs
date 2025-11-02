namespace Aufgabe_A5_1_1
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
            components = new System.ComponentModel.Container();
            RedBar = new TrackBar();
            GreenBar = new TrackBar();
            BlueBar = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ColorPanel = new Panel();
            label10 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            Timer = new System.Windows.Forms.Timer(components);
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)RedBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GreenBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BlueBar).BeginInit();
            SuspendLayout();
            // 
            // RedBar
            // 
            RedBar.Location = new Point(114, 72);
            RedBar.Maximum = 255;
            RedBar.Name = "RedBar";
            RedBar.Size = new Size(435, 90);
            RedBar.TabIndex = 0;
            RedBar.Scroll += RedBar_Scroll;
            // 
            // GreenBar
            // 
            GreenBar.Location = new Point(114, 159);
            GreenBar.Maximum = 255;
            GreenBar.Name = "GreenBar";
            GreenBar.Size = new Size(435, 90);
            GreenBar.TabIndex = 1;
            GreenBar.Scroll += GreenBar_Scroll;
            // 
            // BlueBar
            // 
            BlueBar.Location = new Point(114, 255);
            BlueBar.Maximum = 255;
            BlueBar.Name = "BlueBar";
            BlueBar.Size = new Size(435, 90);
            BlueBar.TabIndex = 2;
            BlueBar.Scroll += BlueBar_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(288, 115);
            label1.Name = "label1";
            label1.Size = new Size(53, 32);
            label1.TabIndex = 3;
            label1.Text = "128";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 205);
            label2.Name = "label2";
            label2.Size = new Size(53, 32);
            label2.TabIndex = 4;
            label2.Text = "128";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(288, 302);
            label3.Name = "label3";
            label3.Size = new Size(53, 32);
            label3.TabIndex = 5;
            label3.Text = "128";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(496, 302);
            label4.Name = "label4";
            label4.Size = new Size(53, 32);
            label4.TabIndex = 6;
            label4.Text = "255";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(496, 205);
            label5.Name = "label5";
            label5.Size = new Size(53, 32);
            label5.TabIndex = 7;
            label5.Text = "255";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(496, 115);
            label6.Name = "label6";
            label6.Size = new Size(53, 32);
            label6.TabIndex = 8;
            label6.Text = "255";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 264);
            label7.Name = "label7";
            label7.Size = new Size(72, 32);
            label7.TabIndex = 9;
            label7.Text = "Blau: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 174);
            label8.Name = "label8";
            label8.Size = new Size(78, 32);
            label8.TabIndex = 10;
            label8.Text = "Grün: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(58, 97);
            label9.Name = "label9";
            label9.Size = new Size(61, 32);
            label9.TabIndex = 11;
            label9.Text = "Rot: ";
            // 
            // ColorPanel
            // 
            ColorPanel.BackColor = Color.Black;
            ColorPanel.Location = new Point(114, 371);
            ColorPanel.Name = "ColorPanel";
            ColorPanel.Size = new Size(471, 123);
            ColorPanel.TabIndex = 12;
            ColorPanel.Paint += ColorPanel_Paint;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(138, 541);
            label10.Name = "label10";
            label10.Size = new Size(123, 32);
            label10.TabIndex = 13;
            label10.Text = "HexaCode";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(611, 97);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(28, 27);
            checkBox1.TabIndex = 15;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(611, 179);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(28, 27);
            checkBox2.TabIndex = 16;
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(611, 264);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(28, 27);
            checkBox3.TabIndex = 17;
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // Timer
            // 
            Timer.Interval = 1;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 683);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label10);
            Controls.Add(ColorPanel);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BlueBar);
            Controls.Add(GreenBar);
            Controls.Add(RedBar);
            Name = "Form1";
            Text = "neue Aufgabe";
            ((System.ComponentModel.ISupportInitialize)RedBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)GreenBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BlueBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar RedBar;
        private TrackBar GreenBar;
        private TrackBar BlueBar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel ColorPanel;
        private Label label10;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Timer timer1;
    }
}

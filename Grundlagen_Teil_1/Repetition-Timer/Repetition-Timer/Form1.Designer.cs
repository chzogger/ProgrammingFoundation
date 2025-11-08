namespace Repetition_Timer
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
            StartStopButton = new Button();
            MyTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            EvenNumbers = new CheckBox();
            Stoppuhr = new Label();
            SuspendLayout();
            // 
            // StartStopButton
            // 
            StartStopButton.Location = new Point(99, 317);
            StartStopButton.Name = "StartStopButton";
            StartStopButton.Size = new Size(173, 68);
            StartStopButton.TabIndex = 0;
            StartStopButton.Text = "Start";
            StartStopButton.UseVisualStyleBackColor = true;
            StartStopButton.Click += StartStopButton_Click;
            // 
            // MyTimer
            // 
            MyTimer.Interval = 1000;
            MyTimer.Tick += MyTimer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 42);
            label1.Name = "label1";
            label1.Size = new Size(196, 32);
            label1.TabIndex = 1;
            label1.Text = "Zeit in Sekunden";
            // 
            // EvenNumbers
            // 
            EvenNumbers.AutoSize = true;
            EvenNumbers.Location = new Point(479, 123);
            EvenNumbers.Name = "EvenNumbers";
            EvenNumbers.Size = new Size(247, 36);
            EvenNumbers.TabIndex = 2;
            EvenNumbers.Text = "Nur gerade Zahlen";
            EvenNumbers.UseVisualStyleBackColor = true;
            EvenNumbers.CheckedChanged += EvenNumbers_CheckedChanged;
            // 
            // Stoppuhr
            // 
            Stoppuhr.AutoSize = true;
            Stoppuhr.Location = new Point(126, 153);
            Stoppuhr.Name = "Stoppuhr";
            Stoppuhr.Size = new Size(27, 32);
            Stoppuhr.TabIndex = 3;
            Stoppuhr.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 531);
            Controls.Add(Stoppuhr);
            Controls.Add(EvenNumbers);
            Controls.Add(label1);
            Controls.Add(StartStopButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartStopButton;
        private System.Windows.Forms.Timer MyTimer;       
        private Label label1;
        private CheckBox EvenNumbers;
        private Label Stoppuhr;
    }
}

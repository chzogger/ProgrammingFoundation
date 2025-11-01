namespace Aufgabe_A4_2_2
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
            button1 = new Button();
            UpperLight = new Button();
            MiddleLight = new Button();
            BottomLight = new Button();
            Switch = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Location = new Point(188, 122);
            button1.Name = "button1";
            button1.Size = new Size(235, 407);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            // 
            // UpperLight
            // 
            UpperLight.BackColor = Color.DimGray;
            UpperLight.Location = new Point(263, 174);
            UpperLight.Margin = new Padding(0);
            UpperLight.Name = "UpperLight";
            UpperLight.Size = new Size(88, 84);
            UpperLight.TabIndex = 1;
            UpperLight.UseVisualStyleBackColor = false;
            UpperLight.Click += UpperLight_Click;
            // 
            // MiddleLight
            // 
            MiddleLight.BackColor = Color.DimGray;
            MiddleLight.Location = new Point(263, 283);
            MiddleLight.Name = "MiddleLight";
            MiddleLight.Size = new Size(88, 84);
            MiddleLight.TabIndex = 2;
            MiddleLight.UseVisualStyleBackColor = false;
            MiddleLight.Click += MiddleLight_Click;
            // 
            // BottomLight
            // 
            BottomLight.BackColor = Color.DimGray;
            BottomLight.Location = new Point(263, 386);
            BottomLight.Name = "BottomLight";
            BottomLight.Size = new Size(88, 84);
            BottomLight.TabIndex = 3;
            BottomLight.UseVisualStyleBackColor = false;
            BottomLight.Click += BottomLight_Click;
            // 
            // Switch
            // 
            Switch.Location = new Point(227, 603);
            Switch.Name = "Switch";
            Switch.Size = new Size(187, 52);
            Switch.TabIndex = 4;
            Switch.Text = "Schalten";
            Switch.UseVisualStyleBackColor = true;
            Switch.Click += switch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 728);
            Controls.Add(Switch);
            Controls.Add(BottomLight);
            Controls.Add(MiddleLight);
            Controls.Add(UpperLight);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Ampfel";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button UpperLight;
        private Button MiddleLight;
        private Button BottomLight;
        private Button Switch;
    }
}

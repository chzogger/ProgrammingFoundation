namespace Aufgaben_OOP
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
            Person1 = new Button();
            Person2 = new Button();
            Person3 = new Button();
            TxtBox = new TextBox();
            SuspendLayout();
            // 
            // Person1
            // 
            Person1.Location = new Point(99, 45);
            Person1.Name = "Person1";
            Person1.Size = new Size(684, 71);
            Person1.TabIndex = 0;
            Person1.Text = "Erzeuge Person 1";
            Person1.UseVisualStyleBackColor = true;
            Person1.Click += Person1_Click;
            // 
            // Person2
            // 
            Person2.Location = new Point(99, 139);
            Person2.Name = "Person2";
            Person2.Size = new Size(684, 71);
            Person2.TabIndex = 1;
            Person2.Text = "Erzeuge Person 2";
            Person2.UseVisualStyleBackColor = true;
            Person2.Click += Person2_Click;
            // 
            // Person3
            // 
            Person3.Location = new Point(99, 235);
            Person3.Name = "Person3";
            Person3.Size = new Size(684, 71);
            Person3.TabIndex = 2;
            Person3.Text = "Erzeuge Person 3";
            Person3.UseVisualStyleBackColor = true;
            Person3.Click += Person3_Click;
            // 
            // TxtBox
            // 
            TxtBox.Location = new Point(48, 339);
            TxtBox.Multiline = true;
            TxtBox.Name = "TxtBox";
            TxtBox.Size = new Size(800, 336);
            TxtBox.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 745);
            Controls.Add(TxtBox);
            Controls.Add(Person3);
            Controls.Add(Person2);
            Controls.Add(Person1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Person1;
        private Button Person2;
        private Button Person3;
        private TextBox TxtBox;
    }
}

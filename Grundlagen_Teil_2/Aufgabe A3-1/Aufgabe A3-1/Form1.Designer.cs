namespace Aufgabe_A3_1
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
            button_monday = new Button();
            button_tuesday = new Button();
            button_wednesday = new Button();
            button_thursday = new Button();
            button_friday = new Button();
            button_saturday = new Button();
            button_sunday = new Button();
            labelDay = new Label();
            SuspendLayout();
            // 
            // button_monday
            // 
            button_monday.Location = new Point(76, 69);
            button_monday.Name = "button_monday";
            button_monday.Size = new Size(154, 68);
            button_monday.TabIndex = 0;
            button_monday.Text = "Montag";
            button_monday.UseVisualStyleBackColor = true;
            button_monday.Click += button_monday_Click;
            // 
            // button_tuesday
            // 
            button_tuesday.Location = new Point(275, 69);
            button_tuesday.Name = "button_tuesday";
            button_tuesday.Size = new Size(154, 68);
            button_tuesday.TabIndex = 1;
            button_tuesday.Text = "Dienstag";
            button_tuesday.UseVisualStyleBackColor = true;
            button_tuesday.Click += button_tuesday_Click;
            // 
            // button_wednesday
            // 
            button_wednesday.Location = new Point(484, 69);
            button_wednesday.Name = "button_wednesday";
            button_wednesday.Size = new Size(154, 68);
            button_wednesday.TabIndex = 2;
            button_wednesday.Text = "Mittwoch";
            button_wednesday.UseVisualStyleBackColor = true;
            button_wednesday.Click += button_wednesday_Click;
            // 
            // button_thursday
            // 
            button_thursday.Location = new Point(701, 69);
            button_thursday.Name = "button_thursday";
            button_thursday.Size = new Size(154, 68);
            button_thursday.TabIndex = 3;
            button_thursday.Text = "Donnerstag";
            button_thursday.UseVisualStyleBackColor = true;
            button_thursday.Click += button_thursday_Click;
            // 
            // button_friday
            // 
            button_friday.Location = new Point(176, 165);
            button_friday.Name = "button_friday";
            button_friday.Size = new Size(154, 68);
            button_friday.TabIndex = 4;
            button_friday.Text = "Freitag";
            button_friday.UseVisualStyleBackColor = true;
            button_friday.Click += button_friday_Click;
            // 
            // button_saturday
            // 
            button_saturday.Location = new Point(384, 165);
            button_saturday.Name = "button_saturday";
            button_saturday.Size = new Size(154, 68);
            button_saturday.TabIndex = 5;
            button_saturday.Text = "Samstag";
            button_saturday.UseVisualStyleBackColor = true;
            button_saturday.Click += button_saturday_Click;
            // 
            // button_sunday
            // 
            button_sunday.Location = new Point(606, 165);
            button_sunday.Name = "button_sunday";
            button_sunday.Size = new Size(154, 68);
            button_sunday.TabIndex = 6;
            button_sunday.Text = "Sonntag";
            button_sunday.UseVisualStyleBackColor = true;
            button_sunday.Click += button_sunday_Click;
            // 
            // labelDay
            // 
            labelDay.AutoSize = true;
            labelDay.Location = new Point(99, 458);
            labelDay.Name = "labelDay";
            labelDay.Size = new Size(193, 32);
            labelDay.TabIndex = 7;
            labelDay.Text = "Numerischer Tag";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 591);
            Controls.Add(labelDay);
            Controls.Add(button_sunday);
            Controls.Add(button_saturday);
            Controls.Add(button_friday);
            Controls.Add(button_thursday);
            Controls.Add(button_wednesday);
            Controls.Add(button_tuesday);
            Controls.Add(button_monday);
            Name = "Form1";
            Text = "Wochentage";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_monday;
        private Button button_tuesday;
        private Button button_wednesday;
        private Button button_thursday;
        private Button button_friday;
        private Button button_saturday;
        private Button button_sunday;
        private Label labelDay;
    }
}

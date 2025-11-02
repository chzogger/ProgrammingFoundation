namespace Aufgabe_A4_2_3
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
            HeightBox = new TextBox();
            WidthBox = new TextBox();
            laenge = new Label();
            breite = new Label();
            label1 = new Label();
            ZeichnenButton = new Button();
            MyBox = new Button();
            toolTip1 = new ToolTip(components);
            LabelWidth = new Label();
            LabelHeight = new Label();
            SuspendLayout();
            // 
            // HeightBox
            // 
            HeightBox.Location = new Point(197, 65);
            HeightBox.Name = "HeightBox";
            HeightBox.Size = new Size(282, 39);
            HeightBox.TabIndex = 0;
            HeightBox.TextChanged += HeightBox_TextChanged;
            // 
            // WidthBox
            // 
            WidthBox.Location = new Point(197, 135);
            WidthBox.Name = "WidthBox";
            WidthBox.Size = new Size(282, 39);
            WidthBox.TabIndex = 1;
            WidthBox.TextChanged += WidthBox_TextChanged;
            // 
            // laenge
            // 
            laenge.AutoSize = true;
            laenge.Location = new Point(49, 68);
            laenge.Name = "laenge";
            laenge.Size = new Size(84, 32);
            laenge.TabIndex = 2;
            laenge.Text = "Höhe: ";
            // 
            // breite
            // 
            breite.AutoSize = true;
            breite.Location = new Point(49, 138);
            breite.Name = "breite";
            breite.Size = new Size(85, 32);
            breite.TabIndex = 3;
            breite.Text = "width: ";
            breite.Click += Form1_Load;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 268);
            label1.Name = "label1";
            label1.Size = new Size(479, 32);
            label1.TabIndex = 4;
            label1.Text = "Werte zwischen 50mm und 200mm erlaubt:";
            // 
            // ZeichnenButton
            // 
            ZeichnenButton.Location = new Point(194, 406);
            ZeichnenButton.Name = "ZeichnenButton";
            ZeichnenButton.Size = new Size(245, 44);
            ZeichnenButton.TabIndex = 5;
            ZeichnenButton.Text = "Zeichne";
            ZeichnenButton.UseVisualStyleBackColor = true;
            ZeichnenButton.Click += ZeichnenButton_Click;
            // 
            // MyBox
            // 
            MyBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MyBox.BackColor = SystemColors.ActiveCaption;
            MyBox.Location = new Point(843, 138);
            MyBox.Margin = new Padding(0);
            MyBox.Name = "MyBox";
            MyBox.Size = new Size(324, 300);
            MyBox.TabIndex = 6;
            MyBox.UseVisualStyleBackColor = false;
            MyBox.Click += MyBox_Click;
            // 
            // LabelWidth
            // 
            LabelWidth.Anchor = AnchorStyles.Top;
            LabelWidth.AutoSize = true;
            LabelWidth.Location = new Point(901, 106);
            LabelWidth.Name = "LabelWidth";
            LabelWidth.Size = new Size(0, 32);
            LabelWidth.TabIndex = 7;
            // 
            // LabelHeight
            // 
            LabelHeight.Anchor = AnchorStyles.Right;
            LabelHeight.AutoSize = true;
            LabelHeight.Location = new Point(788, 272);
            LabelHeight.Name = "LabelHeight";
            LabelHeight.Size = new Size(0, 32);
            LabelHeight.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1546, 820);
            Controls.Add(LabelHeight);
            Controls.Add(LabelWidth);
            Controls.Add(MyBox);
            Controls.Add(ZeichnenButton);
            Controls.Add(label1);
            Controls.Add(breite);
            Controls.Add(laenge);
            Controls.Add(WidthBox);
            Controls.Add(HeightBox);
            Name = "Form1";
            Text = "Meine Grösse";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox HeightBox;
        private TextBox WidthBox;
        private Label laenge;
        private Label breite;
        private Label label1;
        private Button ZeichnenButton;
        private Button MyBox;
        private ToolTip toolTip1;
        private Label LabelWidth;
        private Label LabelHeight;
    }
}

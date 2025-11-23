namespace Aufgabe_A9_2_5
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
            BtStart = new Button();
            BtDelete = new Button();
            TxBxNumbers = new TextBox();
            SuspendLayout();
            // 
            // BtStart
            // 
            BtStart.Location = new Point(61, 977);
            BtStart.Name = "BtStart";
            BtStart.Size = new Size(220, 71);
            BtStart.TabIndex = 0;
            BtStart.Text = "Start";
            BtStart.UseVisualStyleBackColor = true;
            BtStart.Click += BtStart_Click;
            // 
            // BtDelete
            // 
            BtDelete.Location = new Point(376, 977);
            BtDelete.Name = "BtDelete";
            BtDelete.Size = new Size(220, 71);
            BtDelete.TabIndex = 1;
            BtDelete.Text = "Löschen";
            BtDelete.UseVisualStyleBackColor = true;
            // 
            // TxBxNumbers
            // 
            TxBxNumbers.Location = new Point(60, 65);
            TxBxNumbers.Multiline = true;
            TxBxNumbers.Name = "TxBxNumbers";
            TxBxNumbers.RightToLeft = RightToLeft.No;
            TxBxNumbers.Size = new Size(539, 878);
            TxBxNumbers.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 1061);
            Controls.Add(TxBxNumbers);
            Controls.Add(BtDelete);
            Controls.Add(BtStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtStart;
        private Button BtDelete;
        private TextBox TxBxNumbers;
    }
}

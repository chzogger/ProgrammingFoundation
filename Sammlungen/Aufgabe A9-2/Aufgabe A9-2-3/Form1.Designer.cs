namespace Aufgabe_A9_2_3
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
            BtData = new Button();
            BtCopy = new Button();
            BxData = new TextBox();
            BxCopy = new TextBox();
            SuspendLayout();
            // 
            // BtData
            // 
            BtData.Location = new Point(126, 46);
            BtData.Name = "BtData";
            BtData.Size = new Size(545, 47);
            BtData.TabIndex = 0;
            BtData.Text = "Generiere Zahlen für Array data";
            BtData.UseVisualStyleBackColor = true;
            BtData.Click += BtData_Click;
            // 
            // BtCopy
            // 
            BtCopy.Location = new Point(126, 247);
            BtCopy.Name = "BtCopy";
            BtCopy.Size = new Size(545, 47);
            BtCopy.TabIndex = 1;
            BtCopy.Text = "Kopire Zahlen in Array dataCopy";
            BtCopy.UseVisualStyleBackColor = true;
            BtCopy.Click += BtCopy_Click;
            // 
            // BxData
            // 
            BxData.Location = new Point(126, 121);
            BxData.Name = "BxData";
            BxData.Size = new Size(545, 39);
            BxData.TabIndex = 2;
            // 
            // BxCopy
            // 
            BxCopy.Location = new Point(126, 335);
            BxCopy.Name = "BxCopy";
            BxCopy.Size = new Size(545, 39);
            BxCopy.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BxCopy);
            Controls.Add(BxData);
            Controls.Add(BtCopy);
            Controls.Add(BtData);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtData;
        private Button BtCopy;
        private TextBox BxData;
        private TextBox BxCopy;
    }
}

namespace Recope_Book___Teil_1
{
    partial class Rezeptbuch
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
            CmdAddRecipe = new Button();
            CmdRecipeDelete = new Button();
            label6 = new Label();
            LstRecipes = new ListBox();
            label4 = new Label();
            label3 = new Label();
            NudDuration = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            TxtInstruction = new TextBox();
            TxtRecipeName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)NudDuration).BeginInit();
            SuspendLayout();
            // 
            // CmdAddRecipe
            // 
            CmdAddRecipe.Location = new Point(163, 908);
            CmdAddRecipe.Margin = new Padding(6);
            CmdAddRecipe.Name = "CmdAddRecipe";
            CmdAddRecipe.Size = new Size(353, 49);
            CmdAddRecipe.TabIndex = 22;
            CmdAddRecipe.Text = "Rezept hinzufügen";
            CmdAddRecipe.UseVisualStyleBackColor = true;
            CmdAddRecipe.Click += CmdAddRecipe_Click;
            // 
            // CmdRecipeDelete
            // 
            CmdRecipeDelete.Location = new Point(629, 908);
            CmdRecipeDelete.Margin = new Padding(6);
            CmdRecipeDelete.Name = "CmdRecipeDelete";
            CmdRecipeDelete.Size = new Size(371, 49);
            CmdRecipeDelete.TabIndex = 21;
            CmdRecipeDelete.Text = "Rezept löschen";
            CmdRecipeDelete.UseVisualStyleBackColor = true;
            CmdRecipeDelete.Click += CmdRecipeDelete_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label6.Location = new Point(165, 14);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(381, 57);
            label6.TabIndex = 20;
            label6.Text = "Erfasse ein Rezept";
            // 
            // LstRecipes
            // 
            LstRecipes.FormattingEnabled = true;
            LstRecipes.Location = new Point(629, 114);
            LstRecipes.Margin = new Padding(6);
            LstRecipes.Name = "LstRecipes";
            LstRecipes.Size = new Size(368, 740);
            LstRecipes.TabIndex = 19;
            LstRecipes.SelectedIndexChanged += LstRecipes_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label4.Location = new Point(629, 14);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(404, 57);
            label4.TabIndex = 18;
            label4.Text = "Alle meine Rezepte";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 210);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(146, 32);
            label3.TabIndex = 17;
            label3.Text = "Zeitaufwand";
            // 
            // NudDuration
            // 
            NudDuration.Location = new Point(165, 206);
            NudDuration.Margin = new Padding(6);
            NudDuration.Name = "NudDuration";
            NudDuration.Size = new Size(351, 39);
            NudDuration.TabIndex = 16;
            NudDuration.ValueChanged += NudDuration_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 298);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 32);
            label2.TabIndex = 15;
            label2.Text = "Anleitung";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 132);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(146, 32);
            label1.TabIndex = 14;
            label1.Text = "Rezeptname";
            // 
            // TxtInstruction
            // 
            TxtInstruction.Location = new Point(165, 292);
            TxtInstruction.Margin = new Padding(6);
            TxtInstruction.Multiline = true;
            TxtInstruction.Name = "TxtInstruction";
            TxtInstruction.Size = new Size(348, 571);
            TxtInstruction.TabIndex = 13;
            TxtInstruction.TextChanged += TxtInstruction_TextChanged;
            // 
            // TxtRecipeName
            // 
            TxtRecipeName.Location = new Point(165, 125);
            TxtRecipeName.Margin = new Padding(6);
            TxtRecipeName.Name = "TxtRecipeName";
            TxtRecipeName.Size = new Size(348, 39);
            TxtRecipeName.TabIndex = 12;
            TxtRecipeName.TextChanged += TxtRecipeName_TextChanged;
            // 
            // Rezeptbuch
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 1026);
            Controls.Add(CmdAddRecipe);
            Controls.Add(CmdRecipeDelete);
            Controls.Add(label6);
            Controls.Add(LstRecipes);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(NudDuration);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtInstruction);
            Controls.Add(TxtRecipeName);
            Name = "Rezeptbuch";
            Text = "Rezeptbuch";
            ((System.ComponentModel.ISupportInitialize)NudDuration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAddRecipe;
        private Button CmdRecipeDelete;
        private Label label6;
        private ListBox LstRecipes;
        private Label label4;
        private Label label3;
        private NumericUpDown NudDuration;
        private Label label2;
        private Label label1;
        private TextBox TxtInstruction;
        private TextBox TxtRecipeName;
    }
}

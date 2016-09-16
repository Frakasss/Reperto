namespace Reperto
{
    partial class FormulaireTheme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCreationTheme = new System.Windows.Forms.TextBox();
            this.btnCreationTheme = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxListThemesModif = new System.Windows.Forms.ComboBox();
            this.txtModificationTheme = new System.Windows.Forms.TextBox();
            this.btnModifierTheme = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxListThemesSupp = new System.Windows.Forms.ComboBox();
            this.btnSupprimerTheme = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCreationTheme);
            this.groupBox1.Controls.Add(this.btnCreationTheme);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Créer Mot Clé";
            // 
            // txtCreationTheme
            // 
            this.txtCreationTheme.Location = new System.Drawing.Point(23, 54);
            this.txtCreationTheme.Name = "txtCreationTheme";
            this.txtCreationTheme.Size = new System.Drawing.Size(168, 20);
            this.txtCreationTheme.TabIndex = 1;
            // 
            // btnCreationTheme
            // 
            this.btnCreationTheme.Location = new System.Drawing.Point(306, 52);
            this.btnCreationTheme.Name = "btnCreationTheme";
            this.btnCreationTheme.Size = new System.Drawing.Size(75, 23);
            this.btnCreationTheme.TabIndex = 0;
            this.btnCreationTheme.Text = "Créer";
            this.btnCreationTheme.UseVisualStyleBackColor = true;
            this.btnCreationTheme.Click += new System.EventHandler(this.btnCreationTheme_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxListThemesModif);
            this.groupBox2.Controls.Add(this.txtModificationTheme);
            this.groupBox2.Controls.Add(this.btnModifierTheme);
            this.groupBox2.Location = new System.Drawing.Point(6, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 126);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modifier Mot Clé";
            // 
            // cbxListThemesModif
            // 
            this.cbxListThemesModif.FormattingEnabled = true;
            this.cbxListThemesModif.Location = new System.Drawing.Point(23, 43);
            this.cbxListThemesModif.Name = "cbxListThemesModif";
            this.cbxListThemesModif.Size = new System.Drawing.Size(168, 21);
            this.cbxListThemesModif.TabIndex = 2;
            // 
            // txtModificationTheme
            // 
            this.txtModificationTheme.Location = new System.Drawing.Point(23, 77);
            this.txtModificationTheme.Name = "txtModificationTheme";
            this.txtModificationTheme.Size = new System.Drawing.Size(168, 20);
            this.txtModificationTheme.TabIndex = 1;
            // 
            // btnModifierTheme
            // 
            this.btnModifierTheme.Location = new System.Drawing.Point(306, 56);
            this.btnModifierTheme.Name = "btnModifierTheme";
            this.btnModifierTheme.Size = new System.Drawing.Size(75, 23);
            this.btnModifierTheme.TabIndex = 0;
            this.btnModifierTheme.Text = "Modifier";
            this.btnModifierTheme.UseVisualStyleBackColor = true;
            this.btnModifierTheme.Click += new System.EventHandler(this.btnModifierTheme_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxListThemesSupp);
            this.groupBox3.Controls.Add(this.btnSupprimerTheme);
            this.groupBox3.Location = new System.Drawing.Point(6, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(436, 126);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Supprimer Mot Clé";
            // 
            // cbxListThemesSupp
            // 
            this.cbxListThemesSupp.FormattingEnabled = true;
            this.cbxListThemesSupp.Location = new System.Drawing.Point(23, 56);
            this.cbxListThemesSupp.Name = "cbxListThemesSupp";
            this.cbxListThemesSupp.Size = new System.Drawing.Size(168, 21);
            this.cbxListThemesSupp.TabIndex = 1;
            // 
            // btnSupprimerTheme
            // 
            this.btnSupprimerTheme.Location = new System.Drawing.Point(306, 56);
            this.btnSupprimerTheme.Name = "btnSupprimerTheme";
            this.btnSupprimerTheme.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerTheme.TabIndex = 0;
            this.btnSupprimerTheme.Text = "Supprimer";
            this.btnSupprimerTheme.UseVisualStyleBackColor = true;
            this.btnSupprimerTheme.Click += new System.EventHandler(this.btnSupprimerTheme_Click);
            // 
            // FormulaireTheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 403);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormulaireTheme";
            this.Text = "Formulaire Mots Clé";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCreationTheme;
        private System.Windows.Forms.Button btnCreationTheme;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxListThemesModif;
        private System.Windows.Forms.TextBox txtModificationTheme;
        private System.Windows.Forms.Button btnModifierTheme;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbxListThemesSupp;
        private System.Windows.Forms.Button btnSupprimerTheme;
    }
}
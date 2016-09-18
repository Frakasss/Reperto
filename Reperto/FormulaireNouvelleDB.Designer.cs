namespace Reperto
{
    partial class FormulaireNouvelleDB
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
            this.chkImportTheme = new System.Windows.Forms.CheckBox();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblAlerte = new System.Windows.Forms.Label();
            this.chkImportData = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkImportTheme
            // 
            this.chkImportTheme.AutoSize = true;
            this.chkImportTheme.Location = new System.Drawing.Point(229, 69);
            this.chkImportTheme.Name = "chkImportTheme";
            this.chkImportTheme.Size = new System.Drawing.Size(117, 17);
            this.chkImportTheme.TabIndex = 0;
            this.chkImportTheme.Text = "Importer les thèmes";
            this.chkImportTheme.UseVisualStyleBackColor = true;
            // 
            // txtDBName
            // 
            this.txtDBName.Location = new System.Drawing.Point(229, 30);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(227, 20);
            this.txtDBName.TabIndex = 1;
            this.txtDBName.TextChanged += new System.EventHandler(this.txtDBName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom de la nouvelle Base de Données :";
            // 
            // btnCreer
            // 
            this.btnCreer.Enabled = false;
            this.btnCreer.Location = new System.Drawing.Point(381, 154);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(75, 23);
            this.btnCreer.TabIndex = 3;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(300, 154);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // lblAlerte
            // 
            this.lblAlerte.AutoSize = true;
            this.lblAlerte.ForeColor = System.Drawing.Color.Red;
            this.lblAlerte.Location = new System.Drawing.Point(145, 118);
            this.lblAlerte.Name = "lblAlerte";
            this.lblAlerte.Size = new System.Drawing.Size(182, 13);
            this.lblAlerte.TabIndex = 5;
            this.lblAlerte.Text = "Un fichier portant ce nom existe déjà.";
            this.lblAlerte.Visible = false;
            // 
            // chkImportData
            // 
            this.chkImportData.AutoSize = true;
            this.chkImportData.Location = new System.Drawing.Point(229, 92);
            this.chkImportData.Name = "chkImportData";
            this.chkImportData.Size = new System.Drawing.Size(176, 17);
            this.chkImportData.TabIndex = 6;
            this.chkImportData.Text = "Importer données sélectionnées";
            this.chkImportData.UseVisualStyleBackColor = true;
            // 
            // FormulaireNouvelleDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 189);
            this.Controls.Add(this.chkImportData);
            this.Controls.Add(this.lblAlerte);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDBName);
            this.Controls.Add(this.chkImportTheme);
            this.Name = "FormulaireNouvelleDB";
            this.Text = "Nouvelle Base de Données";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkImportTheme;
        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblAlerte;
        private System.Windows.Forms.CheckBox chkImportData;
    }
}
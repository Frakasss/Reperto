namespace Reperto
{
    partial class FormulaireActeurs
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
            this.txtActors = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvAnnuaire = new System.Windows.Forms.DataGridView();
            this.colNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRelation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chargerAnnuaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblprenom = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtRelation = new System.Windows.Forms.TextBox();
            this.lblRelation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnnuaire)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtActors
            // 
            this.txtActors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActors.Location = new System.Drawing.Point(12, 51);
            this.txtActors.Multiline = true;
            this.txtActors.Name = "txtActors";
            this.txtActors.Size = new System.Drawing.Size(491, 119);
            this.txtActors.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(428, 176);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Vider";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvAnnuaire
            // 
            this.dgvAnnuaire.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAnnuaire.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAnnuaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnnuaire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNom,
            this.colPrenom,
            this.colRelation});
            this.dgvAnnuaire.Location = new System.Drawing.Point(12, 296);
            this.dgvAnnuaire.Name = "dgvAnnuaire";
            this.dgvAnnuaire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnnuaire.Size = new System.Drawing.Size(491, 187);
            this.dgvAnnuaire.TabIndex = 3;
            this.dgvAnnuaire.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAnnuaire_CellContentDoubleClick);
            // 
            // colNom
            // 
            this.colNom.FillWeight = 75F;
            this.colNom.HeaderText = "Nom";
            this.colNom.Name = "colNom";
            // 
            // colPrenom
            // 
            this.colPrenom.HeaderText = "Prénom";
            this.colPrenom.Name = "colPrenom";
            // 
            // colRelation
            // 
            this.colRelation.FillWeight = 60F;
            this.colRelation.HeaderText = "Relation";
            this.colRelation.Name = "colRelation";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(428, 489);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(428, 555);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(347, 555);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(515, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chargerAnnuaireToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // chargerAnnuaireToolStripMenuItem
            // 
            this.chargerAnnuaireToolStripMenuItem.Name = "chargerAnnuaireToolStripMenuItem";
            this.chargerAnnuaireToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.chargerAnnuaireToolStripMenuItem.Text = "Charger Annuaire...";
            this.chargerAnnuaireToolStripMenuItem.Click += new System.EventHandler(this.chargerAnnuaireToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRelation);
            this.groupBox1.Controls.Add(this.txtRelation);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.lblprenom);
            this.groupBox1.Controls.Add(this.lblNom);
            this.groupBox1.Controls.Add(this.txtPrenom);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Location = new System.Drawing.Point(13, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 72);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(62, 19);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(154, 20);
            this.txtNom.TabIndex = 0;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(62, 46);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(154, 20);
            this.txtPrenom.TabIndex = 1;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(6, 22);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom :";
            // 
            // lblprenom
            // 
            this.lblprenom.AutoSize = true;
            this.lblprenom.Location = new System.Drawing.Point(6, 49);
            this.lblprenom.Name = "lblprenom";
            this.lblprenom.Size = new System.Drawing.Size(49, 13);
            this.lblprenom.TabIndex = 3;
            this.lblprenom.Text = "Prénom :";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(409, 44);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Filtrer";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtRelation
            // 
            this.txtRelation.Location = new System.Drawing.Point(315, 19);
            this.txtRelation.Name = "txtRelation";
            this.txtRelation.Size = new System.Drawing.Size(169, 20);
            this.txtRelation.TabIndex = 5;
            // 
            // lblRelation
            // 
            this.lblRelation.AutoSize = true;
            this.lblRelation.Location = new System.Drawing.Point(257, 22);
            this.lblRelation.Name = "lblRelation";
            this.lblRelation.Size = new System.Drawing.Size(52, 13);
            this.lblRelation.TabIndex = 6;
            this.lblRelation.Text = "Relation :";
            // 
            // FormulaireActeurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 590);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dgvAnnuaire);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtActors);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormulaireActeurs";
            this.Text = "Gestion des Acteurs";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnnuaire)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtActors;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvAnnuaire;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRelation;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chargerAnnuaireToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRelation;
        private System.Windows.Forms.TextBox txtRelation;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblprenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
    }
}
namespace Reperto
{
    partial class Accueil
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
            this.dgvListeFiches = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCassette = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTheme1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTheme2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLienVideo = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colLienVideoHidden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDebutSequenceHidden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxFiltre = new System.Windows.Forms.GroupBox();
            this.btnReInit = new System.Windows.Forms.Button();
            this.lblLieu = new System.Windows.Forms.Label();
            this.lblMotCle = new System.Windows.Forms.Label();
            this.txtMotCle = new System.Windows.Forms.TextBox();
            this.txtLieu = new System.Windows.Forms.TextBox();
            this.txtAnnee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxMois = new System.Windows.Forms.ComboBox();
            this.txtPersonne = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTheme2 = new System.Windows.Forms.ComboBox();
            this.cbxTheme1 = new System.Windows.Forms.ComboBox();
            this.lblRechercheDate = new System.Windows.Forms.Label();
            this.lblRechercheCassette = new System.Windows.Forms.Label();
            this.txtRechCassette = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerFichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirFichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesThèmesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.couleursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bleuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rougeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesThèmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVisualiser = new System.Windows.Forms.Button();
            this.btnDupliquer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeFiches)).BeginInit();
            this.gbxFiltre.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListeFiches
            // 
            this.dgvListeFiches.AllowUserToAddRows = false;
            this.dgvListeFiches.AllowUserToDeleteRows = false;
            this.dgvListeFiches.AllowUserToOrderColumns = true;
            this.dgvListeFiches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListeFiches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeFiches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colCassette,
            this.colDate,
            this.colTheme1,
            this.colTheme2,
            this.colPersonne,
            this.colLieu,
            this.colDescription,
            this.colLienVideo,
            this.colLienVideoHidden,
            this.colDebutSequenceHidden});
            this.dgvListeFiches.Location = new System.Drawing.Point(13, 239);
            this.dgvListeFiches.Name = "dgvListeFiches";
            this.dgvListeFiches.ReadOnly = true;
            this.dgvListeFiches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListeFiches.Size = new System.Drawing.Size(1075, 265);
            this.dgvListeFiches.TabIndex = 0;
            this.dgvListeFiches.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListeFiches_CellContentClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colCassette
            // 
            this.colCassette.HeaderText = "Support";
            this.colCassette.Name = "colCassette";
            this.colCassette.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colTheme1
            // 
            this.colTheme1.HeaderText = "Mot Clé";
            this.colTheme1.Name = "colTheme1";
            this.colTheme1.ReadOnly = true;
            // 
            // colTheme2
            // 
            this.colTheme2.HeaderText = "Mot Clé";
            this.colTheme2.Name = "colTheme2";
            this.colTheme2.ReadOnly = true;
            // 
            // colPersonne
            // 
            this.colPersonne.HeaderText = "Acteurs";
            this.colPersonne.Name = "colPersonne";
            this.colPersonne.ReadOnly = true;
            // 
            // colLieu
            // 
            this.colLieu.HeaderText = "Lieu";
            this.colLieu.Name = "colLieu";
            this.colLieu.ReadOnly = true;
            // 
            // colDescription
            // 
            this.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // colLienVideo
            // 
            this.colLienVideo.HeaderText = "Lien Video";
            this.colLienVideo.Name = "colLienVideo";
            this.colLienVideo.ReadOnly = true;
            this.colLienVideo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLienVideo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colLienVideoHidden
            // 
            this.colLienVideoHidden.HeaderText = "LienVideoHidden";
            this.colLienVideoHidden.Name = "colLienVideoHidden";
            this.colLienVideoHidden.ReadOnly = true;
            this.colLienVideoHidden.Visible = false;
            // 
            // colDebutSequenceHidden
            // 
            this.colDebutSequenceHidden.HeaderText = "DebutSequenceHidden";
            this.colDebutSequenceHidden.Name = "colDebutSequenceHidden";
            this.colDebutSequenceHidden.ReadOnly = true;
            this.colDebutSequenceHidden.Visible = false;
            // 
            // gbxFiltre
            // 
            this.gbxFiltre.Controls.Add(this.btnReInit);
            this.gbxFiltre.Controls.Add(this.lblLieu);
            this.gbxFiltre.Controls.Add(this.lblMotCle);
            this.gbxFiltre.Controls.Add(this.txtMotCle);
            this.gbxFiltre.Controls.Add(this.txtLieu);
            this.gbxFiltre.Controls.Add(this.txtAnnee);
            this.gbxFiltre.Controls.Add(this.label4);
            this.gbxFiltre.Controls.Add(this.cbxMois);
            this.gbxFiltre.Controls.Add(this.txtPersonne);
            this.gbxFiltre.Controls.Add(this.label3);
            this.gbxFiltre.Controls.Add(this.label2);
            this.gbxFiltre.Controls.Add(this.label1);
            this.gbxFiltre.Controls.Add(this.cbxTheme2);
            this.gbxFiltre.Controls.Add(this.cbxTheme1);
            this.gbxFiltre.Controls.Add(this.lblRechercheDate);
            this.gbxFiltre.Controls.Add(this.lblRechercheCassette);
            this.gbxFiltre.Controls.Add(this.txtRechCassette);
            this.gbxFiltre.Controls.Add(this.btnRechercher);
            this.gbxFiltre.Location = new System.Drawing.Point(13, 27);
            this.gbxFiltre.Name = "gbxFiltre";
            this.gbxFiltre.Size = new System.Drawing.Size(452, 206);
            this.gbxFiltre.TabIndex = 1;
            this.gbxFiltre.TabStop = false;
            this.gbxFiltre.Text = "Filtre";
            // 
            // btnReInit
            // 
            this.btnReInit.Location = new System.Drawing.Point(371, 147);
            this.btnReInit.Name = "btnReInit";
            this.btnReInit.Size = new System.Drawing.Size(75, 23);
            this.btnReInit.TabIndex = 10;
            this.btnReInit.Text = "Réinitialiser";
            this.btnReInit.UseVisualStyleBackColor = true;
            this.btnReInit.Click += new System.EventHandler(this.btnReInit_Click);
            // 
            // lblLieu
            // 
            this.lblLieu.AutoSize = true;
            this.lblLieu.Location = new System.Drawing.Point(6, 155);
            this.lblLieu.Name = "lblLieu";
            this.lblLieu.Size = new System.Drawing.Size(27, 13);
            this.lblLieu.TabIndex = 19;
            this.lblLieu.Text = "Lieu";
            // 
            // lblMotCle
            // 
            this.lblMotCle.AutoSize = true;
            this.lblMotCle.Location = new System.Drawing.Point(6, 182);
            this.lblMotCle.Name = "lblMotCle";
            this.lblMotCle.Size = new System.Drawing.Size(53, 13);
            this.lblMotCle.TabIndex = 18;
            this.lblMotCle.Text = "Mots Clés";
            // 
            // txtMotCle
            // 
            this.txtMotCle.Location = new System.Drawing.Point(72, 179);
            this.txtMotCle.Name = "txtMotCle";
            this.txtMotCle.Size = new System.Drawing.Size(242, 20);
            this.txtMotCle.TabIndex = 8;
            // 
            // txtLieu
            // 
            this.txtLieu.Location = new System.Drawing.Point(72, 152);
            this.txtLieu.Name = "txtLieu";
            this.txtLieu.Size = new System.Drawing.Size(242, 20);
            this.txtLieu.TabIndex = 7;
            // 
            // txtAnnee
            // 
            this.txtAnnee.Location = new System.Drawing.Point(262, 44);
            this.txtAnnee.Name = "txtAnnee";
            this.txtAnnee.Size = new System.Drawing.Size(100, 20);
            this.txtAnnee.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Année";
            // 
            // cbxMois
            // 
            this.cbxMois.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMois.FormattingEnabled = true;
            this.cbxMois.Items.AddRange(new object[] {
            "",
            "Janvier",
            "Février",
            "Mars",
            "Avril",
            "Mai",
            "Juin",
            "Juillet",
            "Aout",
            "Septembre",
            "Octobre",
            "Novembre",
            "Décembre"});
            this.cbxMois.Location = new System.Drawing.Point(72, 44);
            this.cbxMois.Name = "cbxMois";
            this.cbxMois.Size = new System.Drawing.Size(121, 21);
            this.cbxMois.TabIndex = 2;
            // 
            // txtPersonne
            // 
            this.txtPersonne.Location = new System.Drawing.Point(72, 125);
            this.txtPersonne.Name = "txtPersonne";
            this.txtPersonne.Size = new System.Drawing.Size(242, 20);
            this.txtPersonne.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Acteur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mot Clé";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mot Clé";
            // 
            // cbxTheme2
            // 
            this.cbxTheme2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTheme2.FormattingEnabled = true;
            this.cbxTheme2.Location = new System.Drawing.Point(72, 98);
            this.cbxTheme2.Name = "cbxTheme2";
            this.cbxTheme2.Size = new System.Drawing.Size(242, 21);
            this.cbxTheme2.TabIndex = 5;
            // 
            // cbxTheme1
            // 
            this.cbxTheme1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTheme1.FormattingEnabled = true;
            this.cbxTheme1.Location = new System.Drawing.Point(72, 71);
            this.cbxTheme1.Name = "cbxTheme1";
            this.cbxTheme1.Size = new System.Drawing.Size(242, 21);
            this.cbxTheme1.TabIndex = 4;
            // 
            // lblRechercheDate
            // 
            this.lblRechercheDate.AutoSize = true;
            this.lblRechercheDate.Location = new System.Drawing.Point(6, 47);
            this.lblRechercheDate.Name = "lblRechercheDate";
            this.lblRechercheDate.Size = new System.Drawing.Size(29, 13);
            this.lblRechercheDate.TabIndex = 3;
            this.lblRechercheDate.Text = "Mois";
            // 
            // lblRechercheCassette
            // 
            this.lblRechercheCassette.AutoSize = true;
            this.lblRechercheCassette.Location = new System.Drawing.Point(6, 20);
            this.lblRechercheCassette.Name = "lblRechercheCassette";
            this.lblRechercheCassette.Size = new System.Drawing.Size(44, 13);
            this.lblRechercheCassette.TabIndex = 2;
            this.lblRechercheCassette.Text = "Support";
            // 
            // txtRechCassette
            // 
            this.txtRechCassette.Location = new System.Drawing.Point(72, 17);
            this.txtRechCassette.Name = "txtRechCassette";
            this.txtRechCassette.Size = new System.Drawing.Size(48, 20);
            this.txtRechCassette.TabIndex = 1;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRechercher.Location = new System.Drawing.Point(371, 176);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 9;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNouveau.Location = new System.Drawing.Point(1013, 116);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(75, 23);
            this.btnNouveau.TabIndex = 12;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifier.Location = new System.Drawing.Point(1013, 173);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 13;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimer.Location = new System.Drawing.Point(1013, 203);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 14;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.paramètresToolStripMenuItem1,
            this.aProposToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerFichierToolStripMenuItem,
            this.ouvrirFichierToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // créerFichierToolStripMenuItem
            // 
            this.créerFichierToolStripMenuItem.Name = "créerFichierToolStripMenuItem";
            this.créerFichierToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.créerFichierToolStripMenuItem.Text = "Créer fichier...";
            this.créerFichierToolStripMenuItem.Click += new System.EventHandler(this.créerFichierToolStripMenuItem_Click);
            // 
            // ouvrirFichierToolStripMenuItem
            // 
            this.ouvrirFichierToolStripMenuItem.Name = "ouvrirFichierToolStripMenuItem";
            this.ouvrirFichierToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.ouvrirFichierToolStripMenuItem.Text = "Ouvrir fichier...";
            this.ouvrirFichierToolStripMenuItem.Click += new System.EventHandler(this.ouvrirFichierToolStripMenuItem_Click);
            // 
            // paramètresToolStripMenuItem1
            // 
            this.paramètresToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesThèmesToolStripMenuItem1,
            this.couleursToolStripMenuItem});
            this.paramètresToolStripMenuItem1.Name = "paramètresToolStripMenuItem1";
            this.paramètresToolStripMenuItem1.Size = new System.Drawing.Size(78, 20);
            this.paramètresToolStripMenuItem1.Text = "Paramètres";
            // 
            // gestionDesThèmesToolStripMenuItem1
            // 
            this.gestionDesThèmesToolStripMenuItem1.Name = "gestionDesThèmesToolStripMenuItem1";
            this.gestionDesThèmesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.gestionDesThèmesToolStripMenuItem1.Text = "Gestion des Thèmes";
            this.gestionDesThèmesToolStripMenuItem1.Click += new System.EventHandler(this.gestionDesThèmesToolStripMenuItem_Click);
            // 
            // couleursToolStripMenuItem
            // 
            this.couleursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.bleuToolStripMenuItem,
            this.vertToolStripMenuItem,
            this.rougeToolStripMenuItem,
            this.noirToolStripMenuItem});
            this.couleursToolStripMenuItem.Name = "couleursToolStripMenuItem";
            this.couleursToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.couleursToolStripMenuItem.Text = "Couleurs...";
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.standardToolStripMenuItem.Text = "Standard";
            this.standardToolStripMenuItem.Click += new System.EventHandler(this.standardToolStripMenuItem_Click);
            // 
            // bleuToolStripMenuItem
            // 
            this.bleuToolStripMenuItem.Checked = true;
            this.bleuToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bleuToolStripMenuItem.Name = "bleuToolStripMenuItem";
            this.bleuToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.bleuToolStripMenuItem.Text = "Bleu";
            this.bleuToolStripMenuItem.Click += new System.EventHandler(this.bleuToolStripMenuItem_Click);
            // 
            // vertToolStripMenuItem
            // 
            this.vertToolStripMenuItem.Name = "vertToolStripMenuItem";
            this.vertToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.vertToolStripMenuItem.Text = "Vert";
            this.vertToolStripMenuItem.Click += new System.EventHandler(this.vertToolStripMenuItem_Click);
            // 
            // rougeToolStripMenuItem
            // 
            this.rougeToolStripMenuItem.Name = "rougeToolStripMenuItem";
            this.rougeToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.rougeToolStripMenuItem.Text = "Rouge";
            this.rougeToolStripMenuItem.Click += new System.EventHandler(this.rougeToolStripMenuItem_Click);
            // 
            // noirToolStripMenuItem
            // 
            this.noirToolStripMenuItem.Name = "noirToolStripMenuItem";
            this.noirToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.noirToolStripMenuItem.Text = "Noir";
            this.noirToolStripMenuItem.Click += new System.EventHandler(this.noirToolStripMenuItem_Click);
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.aProposToolStripMenuItem.Text = "A Propos...";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // paramètresToolStripMenuItem
            // 
            this.paramètresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesThèmesToolStripMenuItem});
            this.paramètresToolStripMenuItem.Name = "paramètresToolStripMenuItem";
            this.paramètresToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.paramètresToolStripMenuItem.Text = "Paramètres";
            // 
            // gestionDesThèmesToolStripMenuItem
            // 
            this.gestionDesThèmesToolStripMenuItem.Name = "gestionDesThèmesToolStripMenuItem";
            this.gestionDesThèmesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionDesThèmesToolStripMenuItem.Text = "Gestion des Thèmes";
            this.gestionDesThèmesToolStripMenuItem.Click += new System.EventHandler(this.gestionDesThèmesToolStripMenuItem_Click);
            // 
            // btnVisualiser
            // 
            this.btnVisualiser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisualiser.Location = new System.Drawing.Point(908, 203);
            this.btnVisualiser.Name = "btnVisualiser";
            this.btnVisualiser.Size = new System.Drawing.Size(75, 23);
            this.btnVisualiser.TabIndex = 11;
            this.btnVisualiser.Text = "Visualiser";
            this.btnVisualiser.UseVisualStyleBackColor = true;
            this.btnVisualiser.Click += new System.EventHandler(this.btnVisualiser_Click);
            // 
            // btnDupliquer
            // 
            this.btnDupliquer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDupliquer.Location = new System.Drawing.Point(1013, 145);
            this.btnDupliquer.Name = "btnDupliquer";
            this.btnDupliquer.Size = new System.Drawing.Size(75, 23);
            this.btnDupliquer.TabIndex = 16;
            this.btnDupliquer.Text = "Dupliquer";
            this.btnDupliquer.UseVisualStyleBackColor = true;
            this.btnDupliquer.Click += new System.EventHandler(this.btnDupliquer_Click);
            // 
            // Accueil
            // 
            this.AcceptButton = this.btnRechercher;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1100, 516);
            this.Controls.Add(this.btnDupliquer);
            this.Controls.Add(this.btnVisualiser);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.gbxFiltre);
            this.Controls.Add(this.dgvListeFiches);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Accueil";
            this.Text = "Accueil";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeFiches)).EndInit();
            this.gbxFiltre.ResumeLayout(false);
            this.gbxFiltre.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListeFiches;
        private System.Windows.Forms.GroupBox gbxFiltre;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paramètresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesThèmesToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTheme2;
        private System.Windows.Forms.ComboBox cbxTheme1;
        private System.Windows.Forms.Label lblRechercheDate;
        private System.Windows.Forms.Label lblRechercheCassette;
        private System.Windows.Forms.TextBox txtRechCassette;
        private System.Windows.Forms.TextBox txtPersonne;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVisualiser;
        private System.Windows.Forms.TextBox txtAnnee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxMois;
        private System.Windows.Forms.Button btnReInit;
        private System.Windows.Forms.Label lblLieu;
        private System.Windows.Forms.Label lblMotCle;
        private System.Windows.Forms.TextBox txtMotCle;
        private System.Windows.Forms.TextBox txtLieu;
        private System.Windows.Forms.Button btnDupliquer;
        private System.Windows.Forms.ToolStripMenuItem paramètresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesThèmesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couleursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bleuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rougeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerFichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirFichierToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCassette;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTheme1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTheme2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonne;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewLinkColumn colLienVideo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLienVideoHidden;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDebutSequenceHidden;
    }
}


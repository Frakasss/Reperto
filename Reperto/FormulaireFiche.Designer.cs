namespace Reperto
{
    partial class FormulaireFiche
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
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.lblCassette = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTheme1 = new System.Windows.Forms.Label();
            this.lblTheme2 = new System.Windows.Forms.Label();
            this.lblPersonnes = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblLienVideo = new System.Windows.Forms.Label();
            this.lblDebutSequence = new System.Windows.Forms.Label();
            this.txtCassette = new System.Windows.Forms.TextBox();
            this.txtLienVideo = new System.Windows.Forms.TextBox();
            this.txtPersonnes = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.mtxDate = new System.Windows.Forms.MaskedTextBox();
            this.mtxDebutSequence = new System.Windows.Forms.MaskedTextBox();
            this.cbxTheme1 = new System.Windows.Forms.ComboBox();
            this.cbxTheme2 = new System.Windows.Forms.ComboBox();
            this.lblLieu = new System.Windows.Forms.Label();
            this.txtLieu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEnregistrer.Location = new System.Drawing.Point(373, 328);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 8;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCassette
            // 
            this.lblCassette.AutoSize = true;
            this.lblCassette.Location = new System.Drawing.Point(62, 30);
            this.lblCassette.Name = "lblCassette";
            this.lblCassette.Size = new System.Drawing.Size(44, 13);
            this.lblCassette.TabIndex = 1;
            this.lblCassette.Text = "Support";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(62, 57);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // lblTheme1
            // 
            this.lblTheme1.AutoSize = true;
            this.lblTheme1.Location = new System.Drawing.Point(62, 84);
            this.lblTheme1.Name = "lblTheme1";
            this.lblTheme1.Size = new System.Drawing.Size(43, 13);
            this.lblTheme1.TabIndex = 3;
            this.lblTheme1.Text = "Mot Clé";
            // 
            // lblTheme2
            // 
            this.lblTheme2.AutoSize = true;
            this.lblTheme2.Location = new System.Drawing.Point(62, 112);
            this.lblTheme2.Name = "lblTheme2";
            this.lblTheme2.Size = new System.Drawing.Size(43, 13);
            this.lblTheme2.TabIndex = 4;
            this.lblTheme2.Text = "Mot Clé";
            // 
            // lblPersonnes
            // 
            this.lblPersonnes.AutoSize = true;
            this.lblPersonnes.Location = new System.Drawing.Point(62, 156);
            this.lblPersonnes.Name = "lblPersonnes";
            this.lblPersonnes.Size = new System.Drawing.Size(38, 13);
            this.lblPersonnes.TabIndex = 5;
            this.lblPersonnes.Text = "Acteur";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(62, 209);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description";
            // 
            // lblLienVideo
            // 
            this.lblLienVideo.AutoSize = true;
            this.lblLienVideo.Location = new System.Drawing.Point(62, 253);
            this.lblLienVideo.Name = "lblLienVideo";
            this.lblLienVideo.Size = new System.Drawing.Size(57, 13);
            this.lblLienVideo.TabIndex = 7;
            this.lblLienVideo.Text = "Lien Video";
            // 
            // lblDebutSequence
            // 
            this.lblDebutSequence.AutoSize = true;
            this.lblDebutSequence.Location = new System.Drawing.Point(62, 279);
            this.lblDebutSequence.Name = "lblDebutSequence";
            this.lblDebutSequence.Size = new System.Drawing.Size(88, 13);
            this.lblDebutSequence.TabIndex = 8;
            this.lblDebutSequence.Text = "Debut Sequence";
            // 
            // txtCassette
            // 
            this.txtCassette.Location = new System.Drawing.Point(157, 27);
            this.txtCassette.Name = "txtCassette";
            this.txtCassette.Size = new System.Drawing.Size(100, 20);
            this.txtCassette.TabIndex = 0;
            // 
            // txtLienVideo
            // 
            this.txtLienVideo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLienVideo.Location = new System.Drawing.Point(157, 250);
            this.txtLienVideo.Name = "txtLienVideo";
            this.txtLienVideo.Size = new System.Drawing.Size(575, 20);
            this.txtLienVideo.TabIndex = 6;
            // 
            // txtPersonnes
            // 
            this.txtPersonnes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPersonnes.Location = new System.Drawing.Point(157, 153);
            this.txtPersonnes.Name = "txtPersonnes";
            this.txtPersonnes.Size = new System.Drawing.Size(575, 20);
            this.txtPersonnes.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(157, 206);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(575, 20);
            this.txtDescription.TabIndex = 5;
            // 
            // mtxDate
            // 
            this.mtxDate.Location = new System.Drawing.Point(157, 54);
            this.mtxDate.Mask = "00-00-0000";
            this.mtxDate.Name = "mtxDate";
            this.mtxDate.Size = new System.Drawing.Size(100, 20);
            this.mtxDate.TabIndex = 1;
            // 
            // mtxDebutSequence
            // 
            this.mtxDebutSequence.Location = new System.Drawing.Point(157, 276);
            this.mtxDebutSequence.Mask = "00:00:00";
            this.mtxDebutSequence.Name = "mtxDebutSequence";
            this.mtxDebutSequence.Size = new System.Drawing.Size(100, 20);
            this.mtxDebutSequence.TabIndex = 7;
            // 
            // cbxTheme1
            // 
            this.cbxTheme1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTheme1.FormattingEnabled = true;
            this.cbxTheme1.Location = new System.Drawing.Point(157, 81);
            this.cbxTheme1.Name = "cbxTheme1";
            this.cbxTheme1.Size = new System.Drawing.Size(273, 21);
            this.cbxTheme1.Sorted = true;
            this.cbxTheme1.TabIndex = 2;
            // 
            // cbxTheme2
            // 
            this.cbxTheme2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTheme2.FormattingEnabled = true;
            this.cbxTheme2.Location = new System.Drawing.Point(157, 109);
            this.cbxTheme2.Name = "cbxTheme2";
            this.cbxTheme2.Size = new System.Drawing.Size(273, 21);
            this.cbxTheme2.TabIndex = 3;
            // 
            // lblLieu
            // 
            this.lblLieu.AutoSize = true;
            this.lblLieu.Location = new System.Drawing.Point(62, 183);
            this.lblLieu.Name = "lblLieu";
            this.lblLieu.Size = new System.Drawing.Size(27, 13);
            this.lblLieu.TabIndex = 9;
            this.lblLieu.Text = "Lieu";
            // 
            // txtLieu
            // 
            this.txtLieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLieu.Location = new System.Drawing.Point(157, 180);
            this.txtLieu.Name = "txtLieu";
            this.txtLieu.Size = new System.Drawing.Size(575, 20);
            this.txtLieu.TabIndex = 10;
            // 
            // FormulaireFiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 363);
            this.Controls.Add(this.txtLieu);
            this.Controls.Add(this.lblLieu);
            this.Controls.Add(this.cbxTheme2);
            this.Controls.Add(this.cbxTheme1);
            this.Controls.Add(this.mtxDebutSequence);
            this.Controls.Add(this.mtxDate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPersonnes);
            this.Controls.Add(this.txtLienVideo);
            this.Controls.Add(this.txtCassette);
            this.Controls.Add(this.lblDebutSequence);
            this.Controls.Add(this.lblLienVideo);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPersonnes);
            this.Controls.Add(this.lblTheme2);
            this.Controls.Add(this.lblTheme1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCassette);
            this.Controls.Add(this.btnEnregistrer);
            this.Name = "FormulaireFiche";
            this.Text = "Formulaire Fiche";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label lblCassette;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTheme1;
        private System.Windows.Forms.Label lblTheme2;
        private System.Windows.Forms.Label lblPersonnes;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblLienVideo;
        private System.Windows.Forms.Label lblDebutSequence;
        private System.Windows.Forms.TextBox txtCassette;
        private System.Windows.Forms.TextBox txtLienVideo;
        private System.Windows.Forms.TextBox txtPersonnes;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.MaskedTextBox mtxDate;
        private System.Windows.Forms.MaskedTextBox mtxDebutSequence;
        private System.Windows.Forms.ComboBox cbxTheme1;
        private System.Windows.Forms.ComboBox cbxTheme2;
        private System.Windows.Forms.Label lblLieu;
        private System.Windows.Forms.TextBox txtLieu;
    }
}
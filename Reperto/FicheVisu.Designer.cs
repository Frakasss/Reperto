namespace Reperto
{
    partial class FicheVisu
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
            this.lblCassette = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTheme1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnVideo = new System.Windows.Forms.Button();
            this.lblLienVideo = new System.Windows.Forms.Label();
            this.lblDebutSequence = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCassette
            // 
            this.lblCassette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCassette.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCassette.Location = new System.Drawing.Point(0, 0);
            this.lblCassette.Name = "lblCassette";
            this.lblCassette.Size = new System.Drawing.Size(545, 484);
            this.lblCassette.TabIndex = 0;
            this.lblCassette.Text = "lblCassette";
            this.lblCassette.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(-3, 32);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(548, 23);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "lblDate";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTheme1
            // 
            this.lblTheme1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTheme1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheme1.Location = new System.Drawing.Point(12, 67);
            this.lblTheme1.Name = "lblTheme1";
            this.lblTheme1.Size = new System.Drawing.Size(521, 24);
            this.lblTheme1.TabIndex = 2;
            this.lblTheme1.Text = "lblTheme1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 306);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Description";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(10, 22);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(505, 281);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "lblDescription";
            // 
            // btnVideo
            // 
            this.btnVideo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVideo.Location = new System.Drawing.Point(238, 437);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(75, 23);
            this.btnVideo.TabIndex = 3;
            this.btnVideo.Text = "Vidéo";
            this.btnVideo.UseVisualStyleBackColor = true;
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // lblLienVideo
            // 
            this.lblLienVideo.AutoSize = true;
            this.lblLienVideo.Location = new System.Drawing.Point(13, 434);
            this.lblLienVideo.Name = "lblLienVideo";
            this.lblLienVideo.Size = new System.Drawing.Size(91, 13);
            this.lblLienVideo.TabIndex = 5;
            this.lblLienVideo.Text = "invisibleLienVideo";
            this.lblLienVideo.Visible = false;
            // 
            // lblDebutSequence
            // 
            this.lblDebutSequence.AutoSize = true;
            this.lblDebutSequence.Location = new System.Drawing.Point(13, 447);
            this.lblDebutSequence.Name = "lblDebutSequence";
            this.lblDebutSequence.Size = new System.Drawing.Size(105, 13);
            this.lblDebutSequence.TabIndex = 6;
            this.lblDebutSequence.Text = "invisibleTempsDebut";
            this.lblDebutSequence.Visible = false;
            // 
            // FicheVisu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 484);
            this.Controls.Add(this.lblDebutSequence);
            this.Controls.Add(this.lblLienVideo);
            this.Controls.Add(this.btnVideo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTheme1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCassette);
            this.Name = "FicheVisu";
            this.Text = "Fiche";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCassette;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTheme1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.Label lblLienVideo;
        private System.Windows.Forms.Label lblDebutSequence;
    }
}
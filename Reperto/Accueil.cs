using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Reperto
{
    public partial class Accueil : Form
    {
        FunctionFiches fctn = new FunctionFiches();
        GlobalFunctions gfctn = new GlobalFunctions();
        FunctionThemes tfctn = new FunctionThemes();

        public Accueil()
        {
            InitializeComponent();
            InitializeThemeComboBox();
            MessageBox.Show("Charger le fichier DB et les couleurs dans AppConfig.xml");
            FillDatagridview(txtRechCassette.Text, cbxMois.Text, txtAnnee.Text, cbxTheme1.Text, cbxTheme2.Text, txtPersonne.Text, txtLieu.Text, txtMotCle.Text);
        
        }

        // Remplissage du datagridview
        private void FillDatagridview(string txtRechCassette, string cbxMois, string txtAnnee, string cbxTheme1, string cbxTheme2, string txtPersonne, string txtLieu, string txtMotCle){
            this.dgvListeFiches.Rows.Clear();
            foreach (Fiche myFiche in fctn.fnSelection(txtRechCassette, cbxMois, txtAnnee, cbxTheme1, cbxTheme2, txtPersonne, txtLieu, txtMotCle))
            {
                string labelLien = "";
                string lien = "";
                int secondes = (Convert.ToInt32(myFiche.TempsDebutSequence.Substring(0,2))*60*60) + (Convert.ToInt32(myFiche.TempsDebutSequence.Substring(3, 2)) * 60) + Convert.ToInt32(myFiche.TempsDebutSequence.Substring(6, 2));

                if (File.Exists(gfctn.AppDrive() + myFiche.LienVideo.Replace("\\", "/")))
                {
                    labelLien = "Video";
                    lien = myFiche.LienVideo.Replace("\\", "/");
                }


                this.dgvListeFiches.Rows.Add(myFiche.Id, myFiche.Cassette, Convert.ToDateTime(myFiche.Date), myFiche.Theme1, myFiche.Theme2, myFiche.Personne, myFiche.Lieu, myFiche.Description, labelLien, lien,secondes);
                dgvListeFiches.Columns["colDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }
        private void FillDatagridview(int indexToSelect, string txtRechCassette, string cbxMois, string txtAnnee, string cbxTheme1, string cbxTheme2, string txtPersonne, string txtLieu, string txtMotCle)
        {
            this.dgvListeFiches.Rows.Clear();
            foreach (Fiche myFiche in fctn.fnSelection(txtRechCassette, cbxMois, txtAnnee, cbxTheme1, cbxTheme2, txtPersonne, txtLieu, txtMotCle))
            {
                string labelLien = "";
                string lien = "";
                int secondes = (Convert.ToInt32(myFiche.TempsDebutSequence.Substring(0, 2)) * 60 * 60) + (Convert.ToInt32(myFiche.TempsDebutSequence.Substring(3, 2)) * 60) + Convert.ToInt32(myFiche.TempsDebutSequence.Substring(6, 2));

                if (File.Exists(gfctn.AppDrive() + myFiche.LienVideo.Replace("\\", "/")))
                {
                    labelLien = "Video";
                    lien = myFiche.LienVideo.Replace("\\", "/");
                }


                this.dgvListeFiches.Rows.Add(myFiche.Id, myFiche.Cassette, Convert.ToDateTime(myFiche.Date), myFiche.Theme1, myFiche.Theme2, myFiche.Personne, myFiche.Lieu, myFiche.Description, labelLien, lien, secondes);
                dgvListeFiches.Columns["colDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }
        private void FillDatagridview(string idToSelect, string txtRechCassette, string cbxMois, string txtAnnee, string cbxTheme1, string cbxTheme2, string txtPersonne, string txtLieu, string txtMotCle)
        {
            this.dgvListeFiches.Rows.Clear();
            foreach (Fiche myFiche in fctn.fnSelection(txtRechCassette, cbxMois, txtAnnee, cbxTheme1, cbxTheme2, txtPersonne, txtLieu, txtMotCle))
            {
                string labelLien = "";
                string lien = "";
                int secondes = (Convert.ToInt32(myFiche.TempsDebutSequence.Substring(0, 2)) * 60 * 60) + (Convert.ToInt32(myFiche.TempsDebutSequence.Substring(3, 2)) * 60) + Convert.ToInt32(myFiche.TempsDebutSequence.Substring(6, 2));

                if (File.Exists(gfctn.AppDrive() + myFiche.LienVideo.Replace("\\", "/")))
                {
                    labelLien = "Video";
                    lien = myFiche.LienVideo.Replace("\\", "/");
                }


                this.dgvListeFiches.Rows.Add(myFiche.Id, myFiche.Cassette, Convert.ToDateTime(myFiche.Date), myFiche.Theme1, myFiche.Theme2, myFiche.Personne, myFiche.Lieu, myFiche.Description, labelLien, lien, secondes);
                dgvListeFiches.Columns["colDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }
        
        // Initialisation des thèmes
        public void InitializeThemeComboBox()
        {
            this.cbxTheme1.Items.Clear();
            this.cbxTheme2.Items.Clear();
            this.cbxTheme1.Items.Add("");
            this.cbxTheme2.Items.Add("");
            foreach (string item in tfctn.fnSelectThemes())
            {
                this.cbxTheme1.Items.Add(item);
                this.cbxTheme2.Items.Add(item);
            }
            this.cbxTheme1.SelectedIndex = 0;
            this.cbxTheme2.SelectedIndex = 0;
        }

        // Bouton Réinitialiser formulaire de recherche
        private void btnReInit_Click(object sender, EventArgs e)
        {
            txtRechCassette.Text = "";
            cbxMois.SelectedItem = "";
            txtAnnee.Text = "";
            cbxTheme1.SelectedItem = "";
            cbxTheme2.SelectedItem = "";
            txtPersonne.Text = "";
            txtLieu.Text = "";
            txtMotCle.Text = "";
        }

        // Bouton Rechercher
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            FillDatagridview(txtRechCassette.Text, cbxMois.Text, txtAnnee.Text, cbxTheme1.Text, cbxTheme2.Text, txtPersonne.Text, txtLieu.Text, txtMotCle.Text);
        }

        // Bouton Créer
        private void btnNouveau_Click(object sender, EventArgs e)
        {
            string idToSelect = "0";
            FormulaireFiche formulaireFiche = new FormulaireFiche();
            formulaireFiche.modeFiche = FormulaireFiche.ModeFiche.CREER;
            formulaireFiche.ShowDialog();
            FillDatagridview(idToSelect,txtRechCassette.Text, cbxMois.Text, txtAnnee.Text, cbxTheme1.Text, cbxTheme2.Text, txtPersonne.Text, txtLieu.Text, txtMotCle.Text);
        }

        // Bouton Modifier
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (this.dgvListeFiches.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une ligne!");
            }
            else
            {
                string idToSelect = this.dgvListeFiches.CurrentRow.Cells["colId"].Value.ToString();
                FormulaireFiche formulaireFiche = new FormulaireFiche(Convert.ToInt32(idToSelect));
                formulaireFiche.modeFiche = FormulaireFiche.ModeFiche.MODIFIER;
                formulaireFiche.ShowDialog();
                FillDatagridview(idToSelect, txtRechCassette.Text, cbxMois.Text, txtAnnee.Text, cbxTheme1.Text, cbxTheme2.Text, txtPersonne.Text, txtLieu.Text, txtMotCle.Text);
            }
        }

        // Bouton Supprimer
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (this.dgvListeFiches.CurrentRow == null){
                MessageBox.Show("Veuillez sélectionner une ligne!");
            } else{
                int currentLineIndex = Convert.ToInt32(this.dgvListeFiches.CurrentRow.Cells["colId"].Value.ToString());
                fctn.fnSuppressionFiche(currentLineIndex);
                this.dgvListeFiches.Rows.Clear();
                FillDatagridview(currentLineIndex,txtRechCassette.Text, cbxMois.Text, txtAnnee.Text, cbxTheme1.Text, cbxTheme2.Text, txtPersonne.Text, txtLieu.Text, txtMotCle.Text);
            }
        }

        // Bouton dupliquer
        private void btnDupliquer_Click(object sender, EventArgs e)
        {
            if (this.dgvListeFiches.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une ligne!");
            }
            else
            {
                Fiche myFiche = new Fiche();
                string idToSelect = "";
                myFiche = fctn.fnSelection(Convert.ToInt32(this.dgvListeFiches.CurrentRow.Cells["colId"].Value.ToString()));

                idToSelect = fctn.fnCreationFiche(myFiche.Cassette, myFiche.Date, myFiche.Theme1, myFiche.Theme2, myFiche.Personne, myFiche.Lieu, myFiche.Description, myFiche.LienVideo, myFiche.TempsDebutSequence);
                FillDatagridview(idToSelect, txtRechCassette.Text, cbxMois.Text, txtAnnee.Text, cbxTheme1.Text, cbxTheme2.Text, txtPersonne.Text, txtLieu.Text, txtMotCle.Text);
            }
        }

        // Bouton Visualiser
        private void btnVisualiser_Click(object sender, EventArgs e)
        {
            if (this.dgvListeFiches.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une ligne!");
            }
            else
            {
                FicheVisu formulaireFiche = new FicheVisu(Convert.ToInt32(this.dgvListeFiches.CurrentRow.Cells["colId"].Value.ToString()));
                formulaireFiche.ShowDialog();
            }
        }

        // Menu parametres
        private void gestionDesThèmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string theme1 = this.cbxTheme1.Text;
            string theme2 = this.cbxTheme2.Text;
            FormulaireTheme formth = new FormulaireTheme();
            formth.ShowDialog();
            if (this.dgvListeFiches.CurrentRow == null){
                FillDatagridview(txtRechCassette.Text, cbxMois.Text, txtAnnee.Text, theme1, theme2, txtPersonne.Text, txtLieu.Text, txtMotCle.Text);
            }else{
                FillDatagridview(this.dgvListeFiches.CurrentRow.Cells["colId"].Value.ToString(), txtRechCassette.Text, cbxMois.Text, txtAnnee.Text, theme1, theme2, txtPersonne.Text, txtLieu.Text, txtMotCle.Text);                
            }
            
            InitializeThemeComboBox();
            cbxTheme1.SelectedIndex = cbxTheme1.FindStringExact(theme1);
            cbxTheme2.SelectedIndex = cbxTheme2.FindStringExact(theme2);
        }
        
        // Menu A Propos...
        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                  PICQ Michel            \n                        2016", "A Propos...");
        }

        // Clic sur le lien dans datagridview
        private void dgvListeFiches_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 8){
                MediaPlayer mplayer = new MediaPlayer(gfctn.AppDrive() + dgvListeFiches.Rows[e.RowIndex].Cells["colLienVideoHidden"].Value.ToString(), Convert.ToInt32(dgvListeFiches.Rows[e.RowIndex].Cells["colDebutSequenceHidden"].Value));
                mplayer.ShowDialog();
            }
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.bleuToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.rougeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.vertToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.noirToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.standardToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            Accueil.ActiveForm.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            MessageBox.Show("Enregistrer le changement dans AppConfig.xml");
        }

        private void bleuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.bleuToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rougeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.vertToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.noirToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.standardToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
            Accueil.ActiveForm.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            MessageBox.Show("Enregistrer le changement dans AppConfig.xml");
        }

        private void vertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.bleuToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.rougeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.vertToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.noirToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.standardToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
            Accueil.ActiveForm.BackColor = System.Drawing.Color.PaleTurquoise;
            this.menuStrip1.BackColor = System.Drawing.Color.Turquoise;
            MessageBox.Show("Enregistrer le changement dans AppConfig.xml");
        }

        private void rougeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.bleuToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.rougeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vertToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.noirToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.standardToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
            Accueil.ActiveForm.BackColor = System.Drawing.Color.LightCoral;
            this.menuStrip1.BackColor = System.Drawing.Color.Tomato;
            MessageBox.Show("Enregistrer le changement dans AppConfig.xml");
        }

        private void noirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.bleuToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.rougeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.vertToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.noirToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.standardToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
            Accueil.ActiveForm.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            MessageBox.Show("Enregistrer le changement dans AppConfig.xml");
        }

        private void créerFichierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Créer nouveau fichier xml et le déclarer dans AppConfig.xml");
        }

        private void ouvrirFichierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rechercher un fichier xml, puis effectuer une vérification. \n Si ok, l'ajouter à AppConfig.xml et le definir par défaut.");
        }

        private void supprimerFichierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rechercher un fichier et le supprimer avec demande de confirmation");
        }

    }
}

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
        }

        /// <summary>
        /// Bouton Créer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNouveau_Click(object sender, EventArgs e)
        {
            FormulaireFiche formulaireFiche = new FormulaireFiche();
            formulaireFiche.modeFiche = FormulaireFiche.ModeFiche.CREER;
            formulaireFiche.ShowDialog();
        }


        /// <summary>
        /// Bouton Rechercher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            this.dgvListeFiches.Rows.Clear();
            foreach (Fiche myFiche in fctn.fnSelection(txtRechCassette.Text, cbxMois.Text, txtAnnee.Text, cbxTheme1.Text, cbxTheme2.Text, txtPersonne.Text, txtLieu.Text, txtMotCle.Text))
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
            }
            dgvListeFiches.Columns["colDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            //this.dgvListeFiches.Sort(this.dgvListeFiches.Columns["colDate"], ListSortDirection.Ascending);
            //this.dgvListeFiches.ClearSelection();
            //this.dgvListeFiches.CurrentRow = this.dgvListeFiches.Rows[0];
            //this.dgvListeFiches.Rows[0].Cells[0].Selected = true;
        }


        /// <summary>
        /// Bouton Supprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (this.dgvListeFiches.CurrentRow == null){
                MessageBox.Show("Veuillez sélectionner une ligne!");
            } else{
                fctn.fnSuppressionFiche(Convert.ToInt32(this.dgvListeFiches.CurrentRow.Cells["colId"].Value.ToString()));
                this.dgvListeFiches.Rows.Clear();
            }
        }


        /// <summary>
        /// Bouton Modifier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (this.dgvListeFiches.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une ligne!");
            }
            else
            {
                FormulaireFiche formulaireFiche = new FormulaireFiche(Convert.ToInt32(this.dgvListeFiches.CurrentRow.Cells["colId"].Value.ToString()));
                formulaireFiche.modeFiche = FormulaireFiche.ModeFiche.MODIFIER;
                formulaireFiche.ShowDialog();
                //this.dgvListeFiches.Rows.Clear();
                this.btnRechercher.PerformClick();
            }
        }


        /// <summary>
        /// Bouton Visualiser
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// Menu parametres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gestionDesThèmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormulaireTheme formth = new FormulaireTheme();
            formth.ShowDialog();

            btnRechercher.PerformClick();
            /*
            this.dgvListeFiches.Rows.Clear();
            foreach (Fiche myFiche in fctn.fnSelection(txtRechCassette.Text, cbxMois.Text, txtAnnee.Text, cbxTheme1.Text, cbxTheme2.Text, txtPersonne.Text, txtLieu.Text, txtMotCle.Text))
            {
                this.dgvListeFiches.Rows.Add(myFiche.Id, myFiche.Cassette, Convert.ToDateTime(myFiche.Date), myFiche.Theme1, myFiche.Theme2, myFiche.Personne,myFiche.Lieu, myFiche.Description, myFiche.LienVideo);
            }
            dgvListeFiches.Columns["colDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            this.dgvListeFiches.Sort(this.dgvListeFiches.Columns["colDate"], ListSortDirection.Ascending);
        
             */ 
        }


        /// <summary>
        /// Clic sur le lien dans datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvListeFiches_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 8){
                MediaPlayer mplayer = new MediaPlayer(gfctn.AppDrive() + dgvListeFiches.Rows[e.RowIndex].Cells["colLienVideoHidden"].Value.ToString(), Convert.ToInt32(dgvListeFiches.Rows[e.RowIndex].Cells["colDebutSequenceHidden"].Value));
                mplayer.ShowDialog();
            }
        }

        /// <summary>
        /// Initialisation des thèmes
        /// </summary>
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

        private void btnDupliquer_Click(object sender, EventArgs e)
        {
            if (this.dgvListeFiches.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une ligne!");
            }
            else
            {
                Fiche myFiche = new Fiche();
                myFiche = fctn.fnSelection(Convert.ToInt32(this.dgvListeFiches.CurrentRow.Cells["colId"].Value.ToString()));

                fctn.fnCreationFiche(myFiche.Cassette, myFiche.Date, myFiche.Theme1, myFiche.Theme2, myFiche.Personne, myFiche.Lieu, myFiche.Description, myFiche.LienVideo, myFiche.TempsDebutSequence);

                this.btnRechercher.PerformClick();
            }
        }
    }
}

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
    public partial class FormulaireFiche : Form
    {
        #region Region Global
        public ModeFiche modeFiche;

        int idToUpdate = 0;

        FunctionFiches fctn = new FunctionFiches();
        FunctionThemes tfctn = new FunctionThemes();
        GlobalFunctions gfctn = new GlobalFunctions();

        public enum ModeFiche
        {
            CREER = 1,
            MODIFIER = 2,
            AFFICHER = 3
        }
        #endregion

        #region Constructeurs
        public FormulaireFiche()
        {
            InitializeComponent();
            InitializeThemeComboBox();
            InitializeDefaultValues();
        }

        public FormulaireFiche(int nodeToLoad)
        {
            InitializeComponent();
            InitializeThemeComboBox();

            idToUpdate = nodeToLoad;
            
            Fiche myfiche = new Fiche();
            myfiche = fctn.fnSelection(nodeToLoad);

            this.txtCassette.Text = myfiche.Cassette;
            this.mtxDate.Text = myfiche.Date;
            this.cbxTheme1.Text = myfiche.Theme1;
            this.cbxTheme2.Text = myfiche.Theme2;
            this.txtPersonnes.Text = myfiche.Personne;
            this.txtLieu.Text = myfiche.Lieu;
            this.txtDescription.Text = myfiche.Description;
            this.txtLienVideo.Text = myfiche.LienVideo;
            this.mtxDebutSequence.Text = myfiche.TempsDebutSequence;

        }


        public FormulaireFiche(int nodeToLoad, string visu)
        {
            InitializeComponent();
            InitializeThemeComboBox();

            idToUpdate = nodeToLoad;
            
            Fiche myfiche = new Fiche();
            myfiche = fctn.fnSelection(nodeToLoad);

            this.txtCassette.Text = myfiche.Cassette;
            this.mtxDate.Text = myfiche.Date;
            this.cbxTheme1.SelectedItem = myfiche.Theme1;
            this.cbxTheme2.SelectedItem = myfiche.Theme2;
            this.txtPersonnes.Text = myfiche.Personne;
            this.txtLieu.Text = myfiche.Lieu;
            this.txtDescription.Text = myfiche.Description;
            this.txtLienVideo.Text = myfiche.LienVideo;
            this.mtxDebutSequence.Text = myfiche.TempsDebutSequence;
        
            this.txtCassette.Enabled = false;
            this.mtxDate.Enabled = false;
            this.cbxTheme1.Enabled = false;
            this.cbxTheme2.Enabled = false;
            this.txtPersonnes.Enabled = false;
            this.txtDescription.Enabled = false;
            this.txtLienVideo.Enabled = false;
            this.mtxDebutSequence.Enabled = false;
            if (File.Exists(gfctn.AppRootPath() + this.txtLienVideo.Text.Replace("\\", "/")))
            {
                this.btnEnregistrer.Text = "Video";
            }
            else
            {
                this.btnEnregistrer.Visible = false;
            }
        }

        public void InitializeThemeComboBox(){
            this.cbxTheme1.Items.Clear();
            this.cbxTheme2.Items.Clear();
            this.cbxTheme1.Items.Add("");
            this.cbxTheme2.Items.Add("");
            foreach(string item in tfctn.fnSelectThemes()){
                this.cbxTheme1.Items.Add(item);
                this.cbxTheme2.Items.Add(item);
            }
            this.cbxTheme1.SelectedIndex = 0;
            this.cbxTheme2.SelectedIndex = 0;
        }

        public void InitializeDefaultValues()
        {
            this.mtxDate.Text = DateTime.Now.ToString();
            this.mtxDebutSequence.Text = "00:00:00";
        }
        #endregion

        #region Gestion Evenements
        private void button1_Click(object sender, EventArgs e)
        {
            //if (this.textBox1.Text == "")
            //{ MessageBox.Show("Name can't be empty"); }
            //else
            //{
                if (this.modeFiche == FormulaireFiche.ModeFiche.CREER){
                    fctn.fnCreationFiche(this.txtCassette.Text, this.mtxDate.Text, this.cbxTheme1.Text, this.cbxTheme2.Text ,this.txtPersonnes.Text, this.txtLieu.Text, this.txtDescription.Text, this.txtLienVideo.Text, this.mtxDebutSequence.Text);
                    this.Close();
                }

                if (this.modeFiche == FormulaireFiche.ModeFiche.MODIFIER){
                    fctn.fnModificationFiche(idToUpdate, this.txtCassette.Text, this.mtxDate.Text, this.cbxTheme1.Text, this.cbxTheme2.Text, this.txtPersonnes.Text, this.txtLieu.Text, this.txtDescription.Text, this.txtLienVideo.Text, this.mtxDebutSequence.Text);
                    this.Close();
                }

                if (this.modeFiche == FormulaireFiche.ModeFiche.AFFICHER)
                {
                    string lien = gfctn.AppRootPath() + this.txtLienVideo.Text.Replace("\\", "/");
                    int temps = (Convert.ToInt32(this.mtxDebutSequence.Text.Substring(0,2))*60*60)+(Convert.ToInt32(this.mtxDebutSequence.Text.Substring(3,2))*60)+Convert.ToInt32(this.mtxDebutSequence.Text.Substring(6,2));
                    MediaPlayer mplayer = new MediaPlayer(lien, temps);
                    mplayer.ShowDialog();
                }
                
            //}
        }
        #endregion
    }
}

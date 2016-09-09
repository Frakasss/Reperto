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
    public partial class FicheVisu : Form
    {

        int idToUpdate = 0;
        FunctionFiches fctn = new FunctionFiches();
        GlobalFunctions gfctn = new GlobalFunctions();

        public FicheVisu()
        {
            InitializeComponent();
        }

        public FicheVisu(int nodeToLoad)
        {
            InitializeComponent();

            idToUpdate = nodeToLoad;

            String desc = "";

            Fiche myfiche = new Fiche();
            myfiche = fctn.fnSelection(nodeToLoad);

            this.lblCassette.Text = myfiche.Cassette;
            this.lblDate.Text = myfiche.Date;
            this.lblTheme1.Text = myfiche.Theme1 + " - " + myfiche.Theme2;
            desc = myfiche.Lieu + "\n\n" + myfiche.Personne + "\n\n" + myfiche.Description.Replace(" - ", "\n - ");
            this.lblDescription.Text = desc;
            this.lblLienVideo.Text = myfiche.LienVideo;
            this.lblDebutSequence.Text = myfiche.TempsDebutSequence;

            if (File.Exists(gfctn.AppDrive() + myfiche.LienVideo.Replace("\\", "/")))
            {
                this.btnVideo.Enabled = true;
            }
            else
            {
                this.btnVideo.Enabled = false;
            }
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            string lien = gfctn.AppDrive() + this.lblLienVideo.Text.Replace("\\", "/");
            int temps = (Convert.ToInt32(this.lblDebutSequence.Text.Substring(0, 2)) * 60 * 60) + (Convert.ToInt32(this.lblDebutSequence.Text.Substring(3, 2)) * 60) + Convert.ToInt32(this.lblDebutSequence.Text.Substring(6, 2));
            MediaPlayer mplayer = new MediaPlayer(lien, temps);
            mplayer.ShowDialog();
        }
    }
}

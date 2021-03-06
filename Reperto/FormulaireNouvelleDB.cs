﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reperto
{
    public partial class FormulaireNouvelleDB : Form
    {
        #region global var
            GlobalFunctions gfctn = new GlobalFunctions();
            FunctionFiches fnfich = new FunctionFiches();
            FunctionDatabaseFile fndb = new FunctionDatabaseFile();
            FunctionThemes fnth = new FunctionThemes();
            public delegate void ChildEvent();
            public event ChildEvent activateRefresh;
            string gTxtRechCassette; 
            string gCbxMois; 
            string gTxtAnnee; 
            string gCbxTheme1; 
            string gCbxTheme2; 
            string gTxtPersonne; 
            string gTxtLieu;
            string gTxtMotCle;
        #endregion        

        #region constructeurs
            public FormulaireNouvelleDB()
            {
                InitializeComponent();
            }

        public FormulaireNouvelleDB(string txtRechCassette, string cbxMois, string txtAnnee, string cbxTheme1, string cbxTheme2, string txtPersonne, string txtLieu, string txtMotCle)
            {
                InitializeComponent();
                gTxtRechCassette = txtRechCassette;
                gCbxMois = cbxMois;
                gTxtAnnee = txtAnnee;
                gCbxTheme1 = cbxTheme1;
                gCbxTheme2 = cbxTheme2;
                gTxtPersonne = txtPersonne;
                gTxtLieu = txtLieu;
                gTxtMotCle = txtMotCle;
            }

        #endregion

        #region gestion event
            //bouton annuler
            private void btnAnnuler_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            //bouton créer
            private void btnCreer_Click(object sender, EventArgs e)
            {
                //creation fichier
                fnCreateFile();
                fnSetUpFile();
                this.activateRefresh();
                this.Close();
            }

            //changement contenu textbox
            private void txtDBName_TextChanged(object sender, EventArgs e)
            {
                if (this.txtDBName.Text == "")
                {
                    this.btnCreer.Enabled = false;
                }
                else
                {
                    if (System.IO.File.Exists(gfctn.AppRootPath() + "Reperto/" + this.txtDBName.Text + ".xml"))
                    {
                        this.btnCreer.Enabled = false;
                        lblAlerte.Visible = true;
                    }
                    else
                    {
                        this.btnCreer.Enabled = true;
                        lblAlerte.Visible = false;
                    }
                }
            }
        #endregion

        #region fonctions
            //créer fichier
            private void fnCreateFile(){
                System.IO.FileStream fs = System.IO.File.Create(gfctn.AppRootPath() + "Reperto/" + this.txtDBName.Text + ".xml");
                fs.Close();
            }

            //Initialise la nouvelle DB
            private void fnSetUpFile()
            {
                string[] lines = { "<root>", "<themes>", "</themes>","<fiches>","</fiches>","</root>" };
                System.IO.File.WriteAllLines(gfctn.AppRootPath() + "Reperto/" + this.txtDBName.Text + ".xml", lines);
                if (chkImportTheme.Checked == true) { fnth.importThemes(this.txtDBName.Text + ".xml"); }
                if (chkImportData.Checked == true) { fnfich.importData(this.txtDBName.Text + ".xml", gTxtRechCassette, gCbxMois, gTxtAnnee, gCbxTheme1, gCbxTheme2, gTxtPersonne, gTxtLieu, gTxtMotCle); }
                fndb.saveSelectedDatabase(this.txtDBName.Text + ".xml");
            }
        #endregion

    }
}

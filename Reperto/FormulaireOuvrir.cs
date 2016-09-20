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
    public partial class FormulaireOuvrir : Form
    {
        #region global var
            GlobalFunctions gfctn = new GlobalFunctions();
            FunctionDatabaseFile fndb = new FunctionDatabaseFile();
            public delegate void ChildEvent();
            public event ChildEvent activateRefresh;
        #endregion

        #region contructeurs
            public FormulaireOuvrir()
            {
                InitializeComponent();
                InitializeComboBox();
            }
        #endregion

            #region fonctions
            private void InitializeComboBox(){
                DirectoryInfo dir = new DirectoryInfo(gfctn.AppRootPath() + "Reperto/BasesDeDonnees/");
                FileInfo[] fichiers = dir.GetFiles();

                foreach (FileInfo fichier in fichiers)
                {
                    string myExtension = fichier.Name.Substring(fichier.Name.Length - 4);
                    if (myExtension.ToLower() == ".xml") { cbxFichiers.Items.Add(fichier.Name); }
                }
                cbxFichiers.SelectedIndex = cbxFichiers.FindStringExact(fndb.currentDatabase());
            }
            #endregion

            #region gestion Events
            private void btnAnnuler_Click(object sender, EventArgs e){
                this.Close();
            }

            private void btnOk_Click(object sender, EventArgs e)
            {
                FunctionDatabaseFile fndb = new FunctionDatabaseFile();
                fndb.saveSelectedDatabase(cbxFichiers.Text);
                this.activateRefresh();
                this.Close();
            }
        #endregion
    }
}

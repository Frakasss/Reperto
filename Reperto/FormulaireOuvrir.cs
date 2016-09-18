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
        #endregion

        #region contructeurs
            public FormulaireOuvrir()
            {
                InitializeComponent();
                InitializeComboBox();
            }
        #endregion

        private void InitializeComboBox(){
            DirectoryInfo dir = new DirectoryInfo(gfctn.AppRootPath() + "MyDB/");
            FileInfo[] fichiers = dir.GetFiles();

            foreach (FileInfo fichier in fichiers)
            {
                if (fichier.Name != "AppConfig.xml")
                {
                    string myExtension = fichier.Name.Substring(fichier.Name.Length - 4);
                    if(myExtension.ToLower() == ".xml"){
                        cbxFichiers.Items.Add(fichier.Name);
                    }
                }
            }
            cbxFichiers.SelectedIndex = cbxFichiers.FindStringExact(fndb.currentDatabase());
        }

        private void btnAnnuler_Click(object sender, EventArgs e){
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            FunctionDatabaseFile fndb = new FunctionDatabaseFile();
            fndb.saveSelectedFile(cbxFichiers.Text);
            this.Close();
        }
    }
}

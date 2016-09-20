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
    public partial class FormulaireSelectAnnuaire : Form
    {
        #region global var
        GlobalFunctions gfctn = new GlobalFunctions();
        FunctionDatabaseFile fndb = new FunctionDatabaseFile();
        public delegate void ChildEvent2();
        public event ChildEvent2 activateRefresh;
        #endregion

        #region constructeur
        public FormulaireSelectAnnuaire()
        {
            InitializeComponent();
            InitializeCombobox();
        }
        #endregion

        #region fonctions
        private void InitializeCombobox()
        {
            DirectoryInfo dir = new DirectoryInfo(gfctn.AppRootPath() + "Reperto/Annuaires/");
            FileInfo[] fichiers = dir.GetFiles();

            foreach (FileInfo fichier in fichiers)
            {
                string myExtension = fichier.Name.Substring(fichier.Name.Length - 4);
                if (myExtension.ToLower() == ".xml") { cbxAnnuaires.Items.Add(fichier.Name); }
            }
            cbxAnnuaires.SelectedIndex = cbxAnnuaires.FindStringExact(fndb.currentAnnuaire());
        }
        #endregion

        #region gestion event
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void btnOk_Click(object sender, EventArgs e)
        {
            FunctionDatabaseFile fndb = new FunctionDatabaseFile();
            fndb.saveSelectedAnnuaire(cbxAnnuaires.Text);
            this.activateRefresh();
            this.Close();
        }
    }
}

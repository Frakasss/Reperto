using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reperto
{
    public partial class FormulaireTheme : Form
    {
        #region Variables Globales
        FunctionFiches fctn = new FunctionFiches();
        FunctionThemes tfctn = new FunctionThemes();
        GlobalFunctions gfctn = new GlobalFunctions();
        #endregion

        #region Initialisation fenêtre
        public FormulaireTheme()
        {
            InitializeComponent();
            InitializeThemeComboBox();
        }

        public void InitializeThemeComboBox()
        {
            this.cbxListThemesModif.Items.Clear();
            this.cbxListThemesSupp.Items.Clear();
            foreach (string item in tfctn.fnSelectThemes())
            {
                this.cbxListThemesModif.Items.Add(item);
                this.cbxListThemesSupp.Items.Add(item);
            }
            this.cbxListThemesModif.SelectedIndex = 0;
            this.cbxListThemesSupp.SelectedIndex = 0;
        }
        #endregion

        #region Gestion des Evenements
        /// <summary>
        /// Bouton Créer Theme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
            private void btnCreationTheme_Click(object sender, EventArgs e)
            {
                if (this.txtCreationTheme.Text != "")
                {
                    tfctn.fnCreationTheme(this.txtCreationTheme.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Veuillez saisir un Nom de Thème.");
                }
            }

        /// <summary>
        /// Bouton Modifier Theme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
            private void btnModifierTheme_Click(object sender, EventArgs e)
            {
                if (this.cbxListThemesModif.Text != "")
                {
                    //verifier que le nouveau theme n'est pas vide
                    if (txtModificationTheme.Text != "")
                    {
                        //verifier que le nouveau theme n'existe pas deja
                        if (tfctn.fnSelectCount(txtModificationTheme.Text) == 0)
                        {
                            tfctn.fnModificationTheme(this.cbxListThemesModif.Text, txtModificationTheme.Text);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Veuillez saisir un autre nom: celui-ci existe déjà.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Veuillez saisir un nouveau nom pour ce Thème");
                    }
                    
                }
                else 
                {
                    MessageBox.Show("Veuillez sélectionner un Thème à modifier.");
                }

            }

        /// <summary>
        /// Bouton Supprimer Theme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
            private void btnSupprimerTheme_Click(object sender, EventArgs e)
            {
                if (this.cbxListThemesModif.Text != "")
                {
                    tfctn.fnSuppressionTheme(this.cbxListThemesModif.Text);
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("Veuillez sélectionner un Thème à supprimer.");
                }
            }
            

        #endregion


    }
}

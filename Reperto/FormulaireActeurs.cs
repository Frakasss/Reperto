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
    public partial class FormulaireActeurs : Form
    {
        #region Global var
        public delegate void ChildEvent(string text);
        public event ChildEvent returnActors;
        FunctionAnnuaire fnAnn = new FunctionAnnuaire();
        #endregion

        #region Constructeurs
            public FormulaireActeurs(){
                InitializeComponent();
            }

            public FormulaireActeurs(string currentListOfActors)
            {
                InitializeComponent();
                InitializeDgv(this.txtNom.Text, this.txtPrenom.Text, this.txtRelation.Text);
                txtActors.Text = currentListOfActors;
            }
        #endregion

        #region Gestion Events
            // bouton clear pour vider le textbox
            private void btnClear_Click(object sender, EventArgs e)
            {
                this.txtActors.Text = "";
            }

            // bouton annuler
            private void btnAnnuler_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            // bouton retour liste des acteurs
            private void btnOk_Click(object sender, EventArgs e)
            {
                this.returnActors(txtActors.Text);
                this.Close();
            }

            // bouton ajouter
            private void btnAjouter_Click(object sender, EventArgs e)
            {
                int selectedRowCount = dgvAnnuaire.Rows.GetRowCount(DataGridViewElementStates.Selected);
                string nameList = txtActors.Text;
                if (selectedRowCount > 0)
                {
                    for (int i = 0; i < selectedRowCount; i++)
                    {
                        DataGridViewRow selectedRow = dgvAnnuaire.Rows[i];
                        if (nameList != "") { nameList = nameList + ", "; }
                        nameList = nameList + Convert.ToString(selectedRow.Cells["colNom"].Value) + " " + Convert.ToString(selectedRow.Cells["colPrenom"].Value);
                    }

                    txtActors.Text = nameList;
                }
            }

            // bouton filtrer
            private void btnFilter_Click(object sender, EventArgs e)
            {
                InitializeDgv(txtNom.Text, txtPrenom.Text, txtRelation.Text);
            }

            // double clic
            private void dgvAnnuaire_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                string nameList = txtActors.Text;
                if (nameList != "") { nameList = nameList + ", "; }
                int selectedrowindex = dgvAnnuaire.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvAnnuaire.Rows[selectedrowindex];
                txtActors.Text = nameList + Convert.ToString(selectedRow.Cells["colNom"].Value) + " " + Convert.ToString(selectedRow.Cells["colPrenom"].Value);
            }

            // chargement annuaire
            private void chargerAnnuaireToolStripMenuItem_Click(object sender, EventArgs e)
            {
                FormulaireSelectAnnuaire formSelectAnnuaire = new FormulaireSelectAnnuaire();
                formSelectAnnuaire.activateRefresh += new FormulaireSelectAnnuaire.ChildEvent2(activateRefresh);
                formSelectAnnuaire.Show();
            }
        #endregion

        #region fonctions
            private void activateRefresh() { InitializeDgv(this.txtNom.Text, this.txtPrenom.Text, this.txtRelation.Text); }

            private void InitializeDgv(string nom, string prenom, string relation)
            {
                foreach(Annuaire item in fnAnn.fnSelectionAnnuaire(nom, prenom, relation)){
                    dgvAnnuaire.Rows.Add(item.Nom, item.Prenom, item.Relation);
                }
            }
        #endregion









    }
}

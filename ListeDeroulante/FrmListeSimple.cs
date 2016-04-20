using System.Windows.Forms;
using System.Collections.Generic;

namespace ListeDeroulante
{
    public partial class FrmListSimple : Form
    {
        /// <summary>
        /// Liste contenant les noms à afficher au lancement du programme
        /// </summary>
        private string[] noms = new string[] { "Marie", "Jean", "Pierre", "Julien", "François", "Hélène" };

        public FrmListSimple()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Charge les noms dans la liste au lancement du programme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmListSimple_Load(object sender, System.EventArgs e)
        {
            List<string> noms = new List<string>(this.noms);
            
            foreach (string nom in noms)
            {
                LstItems.Items.Add(nom);
            }

            // Place le focus à l'ouverture du programme
            this.ActiveControl = TxtSaisie;

        }

        /// <summary>
        /// Ajoute un élement à la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtSaisie.Text) && string.IsNullOrWhiteSpace(TxtSaisie.Text))
            {
                MessageBox.Show("Rien à ajouter dans la liste");
            } else
            {
                LstItems.Items.Add(TxtSaisie.Text);
                TxtSaisie.Clear();
                TxtSaisie.Focus();
            }
        }

        /// <summary>
        /// Permet de prendre en charge l'utilisation de enter pour entrer un élement dans la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtSaisie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter & !string.IsNullOrWhiteSpace(TxtSaisie.Text))
            {
                btnAjouter_Click(this, new System.EventArgs());
                TxtSaisie.Clear();
            }
        }

        /// <summary>
        /// Permet de verouiller la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkBoxVerrouiller_CheckStateChanged(object sender, System.EventArgs e)
        {
            if (chkBoxVerrouiller.CheckState == CheckState.Checked)
            {
                LstItems.ClearSelected();
                LstItems.Enabled = false;
            } else if (chkBoxVerrouiller.CheckState == CheckState.Unchecked)
            {
                LstItems.ClearSelected();
                LstItems.Enabled = true;
            }
        }

        private void rdBtnChanged(object sender, System.EventArgs e)
        {
            if (rdBtnSimple.Checked)
            {
                LstItems.ClearSelected();
                LstItems.SelectionMode = SelectionMode.One;
            } else if (rdBtnMultiple.Checked)
            {
                LstItems.ClearSelected();
                LstItems.SelectionMode = SelectionMode.MultiSimple;
            } else if (rdBtnEtendue.Checked)
            {
                LstItems.ClearSelected();
                LstItems.SelectionMode = SelectionMode.MultiExtended;
            }
        }

        private void btnSuppSelection_Click(object sender, System.EventArgs e)
        {
            while(LstItems.SelectedItems.Count > 0)
            {
                LstItems.Items.RemoveAt(LstItems.SelectedIndex);
            }
        }

        private void btnAfficheSelection_Click(object sender, System.EventArgs e)
        {
            string message = "";

            foreach (string item in LstItems.SelectedItems)
            {
                message += item.ToString() + "\n";
            }

            MessageBox.Show("Element sélectionné : \n" + message);
        }

        private void LstItems_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (LstItems.SelectedItems.Count > 0)
            {
                btnAfficheSelection.Enabled = true;
                btnSuppSelection.Enabled = true;
            } else
            {
                btnAfficheSelection.Enabled = false;
                btnSuppSelection.Enabled = false;
            }
        }
        private void TxtSaisie_TextChanged(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtSaisie.Text))
            {
                btnAjouter.Enabled = true;
            }
            else
            {
                btnAjouter.Enabled = false;
            }
        }
    }
}

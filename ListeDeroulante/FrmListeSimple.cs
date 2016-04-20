using System.Windows.Forms;
using System.Collections.Generic;

namespace ListeDeroulante
{
    public partial class FrmListSimple : Form
    {
        private string[] noms = new string[] { "Marie", "Jean", "Pierre", "Julien", "François", "Hélène" };

        public FrmListSimple()
        {
            InitializeComponent();
        }

        private void FrmListSimple_Load(object sender, System.EventArgs e)
        {
            List<string> noms = new List<string>(this.noms);
            
            foreach (string nom in noms)
            {
                LstItems.Items.Add(nom);
            }
        }

        private void btnAjouter_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtSaisie.Text))
            {
                MessageBox.Show("Rien à ajouter dans la liste");
            }
        }
    }
}

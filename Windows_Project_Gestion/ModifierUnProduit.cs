using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Project_GestionPAGE1
{
    public partial class ModifierUnProduit : Form
    {
        public ModifierUnProduit()
        {
            InitializeComponent();
        }

        private void ModifierUnProduit_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'franprix_gestionDataSet.Produit'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.produitTableAdapter.Fill(this.franprix_gestionDataSet.Produit);

            int nb = this.franprix_gestionDataSet.Categorie.Rows.Count;

            comboBox1.Items.Clear();
            for (int i = 0; i < nb; i++)
            {
                string str = this.franprix_gestionDataSet.Categorie.Rows[i].ItemArray[1].ToString();
                comboBox1.Items.Add(str);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            produitBindingSource.Filter = "Categorie = " + (comboBox1.SelectedIndex + 1);
        }
    }
}

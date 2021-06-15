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
            // TODO: cette ligne de code charge les données dans la table 'franprix_gestionDataSet.Categorie'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            
            
            this.categorieTableAdapter.Fill(this.franprix_gestionDataSet.Categorie);
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

        private void textBoxSearchNom_TextChanged(object sender, EventArgs e)
        {
            produitBindingSource.Filter = "Nom like '" + textBoxSearchNom.Text + "%'";
        }

        private void textBoxSearchMarque_TextChanged(object sender, EventArgs e)
        {
            produitBindingSource.Filter = "Marque like '" + textBoxSearchMarque.Text + "%'";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewproduitpourmodifierunproduit_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow rowselect = dataGridViewproduitpourmodifierunproduit.SelectedRows[0];
            int idrech = Convert.ToInt32(rowselect.Cells[2].Value);
            Franprix_gestionDataSet.ProduitRow p = franprix_gestionDataSet.Produit.FindByID(idrech);

            textNom.Text = Convert.ToString(p.Nom);
            textMarque.Text = Convert.ToString(p.Marque);
            textPoids.Text = Convert.ToString(p.Poids);
            //textVolume.Text = Convert.ToString(p.Volume);
            //textTaille.Text = Convert.ToString(p.Taille);
            textStockcourant.Text = Convert.ToString(p.Stock_courant);
            textPrixht.Text = Convert.ToString(p.PrixHT);
            richTextBoxPresentation.Text = Convert.ToString(p.Presentation);
            textStockcourant.Text = Convert.ToString(p.Stock_courant);
            textStockmini.Text = Convert.ToString(p.Stock_minimum);
            
            
        }

        private void MODIFIER_CLICK(object sender, EventArgs e)
        {
            if (dataGridViewproduitpourmodifierunproduit.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une ligne !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            DataGridViewRow rowselect = dataGridViewproduitpourmodifierunproduit.SelectedRows[0];
            int idrech = Convert.ToInt32(rowselect.Cells[2].Value);
            Franprix_gestionDataSet.ProduitRow p = franprix_gestionDataSet.Produit.FindByID(idrech);
            p.BeginEdit();
            p.Nom = Convert.ToString(textNom.Text);
            p.Marque = Convert.ToString(textMarque.Text);
            p.Poids = Convert.ToInt32(textPoids.Text);
            p.Stock_courant = Convert.ToInt32(textStockcourant.Text);
            p.PrixHT = Convert.ToDecimal(textPrixht.Text);
            p.Presentation = Convert.ToString(richTextBoxPresentation.Text);
            p.Stock_courant = Convert.ToInt32(textStockcourant.Text);
            p.Stock_minimum = Convert.ToInt32(textStockmini.Text);
            p.EndEdit();
            franprix_gestionDataSet.Produit.AcceptChanges();


        }
    }
}

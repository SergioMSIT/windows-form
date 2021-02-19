using System;
using System.Windows.Forms;

namespace Windows_Project_GestionPAGE1
{
    public partial class gestionstock : Form
    {
        public gestionstock()
        {
            InitializeComponent();
        }

        private void gestionstock_Load(object sender, EventArgs e)
        {
            // les 2 tableux des produits 

            // TODO: cette ligne de code charge les données dans la table 'franprix_gestionDataSet.Produit'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.produitTableAdapter.Fill(this.franprix_gestionDataSet.Produit);
            // TODO: cette ligne de code charge les données dans la table 'franprix_gestionDataSet.Categorie'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.categorieTableAdapter.Fill(this.franprix_gestionDataSet.Categorie);
            int nb = this.franprix_gestionDataSet.Categorie.Rows.Count;


            // parti modifier la quantite

            






























            //la data du selecte 
            comboBoxcategorie.Items.Clear();
            for (int i = 0; i < nb; i++)
            {
                string str = this.franprix_gestionDataSet.Categorie.Rows[i].ItemArray[1].ToString();
                comboBoxcategorie.Items.Add(str);
            }





        }
        // bouton  deconnexion / addproduit/modifier 
        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProduct addprod = new AddProduct();
            addprod.ShowDialog();
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            ModifierUnProduit update  = new ModifierUnProduit();
            update.ShowDialog();
        }
        //tout les filtre / recherche produit 
        private void comboBoxcategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            produitBindingSource.Filter = "Categorie = " + (comboBoxcategorie.SelectedIndex + 1);
        }
       

        private void textBoxSearchnom_TextChanged(object sender, EventArgs e)
        {
            produitBindingSource.Filter = "Nom like '" + textBoxSearch.Text + "%'";
        }

        private void textBoxSearchmarque_TextChanged(object sender, EventArgs e)
        {
            produitBindingSource.Filter = "Marque like '" + textBoxSearch2.Text + "%'";
        }

        private void dataGridViewproduit2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridViewproduit2.Rows[index];
            quantiteactuel.Text = selectedRow.Cells[1].Value.ToString();
            quantitemini.Text = selectedRow.Cells[2].Value.ToString();


        }
    }
}


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
        
        
        // parti modifier la quantite
        private void buttonajoutquantite_Click(object sender, EventArgs e)
        {
            if (dataGridViewproduitShort.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une ligne !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            DataGridViewRow rowselect = dataGridViewproduitShort.SelectedRows[0];
            int idrech = Convert.ToInt32(rowselect.Cells[3].Value);
            Franprix_gestionDataSet.ProduitRow p =franprix_gestionDataSet.Produit.FindByID(idrech);
            p.BeginEdit();            
            p.Stock_minimum = Convert.ToInt32(TextBoxQuantitemini.Text);
            p.Stock_courant = Convert.ToInt32(TextBoxQuantiteactuel.Text);
            p.EndEdit();
            franprix_gestionDataSet.Produit.AcceptChanges();


        }
        private void dataGridViewproduitShort_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow rowselect = dataGridViewproduitShort.SelectedRows[0];
            int idrech = Convert.ToInt32(rowselect.Cells[3].Value);
            Franprix_gestionDataSet.ProduitRow p = franprix_gestionDataSet.Produit.FindByID(idrech);

            TextBoxQuantiteactuel.Text = Convert.ToString(p.Stock_courant);
            TextBoxQuantitemini.Text = Convert.ToString(p.Stock_minimum);
        }
        //les bouton du "navbarre" en haut 
        private void deconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }   
        private void ajouterUnProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct addprod = new AddProduct();
            addprod.ShowDialog();
        }

        private void modifierUnProduitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}


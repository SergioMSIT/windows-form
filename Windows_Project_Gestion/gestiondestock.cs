using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Windows_Project_GestionPAGE1
{
    public partial class gestionstock : Form
    {
        public gestionstock()
        {
            InitializeComponent();
        }

        public string cs = @"Server = .\SQLEXPRESS; Database = Franprix_gestion; Trusted_Connection = True;";

        private void gestionstock_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'franprix_gestionDataSet.Produit'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.produitTableAdapter.Fill(this.franprix_gestionDataSet.Produit);
            // TODO: cette ligne de code charge les données dans la table 'franprix_gestionDataSet.Categorie'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.categorieTableAdapter.Fill(this.franprix_gestionDataSet.Categorie);
            int nb = this.franprix_gestionDataSet.Categorie.Rows.Count;

            comboBoxcategorie.Items.Clear();
            for (int i = 0; i < nb; i++)
            {
                string str = this.franprix_gestionDataSet.Categorie.Rows[i].ItemArray[1].ToString();
                comboBoxcategorie.Items.Add(str);
            }
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProduct addprod = new AddProduct();
            addprod.ShowDialog();
           
        }

        

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
    }
}


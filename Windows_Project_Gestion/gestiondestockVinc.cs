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

        
  

        private void btnsavebase_Click(object sender, EventArgs e)
        {
            this.produitTableAdapter.Update(this.franprix_gestionDataSet.Produit);
        }

   
        
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (textNom.Text == "")
            {
                textNom.Focus();
                MessageBox.Show("Veuillez indiquer le nom du produit !");
                return;
            }
            if (textMarque.Text == "")
            {
                textMarque.Focus();
                MessageBox.Show("Veuillez indiquer la marque du produit !");
                return;
            }
            if (textPrixht.Text == "")
            {
                textPrixht.Focus();
                MessageBox.Show("Veuillez indiquer le prix du produit !");
                return;
            }
            if (textPrixht.Text == "")
            {
                textPrixht.Focus();
                MessageBox.Show("Veuillez indiquer le prix du produit !");
                return;
            }
            if (textPrixht.Text == "")
            {
                textPrixht.Focus();
                MessageBox.Show("Veuillez indiquer le prix du produit !");
                return;
            }
            if (comboBoxTVA.Text == "")
            {
                comboBoxTVA.Focus();
                MessageBox.Show("Veuillez indiquer la TVA !");
                return;
            }
            if (comboBox1.Text == "")
            {
                comboBox1.Focus();
                MessageBox.Show("Veuillez indiquer la catégorie du produit !");
                return;
            }
            if (textStockmax.Text == "")
            {
                textStockmax.Focus();
                MessageBox.Show("Veuillez indiquer le stock maximum !");
                return;
            }
            if (textStockcourant.Text == "")
            {
                textStockcourant.Focus();
                MessageBox.Show("Veuillez indiquer le stock recommandé !");
                return;
            }
            if (textStockmini.Text == "")
            {
                textStockmini.Focus();
                MessageBox.Show("Veuillez indiquer le stock minimum !");
                return;
            }


            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string poids = textPoids.Text == "" ? "NULL" : textPoids.Text;
            string volume = textVolume.Text == "" ? "NULL" : textVolume.Text;
            string taille = textTaille.Text == "" ? "NULL" : textTaille.Text;
            string presentation = richTextBoxPresentation.Text == "" ? "NULL" : richTextBoxPresentation.Text;
            string nutriscore = comboBoxNutriscore.Text == "" ? "NULL" : comboBoxNutriscore.Text;

            string q = "INSERT INTO Produit(Nom,Marque,Poids,Volume,Taille,PrixHT,TVA,Categorie,Nutriscore,Stock_max,Stock_courant," +
                    "Stock_minimum,Presentation)" +
                    " VALUES ('" + textNom.Text.ToString() + "','" + textMarque.Text.ToString() + "'," + poids + ", "
                    + volume + ", " + taille + "," + textPrixht.Text.ToString() + ", " +
                    comboBoxTVA.Text.ToString() + "," + Convert.ToInt32(comboBox1.SelectedValue).ToString() + ",'" +
                    nutriscore + "'," + textStockmax.Text.ToString() + "," + textStockcourant.Text.ToString()
                    + "," + textStockmini.Text.ToString() + ",'" + presentation + "')";
            SqlCommand cmd = new SqlCommand(q, con);
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                MessageBox.Show("Produit ajouté");
            }

            


        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            produitBindingSource.Filter = "Nom like '" + textBoxSearch.Text + "%'";
        }

        

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            produitBindingSource.Filter = "Marque like '" + textBoxSearch2.Text + "%'";
        }
    }
}


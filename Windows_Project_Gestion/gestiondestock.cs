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
            // TODO: cette ligne de code charge les données dans la table 'franprix_gestionDataSet.Categorie'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.categorieTableAdapter.Fill(this.franprix_gestionDataSet.Categorie);

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


    }
}


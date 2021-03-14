using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Windows_Project_GestionPAGE1
{
    public partial class connexion : Form
    {
        public string cs = @"Server = .\SQLEXPRESS; Database = Franprix_gestion; Trusted_Connection = True;";

        public connexion()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Please enter user name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            if (txtMDP.Text == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMDP.Focus();
                return;
            }
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(cs);

                SqlCommand myCommand = default(SqlCommand);

                myCommand = new SqlCommand("SELECT email,password FROM Connexion WHERE email = @email AND password = @password", myConnection);

                SqlParameter uName = new SqlParameter("@email", SqlDbType.VarChar);
                SqlParameter uPassword = new SqlParameter("@password", SqlDbType.VarChar);

                uName.Value = txtEmail.Text;
                uPassword.Value = txtMDP.Text;

                myCommand.Parameters.Add(uName);
                myCommand.Parameters.Add(uPassword);

                myCommand.Connection.Open();

                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                if (myReader.Read() == true)
                {
                    MessageBox.Show("You have logged in successfully ");
                    //Hide the login form
                    this.Hide();
                    gestionstock next = new gestionstock();
                    next.Show();

                }


                else
                {
                    MessageBox.Show("Login Failed...Try again !", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtEmail.Clear();
                    txtMDP.Clear();
                    txtEmail.Focus();

                }
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}

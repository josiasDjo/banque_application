using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace banque_application.disign
{
    public partial class depot : UserControl
    {
        public string nom;
        public string prenom;
        public string adresse;
        public string phone;
        public decimal solde;
        public string devise; 
        public depot()
        {
            InitializeComponent();
        }

        private void btnValiderCredit_Click(object sender, EventArgs e)
        {

        }
        public void getData()
        {
            nom = txtNom.Text;
            prenom = txtPrenom.Text;
            adresse = txtAdresse.Text;
            phone = txtPhone.Text;
            solde = decimal.Parse(txtMontantDepot.Text);
            devise = txtDevise.Text;


        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {
            service_personnel sp = new service_personnel();

            nom = txtNom.Text;
            prenom = txtPrenom.Text;
            if (nom == "" && prenom=="")
            {
                MessageBox.Show("Nulle : "); 
            } else
            {
                try
                {
                    sp.OpenConnection();
                    SqlConnection connection = sp.GetConnection();
                    string req = "SELECT * FROM tClient WHERE nom=@nom && prenom=@prenom";

                    using (SqlCommand cmd = new SqlCommand(req, connection))
                    {
                        cmd.Parameters.AddWithValue("@nom", nom);
                        cmd.Parameters.AddWithValue("@prenom", prenom);

                            using (SqlDataReader rd = cmd.ExecuteReader())
                            {
                                if (rd.Read())
                                {
                                    string nomB = rd["nom"].ToString();
                                    string prenomB = rd["prenom"].ToString();
                                    MessageBox.Show("Existe : " + nomB + " " + prenomB);
                                } else
                                {
                                    MessageBox.Show(" sdjf ");
                                }
                            }                 
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show("Erreur de connexion" + ex.Message);
                } finally
                {
                    sp.CloseConnection();
                }
            }
        }
    }
}

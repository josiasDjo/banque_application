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
        public string numCompte;
        public string dateTransaction;
        public string typeTransaction;
        public string Compte_source;
        public string Compte_beneficiaire;
        public string Id_trasenction;
        public string heureTransaction;
        public string search_IdClient;
        public string id_compte;
        public depot()
        {
            InitializeComponent();
        }

        private void btnValiderCredit_Click(object sender, EventArgs e)
        {
            getData();
        }
        public void getData()
        {
            nom = txtNom.Text;
            prenom = txtPrenom.Text;
            adresse = txtAdresse.Text;
            phone = txtPhone.Text;
            solde = decimal.Parse(txtMontantDepot.Text);
            devise = txtDevise.Text;
            numCompte = txtNumCompte.Text;

            DateTime currentD = DateTime.Now;

            dateTransaction = currentD.ToString("dd-MM-yyyy");
            heureTransaction = currentD.ToString("HH:mm");
            typeTransaction = "Dépôt";
            Compte_source = "null";
            Compte_beneficiaire = "null";

            int length = 4;
            Random random = new Random();
            int minValue = (int)Math.Pow(10, length - 1);
            int maxValue = (int)Math.Pow(10, length) - 1;

            string num1 = "DP";;
            string num2 = (random.Next(minValue, maxValue + 1)).ToString();
            string num3 = (random.Next(minValue, maxValue + 1)).ToString();

            Id_trasenction = num1 + dateTransaction + "." + heureTransaction + "." + num2 + num3;

            EnregistrerTrans();
        }


        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {
           
        }

        //rechercher les informations sur le client
        private void txtAdresse_TextChanged(object sender, EventArgs e)
        {
            service_personnel sp = new service_personnel();

            nom = txtNom.Text;
            prenom = txtPrenom.Text;
            if (nom == "" && prenom == "")
            {
                MessageBox.Show("Nulle : ");
            }
            else
            {
                try
                {
                    sp.OpenConnection();
                    SqlConnection connection = sp.GetConnection();
                    string req = "SELECT * FROM tClient WHERE nom=@nom AND prenom=@prenom";
                    txtAdresse.Text = "";

                    using (SqlCommand cmd = new SqlCommand(req, connection))
                    {
                        cmd.Parameters.AddWithValue("@nom", nom);
                        cmd.Parameters.AddWithValue("@prenom", prenom);

                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.Read())
                            {
                                string idClientB = rd["id_client"].ToString();
                                string nomB = rd["nom"].ToString();
                                string prenomB = rd["prenom"].ToString();
                                txtAdresse.Text = rd["adresse"].ToString();
                                txtPhone.Text = rd["phone"].ToString();
                                search_IdClient = idClientB;
                                MessageBox.Show("Existe : " + idClientB + nomB + " " + prenomB);
                                search_compt();
                            }
                            else
                            {
                                MessageBox.Show("Compte non trouvé");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur de connexion" + ex.Message);
                }
                finally
                {
                    sp.CloseConnection();
                }
            }
        }
        //reschercher le compte client 
        public void search_compt()
        {
            service_personnel sp = new service_personnel();

            try
            {
               
                sp.OpenConnection();
                SqlConnection connection = sp.GetConnection();
                string req = "SELECT * FROM tCompte WHERE id_client=@id_client";

                using (SqlCommand cmd = new SqlCommand(req, connection))
                {
                    cmd.Parameters.AddWithValue("@id_client", search_IdClient);

                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            id_compte = rd["id_compte"].ToString();
                            numCompte = rd["num_compte"].ToString();
                            txtNumCompte.Text = numCompte;
                        }
                        else
                        {
                            MessageBox.Show("Compte non trouvé");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion search compte : " + ex.Message);
            }
            finally
            {
                sp.CloseConnection();
            }
        }
        //Rechercher le nom et prenom dans la base de données
        //public void checkCompteInfo()
        //{
        //    service_personnel sp = new service_personnel();
        //    try
        //    {
        //        sp.OpenConnection();

        //        SqlConnection connection = sp.GetConnection();

        //        string req1 = "SELECT * FROM tCompte WHERE num_compte=@num_compte";
        //        string req2 = "SELECT * FROM tCarte WHERE numero_carte=@num_carte";

        //        using (SqlCommand cmd1 = new SqlCommand(req1, connection))
        //        {
        //            cmd1.Parameters.AddWithValue("@num_compte", NumCompte);

        //            using (SqlDataReader rd = cmd1.ExecuteReader())
        //            {
        //                if (rd.HasRows)
        //                {
        //                    while (rd.Read())
        //                    {
        //                        string numCompteTest = rd["num_compte"].ToString();
        //                        numCarteProduct();
        //                    }
        //                }
        //                else
        //                {
        //                    txtNumeroCompte.Text = NumCompte;
        //                }
        //            }
        //        }

        //        using (SqlCommand cmd2 = new SqlCommand(req2, connection))
        //        {
        //            cmd2.Parameters.AddWithValue("@num_carte", NumCompte);

        //            using (SqlDataReader rd = cmd2.ExecuteReader())
        //            {
        //                if (rd.HasRows)
        //                {
        //                    while (rd.Read())
        //                    {
        //                        string numCompteTest = rd["num_carte"].ToString();
        //                        numCarteProduct();
        //                    }
        //                }
        //                else
        //                {
        //                    txtNumCarte.Text = NumeroCarte;
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Une erreur est survenue : " + ex.Message);
        //    }
        //    finally
        //    {
        //        sp.CloseConnection();
        //    }
        //}

    }
}

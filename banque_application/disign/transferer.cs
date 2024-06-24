using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using banque_application.disign;
using System.Data.SqlClient;

namespace banque_application.disign
{
    public partial class transferer : UserControl
    {
        public string nomDeb;
        public string prenomDeb;
        public string adresseDeb;
        public string phone;
        public decimal solde;
        public string devise;
        public string numCompteDeb;
        public string dateTransaction;
        public string typeTransaction;
        public string Compte_source;
        public string Compte_beneficiaire;
        public string Id_trasenction;
        public string heureTransaction;
        public string search_IdClient;
        public string id_compte;

        public string nomCre;
        public string prenomCre;
        public string numCompteCre;
        public string numCompte_benef;
        public string id_compte_benef;
        public string search_IdClient_benef;

        public transferer()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {

        }

        private void btnValiderTransfere_Click(object sender, EventArgs e)
        {
            GetDataTransfert();
        }

        //récupérer les données 
        private void GetDataTransfert()
        {
            nomDeb = txtNomDeb.Text;
            prenomDeb = txtPrenomDeb.Text;
            adresseDeb = txtAdresseDeb.Text;
            phone = txtPhoneDeb.Text;
            solde = decimal.Parse(txtMontant.Text);
            devise = txtDevise.Text;
            numCompteDeb = txtNumCompteDeb.Text;

            DateTime currentD = DateTime.Now;

            dateTransaction = currentD.ToString("dd-MM-yyyy");
            heureTransaction = currentD.ToString("HH:mm");
            typeTransaction = "Transfère";
            Compte_source = numCompteDeb;
            Compte_beneficiaire = numCompte_benef;

            int length = 4;
            Random random = new Random();
            int minValue = (int)Math.Pow(10, length - 1);
            int maxValue = (int)Math.Pow(10, length) - 1;

            string num1 = "TF";
            string num2 = (random.Next(minValue, maxValue + 1)).ToString();
            string num3 = (random.Next(minValue, maxValue + 1)).ToString();

            Id_trasenction = num1 + dateTransaction + "." + heureTransaction + "." + num2 + num3;

            EnregistrerTrans();
        }

        //recherche infos client
        private void txtAdresseDeb_TextChanged(object sender, EventArgs e)
        {
            service_personnel sp = new service_personnel();

            nomDeb = txtNomDeb.Text;
            prenomDeb = txtPrenomDeb.Text;
            if (nomDeb == "" && prenomDeb == "")
            {
                MessageBox.Show("Veillez remplir le nom et le prenom du compte à débiter pour continuer");
            }
            else
            {
                try
                {

                    sp.OpenConnection();
                    SqlConnection connection = sp.GetConnection();
                    string req = "SELECT * FROM tClient WHERE nom=@nom AND prenom=@prenom";

                    using (SqlCommand cmd = new SqlCommand(req, connection))
                    {
                        cmd.Parameters.AddWithValue("@nom", nomDeb);
                        cmd.Parameters.AddWithValue("@prenom", prenomDeb);

                        txtAdresseDeb.Text = "";
                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.Read())
                            {
                                string idClientB = rd["id_client"].ToString();
                                string nomB = rd["nom"].ToString();
                                string prenomB = rd["prenom"].ToString();
                                txtAdresseDeb.Text = rd["adresse"].ToString();
                                txtPhoneDeb.Text = rd["phone"].ToString();
                                search_IdClient = idClientB;
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

        //recherche du compte client
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
                            numCompteDeb = rd["num_compte"].ToString();
                            txtNumCompteDeb.Text = numCompteDeb;
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

        //rechercher le compte bénéficiaire
        private void txtNumCompteCre_TextChanged(object sender, EventArgs e)
        {
            service_personnel sp = new service_personnel();

            nomCre = txtNomDeb.Text;
            prenomCre = txtPrenomDeb.Text;
            if (nomDeb == "" && prenomDeb == "")
            {
                MessageBox.Show("Veillez remplir le nom et le prenom du compte à débiter pour continuer");
            }
            else
            {
                try
                {

                    sp.OpenConnection();
                    SqlConnection connection = sp.GetConnection();
                    string req = "SELECT * FROM tClient WHERE nom=@nom AND prenom=@prenom";

                    using (SqlCommand cmd = new SqlCommand(req, connection))
                    {
                        cmd.Parameters.AddWithValue("@nom", nomCre);
                        cmd.Parameters.AddWithValue("@prenom", prenomCre);

                        txtNumCompteCre.Text = "";
                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.Read())
                            {
                                string idClientB = rd["id_client"].ToString();
                                string nomB = rd["nom"].ToString();
                                string prenomB = rd["prenom"].ToString();
                                txtAdresseDeb.Text = rd["adresse"].ToString();
                                txtPhoneDeb.Text = rd["phone"].ToString();
                                search_IdClient_benef = idClientB;
                                search_compt_Benef();
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

        public void search_compt_Benef()
        {
            service_personnel sp = new service_personnel();

            try
            {

                sp.OpenConnection();
                SqlConnection connection = sp.GetConnection();
                string req = "SELECT * FROM tCompte WHERE id_client=@id_client";

                using (SqlCommand cmd = new SqlCommand(req, connection))
                {
                    cmd.Parameters.AddWithValue("@id_client", search_IdClient_benef);

                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            id_compte_benef = rd["id_compte"].ToString();
                            numCompte_benef = rd["num_compte"].ToString();
                            txtNumCompteCre.Text = numCompte_benef;
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
        public void EnregistrerTrans()
        {
            service_personnel sp = new service_personnel();
            try
            {
                sp.OpenConnection();
                using (SqlConnection con = sp.GetConnection())
                {
                    string req = "INSERT INTO tTransaction (id_transaction,date_transaction,montant,type_transanction,compte_source,compte_beneficiaire,id_compte) values (@i,@date,@montant,@type,@source,@ben,@id_compte)";
                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {
                        cmd.Parameters.AddWithValue("@i", Id_trasenction);
                        cmd.Parameters.AddWithValue("@date", dateTransaction);
                        cmd.Parameters.AddWithValue("@montant", solde);
                        cmd.Parameters.AddWithValue("@type", typeTransaction);
                        cmd.Parameters.AddWithValue("@source", Compte_source);
                        cmd.Parameters.AddWithValue("@ben", Compte_beneficiaire);
                        cmd.Parameters.AddWithValue("@id_compte", id_compte);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Transaction  effectué avec succes");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("La transaction a échouée " + ex.Message);
            }
            finally
            {
                sp.CloseConnection();

                //nettoyage des input
                txtNomDeb.Text = "";
                txtPrenomDeb.Text = "";
                txtAdresseDeb.Text = "";
                txtPhoneDeb.Text = "";
                txtNumCompteDeb.Text = "";
                txtMontant.Text = "";
                txtNomCre.Text = "";
                txtPrenomCre.Text = "";
                txtNumCompteCre.Text = "";

            }
        }
    }
}

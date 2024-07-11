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
    public partial class retrait : UserControl
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
        public decimal soldeCompteFinal;
        public decimal soldeCompteInit;
        public retrait()
        {
            InitializeComponent();
        }

        private void retrait_Load(object sender, EventArgs e)
        {

        }
        public void getDataRetrait()
        {
            solde = decimal.Parse(txtMontantRetrait.Text);

            if (soldeCompteInit > solde)
            {
                nom = txtNom.Text;
                prenom = txtPrenom.Text;
                adresse = txtAdresse.Text;
                phone = txtPhone.Text;
                devise = txtDevise.Text;
                numCompte = txtNumCompte.Text;
                soldeCompteFinal = soldeCompteInit - solde;
                DateTime currentD = DateTime.Now;

                dateTransaction = currentD.ToString("dd-MM-yyyy");
                heureTransaction = currentD.ToString("HH:mm");
                typeTransaction = "Retrait";
                Compte_beneficiaire = "null";

                int length = 4;
                Random random = new Random();
                int minValue = (int)Math.Pow(10, length - 1);
                int maxValue = (int)Math.Pow(10, length) - 1;

                string num1 = "RT";
                string num2 = (random.Next(minValue, maxValue + 1)).ToString();
                string num3 = (random.Next(minValue, maxValue + 1)).ToString();

                Id_trasenction = num1 + dateTransaction + "." + heureTransaction + "." + num2 + num3;

                EnregistrerTrans();
            } else
            {
                decimal montantRetraitValable = soldeCompteInit - 15m;
                MessageBox.Show("Montant insuffisant pour effectuer ce retrait !! Montant Valable : " + montantRetraitValable);
            }
            
        }

        //récupération des infos users
        private void txtAdresse_TextChanged(object sender, EventArgs e)
        {
            service_personnel sp = new service_personnel();
            nom = txtNom.Text;
            prenom = txtPrenom.Text;
            if (nom == "" && prenom == "")
            {
                MessageBox.Show("Veillez remplir le nom et le prenom pour continuer");
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

        private void btnValiderCredit_Click(object sender, EventArgs e)
        {
            getDataRetrait();
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
                            numCompte = rd["num_compte"].ToString();
                            soldeCompteInit = decimal.Parse(rd["solde_compte"].ToString());
                            txtNumCompte.Text = numCompte;
                            Compte_source = numCompte;
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

                        //nettoyage des input
                        txtNom.Text = "";
                        txtPrenom.Text = "";
                        txtAdresse.Text = "";
                        txtPhone.Text = "";
                        txtNumCompte.Text = "";
                        txtMontantRetrait.Text = "";
                        sp.CloseConnection();
                        soldeCompteChange();
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
            }
        }

        public void soldeCompteChange()
        {
            etatDeSorti etSorti = new etatDeSorti();
            service_personnel sp = new service_personnel();
            try
            {
                sp.OpenConnection();
                using (SqlConnection con = sp.GetConnection())
                {
                    string req = "UPDATE  tCompte set solde_compte=@soldeCompte  where id_compte=@i";
                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {
                        cmd.Parameters.AddWithValue("@i", id_compte);
                        cmd.Parameters.AddWithValue("@soldeCompte", soldeCompteFinal);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                etSorti.nomEtat = nom;
                etSorti.prenomEtat = prenom;
                etSorti.montantEtat = solde;
                etSorti.dateToDayEtat = dateTransaction;
                etSorti.idTransactionEtat = Id_trasenction;
                etSorti.adresseEtat = adresse;
                etSorti.phoneEtat = phone;
                etSorti.typeTransEtat = typeTransaction;

                etSorti.Main();

                etSorti.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("La transaction a échouée " + ex.Message);
            }
            finally
            {
                sp.CloseConnection();
            }
        }
    }
}

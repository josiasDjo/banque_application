using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace banque_application.disign
{
    public partial class payementPret
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
        public string dateDebut;
        public string dateFin;
        private int dureeCredit;
        decimal montantTotal;
        private decimal montant_restant;

        //rechercher pret
        private string id_pret;
        private decimal montant_restant_bd;
        public void getDataRetrait()
        {
            nom = txtNom.Text;
            prenom = txtPrenom.Text;
            adresse = txtAdresse.Text;
            phone = txtPhone.Text;
            solde = decimal.Parse(txtMontantCredit.Text);
            devise = txtDevise.Text;
            numCompte = txtNumCompte.Text;

            DateTime currentD = DateTime.Now;


            dateTransaction = currentD.ToString("dd-MM-yyyy");
            heureTransaction = currentD.ToString("HH:mm");
            typeTransaction = "Crédit";
            Compte_source = "null";
            Compte_beneficiaire = "null";

            int length = 4;
            Random random = new Random();
            int minValue = (int)Math.Pow(10, length - 1);
            int maxValue = (int)Math.Pow(10, length) - 1;

            string num1 = "PAYE";
            string num2 = (random.Next(minValue, maxValue + 1)).ToString();
            string num3 = (random.Next(minValue, maxValue + 1)).ToString();

            Id_trasenction = num1 + dateTransaction + "." + heureTransaction + "." + num2 + num3;

            check_Montant_Restant();
        }

        //rechercher les infos du client
        public void txtChangeAdresse()
        {
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
                                search_IdClient = rd["id_client"].ToString();
                                string nomB = rd["nom"].ToString();
                                string prenomB = rd["prenom"].ToString();
                                txtAdresse.Text = rd["adresse"].ToString();
                                txtPhone.Text = rd["phone"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Compte non trouvé");
                            }
                            
                        }
                        cmd.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur de connexion" + ex.Message);
                }
                finally
                {
                    sp.CloseConnection();
                    search_compt();
                }
            }
        }

        //rechercher le compte du client
        public void search_compt()
        {
            try
            {
                sp.OpenConnection();
                SqlConnection connection = sp.GetConnection();
                string req = "SELECT * FROM tCompte WHERE id_client=@id_client";

                using (SqlCommand cmdCm = new SqlCommand(req, connection))
                {
                    cmdCm.Parameters.AddWithValue("@id_client", search_IdClient);

                    using (SqlDataReader rdDtS = cmdCm.ExecuteReader())
                    {
                        if (rdDtS.Read())
                        {
                            id_compte = rdDtS["id_compte"].ToString();
                            numCompte = rdDtS["num_compte"].ToString();
                            txtNumCompte.Text = numCompte;

                            
                        }
                        else
                        {
                            MessageBox.Show("Compte non trouvé");
                        }
                        rdDtS.Close();
                        cmdCm.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion search compte : " + ex);
            }
            finally
            {
                sp.CloseConnection();
                comptedette();
            }
        }

        //rechercher si l'utilisateur a des dettes
        public void comptedette()
        {
            try
            {
                sp.OpenConnection();
                SqlConnection connection = sp.GetConnection();
                string req = "SELECT * FROM tPret WHERE id_client=@id_client";

                using (SqlCommand cmdDt = new SqlCommand(req, connection))
                {
                    cmdDt.Parameters.AddWithValue("@id_client", search_IdClient);

                    using (SqlDataReader rdDt = cmdDt.ExecuteReader())
                    {
                        if (rdDt.Read())
                        {
                            id_pret = rdDt["id_pret"].ToString();
                            montant_restant_bd = decimal.Parse(rdDt["montant_restat"].ToString());

                            MessageBox.Show("Vous avez une dette de : " + montant_restant_bd + "$");
                            
                        }
                        else
                        {
                            MessageBox.Show("Ce compte n'a pas de dette");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("La recherche a échouée : " + ex.Message);
            }
            finally
            {
                sp.CloseConnection();
                //check_Montant_Restant();
            }
        }

        //verifier si la dette égale à 0

        private void check_Montant_Restant()
        {
            sp.OpenConnection();
            SqlConnection connection = sp.GetConnection();
            try
            {
                string req2 = "SELECT * FROM tPayementPret WHERE id_pret=@id_pret";

                //decimal montant_rest_chk = 0m;
                //txtNumCompte.Text = numCompte;
                using (SqlCommand cmdDt2 = new SqlCommand(req2, connection))
                {
                    cmdDt2.Parameters.AddWithValue("@id_pret", id_pret);
                    //cmdDt2.Parameters.AddWithValue("@montant_restant", montant_rest_chk);

                    using (SqlDataReader rdr = cmdDt2.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            while (rdr.Read())
                            {
                                decimal check_somme = decimal.Parse(rdr["montant_restat"].ToString());

                                if (check_somme > 0m)
                                {
                                    MessageBox.Show("Ce compte a déjà une dette non remboursée");
                                }
                                else if (check_somme == 0m)
                                {
                                    MessageBox.Show("Ce compte n'a plus de dette ");
                                    sp.CloseConnection();
                                    EnregistrerPayementPret();
                                }
                            }
                        }
                        else
                        {
                            //enregistrement payement
                            sp.CloseConnection();
                            EnregistrerPayementPret();
                        }
                    }
                }
            } catch(Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            } finally
            {
                sp.CloseConnection();
            }
        }

        //============================ajout d'un pret=====================
        public void EnregistrerPayementPret()
        {
            montant_restant = montant_restant_bd - solde;
            try
            {
                sp.OpenConnection();
                using (SqlConnection con = sp.GetConnection())
                {
                    string req2 = "update tPret set montant_restat=@montant_restat where id_client=@id_client";
                    string req = "INSERT INTO tPayementPret (id_payement,montant_paye,montant_restat,id_pret,date_payement)  values (@i,@tmontant,@reste,@id_pret,@date_payement)";
                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {
                        cmd.Parameters.AddWithValue("@i", Id_trasenction);
                        cmd.Parameters.AddWithValue("@tmontant", solde);
                        cmd.Parameters.AddWithValue("@reste", montant_restant);
                        cmd.Parameters.AddWithValue("@id_pret", id_pret);
                        cmd.Parameters.AddWithValue("@date_payement", dateTransaction);
                        cmd.ExecuteNonQuery();
                    }
                    using (SqlCommand cmd2 = new SqlCommand(req2, con))
                    {
                        cmd2.Parameters.AddWithValue("@montant_restat", montant_restant);
                        cmd2.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Enregistrement reussi");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sp.CloseConnection();
                txtNom.Text = "";
                txtPrenom.Text = "";
                txtAdresse.Text = "";
                txtNumCompte.Text = "";
                txtPhone.Text = "";
                txtDevise.Text = "";
                txtMontantCredit.Text = "";
            }
        }
    }
}

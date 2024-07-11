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
    public partial class credit : UserControl
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
        public string  dateDebut;
        public string dateFin;
        private int dureeCredit;
        decimal montantTotal;
        private decimal montant_Interet;
        private decimal montant_restant;
        private string Id_trasenctionPret;
        private string idClientB;

        service_personnel sp = new service_personnel();
        public credit()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnValiderCredit_Click(object sender, EventArgs e)
        {
            getDataRetrait();
        }
        public void getDataRetrait()
        {
            nom = txtNom.Text;
            prenom = txtPrenom.Text;
            adresse = txtAdresse.Text;
            phone = txtPhone.Text;
            solde = decimal.Parse(txtMontantCredit.Text);
            devise = txtDevise.Text;
            numCompte = txtNumCompte.Text;
            dureeCredit = int.Parse(txtDuree.Text);

            decimal taux = 0.10m;

            montant_Interet = solde * taux * dureeCredit;
            montantTotal = montant_Interet + solde;
            montant_restant = montantTotal;

            MessageBox.Show("Montant : " + montantTotal);

            DateTime currentD = DateTime.Now;

            int dateNow = int.Parse(currentD.ToString("yyyy"));
            string mouth = currentD.ToString("dd-MM");

            dateFin = mouth + "-" + (dateNow + dureeCredit).ToString();
            dateDebut = mouth + "-" + (dateNow);

            dateTransaction = currentD.ToString("dd-MM-yyyy");
            heureTransaction = currentD.ToString("HH:mm");
            typeTransaction = "Crédit";
            Compte_source = "null";
            Compte_beneficiaire = "null";

            int length = 4;
            Random random = new Random();
            int minValue = (int)Math.Pow(10, length - 1);
            int maxValue = (int)Math.Pow(10, length) - 1;

            string num1 = "CD";
            string num2 = (random.Next(minValue, maxValue + 1)).ToString();
            string num3 = (random.Next(minValue, maxValue + 1)).ToString();

            string num1Payepret = "PAYE";

            Id_trasenctionPret = num1Payepret + dateTransaction + "." + heureTransaction + "." + num2 + num3;
            Id_trasenction = num1 + dateTransaction + "." + heureTransaction + "." + num2 + num3;

            check_Client_dette();
        }

        //rechercher les infos du client
        private void txtAdresse_TextChanged(object sender, EventArgs e)
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
                                idClientB = rd["id_client"].ToString();
                                string nomB = rd["nom"].ToString();
                                string prenomB = rd["prenom"].ToString();
                                txtAdresse.Text = rd["adresse"].ToString();
                                txtPhone.Text = rd["phone"].ToString();
                                search_IdClient = idClientB;
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
        //============================vérifier si le client a déjà demandé une dette au moins ene fois==========================
        


        //============================vérifier si le client a déjà une dêtte non payé
        private void check_Client_dette()
        {
            sp.OpenConnection();
            SqlConnection connection = sp.GetConnection();
            try
            {
                string req2 = "SELECT * FROM tPayementPret WHERE id_client=@id_client";

                //decimal montant_rest_chk = 0m;
                //txtNumCompte.Text = numCompte;
                using (SqlCommand cmdDt2 = new SqlCommand(req2, connection))
                {
                    cmdDt2.Parameters.AddWithValue("@id_client", search_IdClient);
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
                                    EnregistrerPret();
                                }
                            }
                        }
                        else
                        {
                            //enregistrement payement
                            sp.CloseConnection();
                            EnregistrerPret();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                sp.CloseConnection();
            }
        }

        //============================ajout d'un pret=====================
        public void EnregistrerPret()
        {
            try
            {
                sp.OpenConnection();
                //SqlConnection connection = sp.GetConnection();
                using (SqlConnection con = sp.GetConnection())
                {
                    string req = "INSERT INTO tPret (id_pret,date_debut,date_fin,taux_interet,montan_total,montant_restat,id_client)  values (@i,@debut,@fin,@taux,@tmontant,@reste,@id_client)";
                    using (SqlCommand cmd1 = new SqlCommand(req, con))
                    {
                        cmd1.Parameters.AddWithValue("@i", Id_trasenction);
                        cmd1.Parameters.AddWithValue("@debut", dateDebut);
                        cmd1.Parameters.AddWithValue("@fin", dateFin);
                        cmd1.Parameters.AddWithValue("@taux", montant_Interet);
                        cmd1.Parameters.AddWithValue("@tmontant", montantTotal);
                        cmd1.Parameters.AddWithValue("@reste", montant_restant);
                        cmd1.Parameters.AddWithValue("@id_client", search_IdClient);
                        cmd1.ExecuteNonQuery();
                        cmd1.Dispose();
                    }

                    decimal montantTotalDefaut = 0m;

                    string req2 = "INSERT INTO tPayementPret (id_payement,montant_paye,montant_restat,id_pret,date_payement,id_client)  values (@i,@tmontant,@reste,@id_pret,@date_payement,@id_client)";
                    using (SqlCommand cmd2 = new SqlCommand(req2, con))
                    {
                        cmd2.Parameters.AddWithValue("@i", Id_trasenction);
                        cmd2.Parameters.AddWithValue("@tmontant", montantTotalDefaut);
                        cmd2.Parameters.AddWithValue("@reste", montant_restant);
                        cmd2.Parameters.AddWithValue("@id_pret", Id_trasenctionPret);
                        cmd2.Parameters.AddWithValue("@date_payement", dateTransaction);
                        cmd2.Parameters.AddWithValue("@id_client", search_IdClient);
                        cmd2.ExecuteNonQuery();
                        cmd2.Dispose();

                        txtNom.Text = "";
                        txtPrenom.Text = "";
                        txtAdresse.Text = "";
                        txtNumCompte.Text = "";
                        txtPhone.Text = "";
                        txtDevise.Text = "";
                        txtMontantCredit.Text = "";
                        txtDuree.Text = "";

                        MessageBox.Show("Enregistrement reussit");
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
            }
        }
    }
}

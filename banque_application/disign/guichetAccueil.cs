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
using banque_application.classes;

namespace banque_application.disign
{
    public partial class guichetAccueil : UserControl
    {
        service_personnel srv = new service_personnel();

        int numeroBanque = 1560;
        int numIDcarte = 4000;
        public string numCompte;
        public string nom;
        public string postnom;
        public string prenom;
        public string adresse;
        public string contact;
        public string email;
        public string dateNaissance;
        public string typeCompte;
        public decimal solde;
        public string numeroCarte;
        public string devise;
        public string typeCarte;
        public string codeSecurite;
        public guichetAccueil()
        {
            InitializeComponent();
        }
    
        private void guichetAccueil_Load(object sender, EventArgs e)
        {
            numCarteProduct();
        }

        private void btnValiderClient_Click(object sender, EventArgs e)
        {
            enregistreClient();
        }
        public void enregistreClient()
        {
            string prenomTestId = txtPrenom.Text;

            DateTime currentDate = DateTime.Now;
            String annee = (currentDate.Year).ToString();
            Random random = new Random();
            string num = (random.Next(1000)).ToString();


            Client cls = new Client();

            nom = txtNom.Text;
            postnom = txtPostNom.Text;
            prenom = txtPrenom.Text;
            adresse = txtAdresse.Text;
            contact = txtPhone.Text;
            email = txtEmail.Text;
            dateNaissance = (dateNaissanceCli.Value).ToString("ddMMyyyy");
            typeCompte = txtTypeCompte.Text;
            //solde = decimal.Parse(txtSolde.Text);
            //numeroCarte = int.Parse(txtNumCarte.Text);
            devise = txtDevise.Text;
            typeCarte = txtTypeCarte.Text;
            codeSecurite = txtPassword.Text;

            cls.Id_client = prenomTestId + "_" + annee + num;
            cls.Nom = nom;
            cls.Postnom = postnom;
            cls.Prenom = prenom;
            cls.Adresse = adresse;
            cls.Phone = contact;
            cls.Datenaissance = dateNaissance;

            MessageBox.Show("Classe : " + cls.Id_client + cls.Nom + cls.Postnom);

            srv.EnregistrerClient();
        }

        private void numCarteProduct()
        {
            int length = 4;
            Random random = new Random();
            int minValue = (int)Math.Pow(10, length - 1);
            int maxValue = (int)Math.Pow(10, length) - 1;

            string num1 = (numIDcarte).ToString();
            string num2 = (random.Next(minValue, maxValue + 1)).ToString();
            string num3 = (random.Next(minValue, maxValue + 1)).ToString();
            string num4 = (random.Next(minValue, maxValue + 1)).ToString();


            numeroCarte = num1 + "  " + num2 + "  " + num3 + "  " + num4;

            string numCompteDB1 = (numeroBanque).ToString();
            string numCompteDB2 = (random.Next(minValue, maxValue + 1)).ToString();
            string numCompteDB3 = (random.Next(minValue, maxValue + 1)).ToString();
            string numCompteDB4 = (random.Next(minValue, maxValue + 1)).ToString();

            numCompte = numCompteDB1 + numCompteDB2  + numCompteDB3  + numCompteDB4;

            checkCompteInfo();
        }

        public void checkCompteInfo()
        {
            service_personnel sp = new service_personnel();
            try
            {
                sp.OpenConnection();

                SqlConnection connection = sp.GetConnection();

                string req1 = "SELECT * FROM tCompte WHERE num_compte=@num_compte";
                string req2 = "SELECT * FROM tCarte WHERE numero_carte=@num_carte";

                using (SqlCommand cmd1 = new SqlCommand(req1, connection))
                {
                    cmd1.Parameters.AddWithValue("@num_compte", numCompte);

                    using (SqlDataReader rd = cmd1.ExecuteReader())
                    {
                        if (rd.HasRows) { 
                            while (rd.Read())
                            {
                                string numCompteTest = rd["num_compte"].ToString();
                                numCarteProduct();
                            }
                        } else
                        {
                            txtNumeroCompte.Text = numCompte;
                        }
                    }
                }

                using (SqlCommand cmd2 = new SqlCommand(req2, connection))
                {
                    cmd2.Parameters.AddWithValue("@num_carte", numCompte);

                    using (SqlDataReader rd = cmd2.ExecuteReader())
                    {
                        if (rd.HasRows)
                        {
                            while (rd.Read())
                            {
                                string numCompteTest = rd["num_carte"].ToString();
                                numCarteProduct();
                            }
                        }
                        else
                        {
                            txtNumCarte.Text = numeroCarte;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue : " + ex.Message);
            }
            finally
            {
                sp.CloseConnection();
            }
        }


    }
}

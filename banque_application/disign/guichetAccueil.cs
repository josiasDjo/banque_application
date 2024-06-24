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
        public string Id_client;
        public string NumCompte;
        public string Nom;
        public string Postnom;
        public string Prenom;
        public string Adresse;
        public string Contact;
        public string Email;
        public string DateNaissance;
        public string TypeCompte;
        public decimal Solde;
        public string NumeroCarte;
        public string Devise;
        public string TypeCarte;
        public string CodeSecurite;
        public string Photo;
        public string Id_carte;
        public string Date_expiration;
        public string dateToDay;

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

            Nom = txtNom.Text;
            Postnom = txtPostNom.Text;
            Prenom = txtPrenom.Text;
            Adresse = txtAdresse.Text;
            Contact = txtPhone.Text;
            Email = txtEmail.Text;
            DateNaissance = (dateNaissanceCli.Value).ToString("dd-MM-yyyy");
            TypeCompte = txtTypeCompte.Text;
            Solde = decimal.Parse(txtSolde.Text);
            NumeroCarte = txtNumCarte.Text;
            Devise = txtDevise.Text;
            TypeCarte = txtTypeCarte.Text;
            CodeSecurite = txtPassword.Text;
            Photo = "";

            Id_client = prenomTestId + "_" + annee + num;

            MessageBox.Show("Classe : " + cls.Id_client + cls.Nom + cls.Postnom);

            EnregistrerClient();
        }

        private void numCarteProduct()
        {
            int length = 4;
            Random random = new Random();
            int minValue = (int)Math.Pow(10, length - 1);
            int maxValue = (int)Math.Pow(10, length) - 1;

            DateTime currentD = DateTime.Now;
            int currentDate = currentD.Year;
            int currentMonth = currentD.Month;

            string num1 = (numIDcarte).ToString();
            string num2 = (random.Next(minValue, maxValue + 1)).ToString();
            string num3 = (random.Next(minValue, maxValue + 1)).ToString();
            string num4 = (random.Next(minValue, maxValue + 1)).ToString();


            NumeroCarte = num1 + "  " + num2 + "  " + num3 + "  " + num4;

            string numCompteDB1 = (numeroBanque).ToString();
            string numCompteDB2 = (random.Next(minValue, maxValue + 1)).ToString();
            string numCompteDB3 = (random.Next(minValue, maxValue + 1)).ToString();
            string numCompteDB4 = (random.Next(minValue, maxValue + 1)).ToString();

            NumCompte = numCompteDB1 + numCompteDB2  + numCompteDB3  + numCompteDB4;

            Id_carte = txtPrenom.Text + "_" + numCompteDB2 + numCompteDB1;
            string anneeExpi = (currentDate + 5).ToString();
            string moisExpi = (currentMonth).ToString();
            Date_expiration = moisExpi + "/" +  anneeExpi;
            dateToDay = (currentD).ToString("dd-MM-yyyy");
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
                    cmd1.Parameters.AddWithValue("@num_compte", NumCompte);

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
                            txtNumeroCompte.Text = NumCompte;
                        }
                    }
                }

                using (SqlCommand cmd2 = new SqlCommand(req2, connection))
                {
                    cmd2.Parameters.AddWithValue("@num_carte", NumCompte);

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
                            txtNumCarte.Text = NumeroCarte;
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

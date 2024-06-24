using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using banque_application.disign;
using banque_application.classes;
using System.Windows.Controls;

namespace banque_application.classes
{
    class Client
    {
        string id_client;
        string nom;
        string postnom;
        string prenom;
        string adresse;
        string phone;
        string datenaissance;
        string photo;

        public string Id_client
        {
            get
            {
                return id_client;
            }

            set
            {
                id_client = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Postnom
        {
            get
            {
                return postnom;
            }

            set
            {
                postnom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

        public string Adresse
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public string Datenaissance
        {
            get
            {
                return datenaissance;
            }

            set
            {
                datenaissance = value;
            }
        }

        public string Photo
        {
            get
            {
                return photo;
            }

            set
            {
                photo = value;
            }
        }
    }
}

namespace banque_application.disign
{
    public partial class guichetAccueil
    {
        service_personnel sp = new service_personnel();

        public void EnregistrerClient()
        {
            //service_personnel srv = new service_personnel();
            Client cls = new Client();
            try
            {
                sp.OpenConnection();

                SqlConnection connection = sp.GetConnection();

                MessageBox.Show("Ident : " + cls.Id_client + " " + cls.Prenom);
                string req = "INSERT INTO tClient (id_client,nom,postnom,prenom,adresse,phone,date_naissance,photo) values (@i,@nom,@postnom,@prenom,@adresse,@phone,@date,@photo)";
                using (SqlCommand cmd = new SqlCommand(req, connection))
                {
                    cmd.Parameters.AddWithValue("@i", Id_client);
                    cmd.Parameters.AddWithValue("@nom", Nom);
                    cmd.Parameters.AddWithValue("@postnom", Postnom);
                    cmd.Parameters.AddWithValue("@prenom", Prenom);
                    cmd.Parameters.AddWithValue("@adresse", Adresse);
                    cmd.Parameters.AddWithValue("@phone", Contact);
                    cmd.Parameters.AddWithValue("@date", DateNaissance);
                    cmd.Parameters.AddWithValue("@photo", Photo);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Client enregistré avec succes");
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

        //===============ajout d'une carte==================
        public void EnregistrerCarte()
        {
            try
            {
                sp.OpenConnection();
                SqlConnection connection = sp.GetConnection();

                    string req = "INSERT INTO tCarte (id_carte,numero_carte,type_carte,date_expiration) values (@i,@num,@type,@date)";
                    using (SqlCommand cmd = new SqlCommand(req, connection))
                    {
                        cmd.Parameters.AddWithValue("@i", Id_carte);
                        cmd.Parameters.AddWithValue("@num", NumeroCarte);
                        cmd.Parameters.AddWithValue("@type", TypeCarte);
                        cmd.Parameters.AddWithValue("@date", Date_expiration);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Enregistrement reussi");
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

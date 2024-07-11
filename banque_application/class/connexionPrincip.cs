using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace banque_application.disign
{
    public partial class connexionPage
    {
        service_personnel sp = new service_personnel();


        private string nom;
        private string prenom;
        private string motDePasse;
        private string fonction;
        private string fonctionDb;

        private void checkData()
        {
            sp.CloseConnection();
            nom = txtNomDeb.Text;
            prenom = txtPrenomDeb.Text;
            motDePasse = txtMotDePasseDeb.Text;
            fonction = txtFonction.Text;

            if (nom == "" || prenom == "" || motDePasse == "" || fonction == "")
            {
                MessageBox.Show("Tout les champs sont réquis ! ");
            } else
            {
                {     
                    try
                    {
                        sp.OpenConnection();
                        using (SqlConnection con = sp.GetConnection())
                        {
                            string req = "SELECT * FROM tEmploye WHERE  nom=@nom AND prenom=@prenom AND grade=@grade AND mdp=@mdp";

                            using (SqlCommand cmd = new SqlCommand(req, con))
                            {
                                cmd.Parameters.AddWithValue("@nom", nom);
                                cmd.Parameters.AddWithValue("@prenom", prenom);
                                cmd.Parameters.AddWithValue("@grade", fonction);
                                cmd.Parameters.AddWithValue("@mdp", motDePasse);
                                cmd.ExecuteNonQuery();

                                using (SqlDataReader rd = cmd.ExecuteReader())
                                {
                                    if (rd.HasRows)
                                    {
                                        //MessageBox.Show("Infos correctes ! ");
                                        Form1 frm1 = new Form1();
                                        frm1.openFen();

                                        pageAccueilPrinc pgAccPrinc = new pageAccueilPrinc();

                                        this.Controls.Clear();
                                        BackgroundImage = null;
                                        this.Controls.Add(pgAccPrinc);

                                        //this.Size = new Size(1000, 570);
                                        //this.MaximumSize = new Size(1000, 570);
                                        //this.MinimumSize = new Size(1000, 570);
                                    } else
                                    {
                                        MessageBox.Show("Infromations invalides, Vérifier puis réessayer");
                                    }
                                }
                            }
                        }

                    } catch (Exception ex) 
                    {
                        MessageBox.Show("Erreur : " + ex);
                    } finally
                    {
                        sp.CloseConnection();
                    }
                }
            }
        }
    }
}

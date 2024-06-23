using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using banque_application;
using banque_application.classes;
using System.Data.SqlClient;

namespace banque_application.disign
{
    public partial class service_personnel : UserControl
    {
        public service_personnel()
        {
            InitializeComponent();           
        }

        private void btnValiderCredit_Click(object sender, EventArgs e)
        {
            if (txtNomEm.Text == "" || txtPostNomEm.Text == "" || txtPrenomEm.Text == "" || txtPhoneEm.Text == "" || txtSalaire.Text == "" ||
                txtdateEmbauche.Value == null || txtPoste.Text == "" || txtAdresse.Text == "")
            {
                MessageBox.Show("Veillez renseigner tout les champs");
            }
            else
            {
                sendData();
            }          
        }
        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (recherche.ForeColor == Color.Gray)
            {
                recherche.Text = "";
                recherche.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(recherche.Text))
            {
                recherche.ForeColor = Color.Gray;
                recherche.Text = "Recherher ici...";
            }
        }
        public void sendData()
        {
            string prenom = txtPrenomEm.Text;
            string poste = txtPoste.Text;

            DateTime currentDate = DateTime.Now;
            String annee = (currentDate.Year).ToString();
            Random random = new Random();
            string num = (random.Next(1000)).ToString();

            string matricule = prenom + '_' + annee + poste + num;

            MessageBox.Show("Matricule : " + matricule);

            contenneur srv = new contenneur();

            string id_employeB = matricule;
            string nomB = txtNomEm.Text;
            string postnomB = txtPostNomEm.Text;
            string prenomB = txtPrenomEm.Text;
            string gradeB = txtPoste.Text;
            string date_embaucheB = (txtdateEmbauche.Value).ToString();
            string contactB = txtPhoneEm.Text;
            decimal salaireB = decimal.Parse(txtSalaire.Text);

            Employe em = new Employe(id_employeB, nomB, postnomB, prenomB, gradeB, date_embaucheB, contactB, salaireB);

            em.Id_employe = id_employeB;
            em.Nom = nomB;
            em.Postnom = postnomB;
            em.Prenom = prenomB;
            em.Grade = gradeB;
            em.Date_embauche = date_embaucheB;
            em.Contact = contactB;
            em.Salaire = salaireB;
            MessageBox.Show("identité : " + em.Prenom + " " + em.Date_embauche + " " + em.Salaire);
            EnregistrerEmploye();
        }

        public void EnregistrerEmploye()
        {
            contenneur conn = new contenneur();
            //Employe em = new Employe(id_employe, nom, postnom, prenom, grade, dateEmbauche, contact, salaire);
            service_personnel cont = new service_personnel();

            MessageBox.Show("Backend activer");

            try
            {
                //InnitialiseConnection();
                //cont.connDb();
                service_personnel srvp = new service_personnel();
                srvp.sendData();
                Employe em = new Employe();
                using (SqlConnection con = new SqlConnection(conn.connexion))
                {
                    con.Open();
                    if (em.Id_employe == "")
                    {
                        MessageBox.Show("ne peut pas contenir des valeur null");
                    }
                    else
                    {
                        MessageBox.Show("id : " + em.Id_employe);
                    }
                    string req = "INSERT INTO tEmploye (id_employe,nom,postnom,prenom,grade,date_Embauche,contact,salaire) values (@i,@nom,@postnom,@prenom,@grade,@date,@contact,@salaire)";
                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {
                        cmd.Parameters.AddWithValue("@i", em.Id_employe ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@nom", em.Nom ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@postnom", em.Postnom ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@prenom", em.Prenom ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@grade", em.Grade ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@date", em.Date_embauche ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@contact", em.Contact ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@salaire", em.Salaire != 0 ? em.Salaire : (object)DBNull.Value);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Enregistrement reussi");
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc);
            }
            finally
            {
                if (conn.reqSql != null && conn.reqSql.State == ConnectionState.Open)
                {
                    conn.reqSql.Close();
                    conn.reqSql.Dispose();
                }
            }
        }

    }
}

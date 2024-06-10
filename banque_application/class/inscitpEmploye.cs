using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using banque_application;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace banque_application.disign
{
    public partial class service_personnel
    {
        //Form1 frm1 = new Form1();
        public void collectData()
        {
            string dateMatricule = (DateTime.Today.Year).ToString();
            Random idRandom = new Random();
            string idEnd = idRandom.Next(1000).ToString();

            string nom = txtNomEm.Text;
            string postNom = txtPostNomEm.Text;
            string prenom = txtPrenomEm.Text;
            string adresse = txtAdresse.Text;
            string phone = txtPhoneEm.Text;
            string poste = txtPoste.Text;
            decimal salaire = decimal.Parse(txtSalaire.Text);

            string dateNaissance = txtdateNaissance.Value.ToString("yyyy-MM-dd");
            string dateEmbauche = txtdateEmbauche.Value.ToString("yyyy-MM-dd");


            string matricule = prenom + "_" + dateMatricule + poste + idEnd;

            MessageBox.Show("Matricule : " + matricule + " Date de naissance : " + dateNaissance);
        }

        private void sendDate()
        {
            connexionDb connDb = new connexionDb();

            connDb.connDb();
            try
            {
                string req = "INSERT INTO tEmploye";
            } catch (SqlException exc)
            {
                MessageBox.Show("Une erreur s'est produite : " + exc);
            } finally
            {
                connDb.reqSql.Close();
                connDb.reqSql.Dispose();
            }
        }

    }
}

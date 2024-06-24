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
using System.Security.Cryptography;
using banque_application.Properties;

namespace banque_application.disign
{
    public partial class service_personnel : UserControl
    {
        private string id_employeB;
        private string nomB;
        private string postnomB;
        private string prenomB;
        private string gradeB;
        private string date_embaucheB;
        private string contactB;
        private decimal salaireB;
        public service_personnel()
        {
            InitializeComponent();
            connection = new SqlConnection(connexion);
        }

        private void btnValiderCredit_Click(object sender, EventArgs e)
        {
            if(txtNomEm.Text == "" ||
                txtPostNomEm.Text == "" ||
                txtPrenomEm.Text == "" ||
                txtPhoneEm.Text == "" ||
                txtSalaire.Text == "" ||
                txtdateEmbauche.Value == null ||
                txtPoste.Text == "" ||
                txtAdresse.Text == "")
            {
                MessageBox.Show("Veillez renseigner tout les champs");
            } else
            {
                sendData();
            }
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if(recherche.ForeColor == Color.Gray)
            {
                recherche.Text = "";
                recherche.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(recherche.Text))
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

            //contenneur srv = new contenneur();
            string posteID = "";

            if(poste == "Directeur de Banque")
            {
                posteID = "DB";
            } else if(poste == "Directeur Adjoint")
            {
                posteID = "DA";
            } else if(poste == "Caissier")
            {
                posteID = "CA";
            } else if(poste == "Conseiller Financier")
            {
                posteID = "CF";
            } else if(poste == "Responsable des Ressources Humaines")
            {
                posteID = "RRH";
            } else if(poste == "Guichetier")
            {
                posteID = "DG";
            } else if(poste == "Technicien Informatique")
            {
                posteID = "IT";
            } else
            {
                MessageBox.Show("Entrez un poste correct !");
            }
            string matricule = prenom + '_' + annee + posteID + num;

            id_employeB = matricule;
            nomB = txtNomEm.Text;
            postnomB = txtPostNomEm.Text;
            prenomB = txtPrenomEm.Text;
            gradeB = txtPoste.Text;
            date_embaucheB = (txtdateEmbauche.Value).ToString("dd/MM/yyyy");
            contactB = txtPhoneEm.Text;
            salaireB = decimal.Parse(txtSalaire.Text);

            //effacer les tout input
            txtNomEm.Text = "";
            txtPostNomEm.Text = "";
            txtPrenomEm.Text = "";
            txtPoste.Text = "";
            txtPhoneEm.Text = "";
            txtSalaire.Text = "";
            txtAdresse.Text = "";

            EnregistrerEmploye();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            nomB = txtNomEm.Text;
            postnomB = txtPostNomEm.Text;
            prenomB = txtPrenomEm.Text;
            contactB = txtPhoneEm.Text;
            salaireB = decimal.Parse(txtSalaire.Text);

            txtNomEm.Text = "";
            txtPostNomEm.Text = "";
            txtPrenomEm.Text = "";
            txtPoste.Text = "";
            txtPhoneEm.Text = "";
            txtSalaire.Text = "";
            txtAdresse.Text = "";
            ModifierEmploye();
        }
    }
}

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
            srv.EnregistrerEmploye();
        }
    }
}

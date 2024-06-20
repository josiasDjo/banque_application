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
                string prenom = txtPrenomEm.Text;
                string poste = txtPoste.Text;

                DateTime currentDate = DateTime.Now;
                String annee = (currentDate.Year).ToString();
                Random random = new Random();
                string num = (random.Next(1000)).ToString();

                Employe empl = new Employe();

                string matricule = prenom + '_' + annee + poste + num;

                MessageBox.Show("Matricule : " + matricule);

                empl.Id_employe = matricule;
                empl.Nom = txtNomEm.Text;
                empl.Postnom = txtPostNomEm.Text;
                empl.Prenom = txtPrenomEm.Text;
                empl.Grade = txtPoste.Text;
                empl.Date_embauche = (txtdateEmbauche.Value).ToString();
                empl.Contact = txtPhoneEm.Text;
                empl.Salaire = decimal.Parse(txtSalaire.Text);

                contenneur cont = new contenneur();
                cont.EnregistrerEmploye();

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
    }
}

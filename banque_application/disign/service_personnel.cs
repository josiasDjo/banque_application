using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banque_application.disign
{
    public partial class service_personnel : UserControl
    {
        public service_personnel()
        {
            InitializeComponent();           
        }
        public void send()
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
            string matricule = prenom + "_" + dateMatricule + poste + idEnd;

            MessageBox.Show("Matricule : " + matricule + " Date de naissance : " + dateNaissance);
        }

        private void btnValiderCredit_Click(object sender, EventArgs e)
        {
            send();
        }
    }
}

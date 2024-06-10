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
            Random idRandom = new Random();
            int idEnd = idRandom.Next();
            messageError.Text = "Check send";
            //MessageBox.Show("Nombre : " + idEnd);

            //btnValiderCredit.BackColor = Color.Green;
            string nom = txtNomEm.Text;
            string postNom = txtPostNomEm.Text;
            string prenom = txtPrenomEm.Text;
            string adresse = txtAdresse.Text;
            string phone = txtPhoneEm.Text;
            string poste = txtPoste.Text;
            decimal salaire = decimal.Parse(txtSalaire.Text);
            //DateTime dateNaissance = txtdateNaissance.Value;
            //DateTime dateEmbauche = txtdateEmbauche.Value;

            MessageBox.Show("Date de naissance : " + idEnd + ", Date d'embauche : " + prenom);
        }

        private void btnValiderCredit_Click(object sender, EventArgs e)
        {
            send();
        }
    }
}

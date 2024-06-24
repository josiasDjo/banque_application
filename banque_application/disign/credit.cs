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
    public partial class credit : UserControl
    {
        public string nom;
        public string prenom;
        public string adresse;
        public string phone;
        public decimal solde;
        public string devise;
        public string numCompte;
        public string dateTransaction;
        public string typeTransaction;
        public string Compte_source;
        public string Compte_beneficiaire;
        public string Id_trasenction;
        public string heureTransaction;
        public string search_IdClient;
        public string id_compte;
        public credit()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnValiderCredit_Click(object sender, EventArgs e)
        {

        }
        public void getDataRetrait()
        {
            nom = txtNom.Text;
            prenom = txtPrenom.Text;
            adresse = txtAdresse.Text;
            phone = txtPhone.Text;
            solde = decimal.Parse(txtMontantCredit.Text);
            devise = txtDevise.Text;
            numCompte = txtNumCompte.Text;

            DateTime currentD = DateTime.Now;

            dateTransaction = currentD.ToString("dd-MM-yyyy");
            heureTransaction = currentD.ToString("HH:mm");
            typeTransaction = "Retrait";
            Compte_source = "null";
            Compte_beneficiaire = "null";

            int length = 4;
            Random random = new Random();
            int minValue = (int)Math.Pow(10, length - 1);
            int maxValue = (int)Math.Pow(10, length) - 1;

            string num1 = "RT";
            string num2 = (random.Next(minValue, maxValue + 1)).ToString();
            string num3 = (random.Next(minValue, maxValue + 1)).ToString();

            Id_trasenction = num1 + dateTransaction + "." + heureTransaction + "." + num2 + num3;

            //EnregistrerTrans();
        }
    }
}

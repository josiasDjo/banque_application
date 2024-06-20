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
            string prenom = txtPrenomEm.Text;
            string poste = txtPoste.Text;

            DateTime currentDate = DateTime.Now;
            String  annee = (currentDate.Year).ToString();
            Random random = new Random();
            string num = (random.Next(1000)).ToString();

            Employe empl = new Employe();

            string matricule = prenom + '_' + annee + poste + num;

            MessageBox.Show("Matricule : " + matricule);
            //empl.Id_employe = 
        }
    }
}

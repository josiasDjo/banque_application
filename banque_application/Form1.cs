using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using banque_application;
using banque_application.disign;

namespace banque_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            afficheAccueil();
        }

        private void btnValiderTransfere_Click(object sender, EventArgs e)
        {
            openFen();
            
        }
        public void openFen()
        {
            this.Size = new Size(1100, 590);
            accueil_page pgAcc = new accueil_page();

            panel1_ConnexionShow.Controls.Clear();
            panel1_ConnexionShow.Controls.Add(pgAcc);
            
        }
        public void afficheAccueil()
        {
            connexionPage cnnPage = new connexionPage();

            panel1_ConnexionShow.Controls.Clear();
            panel1_ConnexionShow.Controls.Add(cnnPage);
        }
    }
}

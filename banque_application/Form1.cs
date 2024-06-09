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
            connexionPage connPage = new connexionPage();

            afficheAccueil();

        }

        private void btnValiderTransfere_Click(object sender, EventArgs e)
        {
            openFen();
            
        }
        public void openFen()
        {
            panel1_ConnexionShow.Visible = false;
            secondPanelAccueil.Visible = true;
            MessageBox.Show("openFen is True");
            this.Size = new Size(1000, 570);
            this.MaximumSize = new Size(1000, 570);
            this.MinimumSize = new Size(1000, 570);
            accueil_page pgAcc = new accueil_page();

            
        }
        public void afficheAccueil()
        {
            secondPanelAccueil.Visible = false;
            connexionPage cnnPage = new connexionPage();

            panel1_ConnexionShow.Controls.Clear();
            panel1_ConnexionShow.Controls.Add(cnnPage);
        }

    }
}

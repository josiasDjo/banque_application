using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using banque_application.disign;
using System.Data.SqlClient;
using System.Diagnostics;

namespace banque_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            connexionPage connPage = new connexionPage();
            // nouvelle instance
            afficheAccueil();

        }

        private void btnValiderTransfere_Click(object sender, EventArgs e)
        {
            openFen();
            
        }
        public void openFen()
        {
            //panel1_ConnexionShow.Visible = false;

            //this.panel1_ConnexionShow.Controls.Clear();
            panel1_ConnexionShow.Controls.Clear();
            panel1_ConnexionShow.BackgroundImage = null;
            panel1_ConnexionShow.Visible = false;


            //MessageBox.Show("openFen is True");
            //this.Size = new Size(1000, 836);
            //this.MaximumSize = new Size(1000, 836);
            //this.MinimumSize = new Size(1000, 836);           
            
        }
        public void afficheAccueil()
        {
            this.Size = new Size(1000, 580);
            this.MaximumSize = new Size(1000, 580);
            this.MinimumSize = new Size(1000, 580);

            connexionPage cnnPage = new connexionPage();

            panel1_ConnexionShow.Controls.Clear();
            panel1_ConnexionShow.Controls.Add(cnnPage);   
        }
        public void sendD()
        {
            //string nom = txtNom.Text;
        }
    }
}




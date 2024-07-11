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
    public partial class accueil_page : UserControl
    {
        public accueil_page()
        {
            InitializeComponent();
            dashboard();
        }

        private void btnDepot_Click(object sender, EventArgs e)
        {
            depot dpot = new depot();

            btnAccueil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            btnAccueil.ForeColor = System.Drawing.Color.White;

            btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            btnDashboard.ForeColor = System.Drawing.Color.White;

            btnDepot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            btnDepot.ForeColor = System.Drawing.Color.Black;

            button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            button2.ForeColor = System.Drawing.Color.White;

            btnCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            btnCredit.ForeColor = System.Drawing.Color.White;

            button1.ForeColor = System.Drawing.Color.White;
            button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));

            btnTransfert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            btnTransfert.ForeColor = System.Drawing.Color.White;

            panel1_showData_accueil.Controls.Clear();
            panel1_showData_accueil.Controls.Add(dpot);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            dashboard();
        }
        private void dashboard()
        {
            comptabilte compt = new comptabilte();
            
            btnAccueil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255))))); ;
            btnAccueil.ForeColor = System.Drawing.Color.White;

            btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255))))); ;
            btnDashboard.ForeColor = System.Drawing.Color.Black;

            btnDepot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            btnDepot.ForeColor = System.Drawing.Color.White;

            button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            button2.ForeColor = System.Drawing.Color.White;

            btnCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            btnCredit.ForeColor = System.Drawing.Color.White;

            button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            button1.ForeColor = System.Drawing.Color.White;

            btnTransfert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            btnTransfert.ForeColor = System.Drawing.Color.White;

            panel1_showData_accueil.Controls.Clear();
            panel1_showData_accueil.Controls.Add(compt);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            retrait retraitArgent = new retrait();

            btnAccueil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            btnAccueil.ForeColor = System.Drawing.Color.White;

            btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            btnDashboard.ForeColor = System.Drawing.Color.White;

            btnDepot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            btnDepot.ForeColor = System.Drawing.Color.White;

            button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            button2.ForeColor = System.Drawing.Color.Black;

            btnTransfert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            btnTransfert.ForeColor = System.Drawing.Color.White;

            btnCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            btnCredit.ForeColor = System.Drawing.Color.White;

            button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            button1.ForeColor = System.Drawing.Color.White;

            //btnTransfert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            //btnTransfert.ForeColor = System.Drawing.Color.White;

            panel1_showData_accueil.Controls.Clear();
            panel1_showData_accueil.Controls.Add(retraitArgent);
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            credit crdit = new credit();

            btnAccueil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            btnAccueil.ForeColor = System.Drawing.Color.White;

            btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            btnDashboard.ForeColor = System.Drawing.Color.White;

            btnDepot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            btnDepot.ForeColor = System.Drawing.Color.White;

            button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            button2.ForeColor = System.Drawing.Color.White;

            btnCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            btnCredit.ForeColor = System.Drawing.Color.Black;

            button1.ForeColor = System.Drawing.Color.White;
            button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            
            btnTransfert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            btnTransfert.ForeColor = System.Drawing.Color.White;

            panel1_showData_accueil.Controls.Clear();
            panel1_showData_accueil.Controls.Add(crdit);
        }

        private void btnTransfert_Click(object sender, EventArgs e)
        {
            //this.btnTransfert.ForeColor = System.Drawing.Color.Lime;
            transferer transf = new transferer();

            
            btnAccueil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            btnAccueil.ForeColor = System.Drawing.Color.White;

            btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            btnDashboard.ForeColor = System.Drawing.Color.White;

            btnDepot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            btnDepot.ForeColor = System.Drawing.Color.White;

            button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            button2.ForeColor = System.Drawing.Color.White;

            btnCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            btnCredit.ForeColor = System.Drawing.Color.White;

            button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            button1.ForeColor = System.Drawing.Color.White;

            btnTransfert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            btnTransfert.ForeColor = System.Drawing.Color.Black;


            panel1_showData_accueil.Controls.Clear();
            panel1_showData_accueil.Controls.Add(transf);
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.openFen();

            connexionPage cnnPage = new connexionPage();

            this.Controls.Clear();
            BackgroundImage = null;
            this.Controls.Add(cnnPage);

            this.Size = new Size(1000, 570);
            this.MaximumSize = new Size(1000, 570);
            this.MinimumSize = new Size(1000, 570);
        }
        private void afficherAccueil ()
        {

        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            btnAccueil.BackColor = System.Drawing.Color.White;
            btnAccueil.ForeColor = System.Drawing.Color.Black;
            btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            btnDepot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            btnCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            btnTransfert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));


            accueilPageMoney();
        }
        public void accueilPageMoney()
        {
            //this.btnAccueil.ForeColor = System.Drawing.Color.Lime;

            pageAccueilPrinc accueilPagePrinc = new pageAccueilPrinc();

            this.Controls.Clear();
            this.Controls.Add(accueilPagePrinc);         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnAccueil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            btnAccueil.ForeColor = System.Drawing.Color.White;
            
            btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            btnDashboard.ForeColor = System.Drawing.Color.White;
            
            btnDepot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            btnDepot.ForeColor = System.Drawing.Color.White;
            
            button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            button2.ForeColor = System.Drawing.Color.White;
            
            btnCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            btnCredit.ForeColor = System.Drawing.Color.White;

            button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            button1.ForeColor = System.Drawing.Color.Black;
            
            btnTransfert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            btnTransfert.ForeColor = System.Drawing.Color.White;


            payementPret pyPret = new payementPret();
            panel1_showData_accueil.Controls.Clear();
            panel1_showData_accueil.Controls.Add(pyPret);
        }
    }
}

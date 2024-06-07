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

namespace banque_application.disign
{
    public partial class page_d_accueil : Form
    {
        public page_d_accueil()
        {
            InitializeComponent();
            closeFen();
        }

        Form1 frm1 = new Form1();
        

        private void btnDashboard_Click(object sender, EventArgs e)
        {          
            comptabilte compt = new comptabilte();

            pageAccueilContenu.Controls.Clear();
            pageAccueilContenu.Controls.Add(compt);
        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            closeFen();
        }
        public void closeFen()
        {
            tsAccu contenuAccueil = new tsAccu();

            pageAccueilContenu.Controls.Clear();
            pageAccueilContenu.Controls.Add(contenuAccueil);
        }

        private void btnTransfert_Click(object sender, EventArgs e)
        {
            transferer transferContenu = new transferer();

            pageAccueilContenu.Controls.Clear();
            pageAccueilContenu.Controls.Add(transferContenu);
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            credit creditContenu = new credit();

            pageAccueilContenu.Controls.Clear();
            pageAccueilContenu.Controls.Add(creditContenu);
        }
    }
}

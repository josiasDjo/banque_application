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
        }

        private void btnValiderTransfere_Click(object sender, EventArgs e)
        {
            page_d_accueil pgAcc = new page_d_accueil();
            pgAcc.Show();
            Form1 frm1 = new Form1();
            frm1.Close();
        }
    }
}

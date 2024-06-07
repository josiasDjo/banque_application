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

namespace banque_application.disign
{
    public partial class page_d_accueil : Form
    {
        public page_d_accueil()
        {
            InitializeComponent();
            Form1 frm1 = new Form1();
            frm1.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using banque_application.disgn;
using System.Drawing.Drawing2D;

namespace banque_application.disign
{
    public partial class connexionPage : UserControl
    {
        public connexionPage()
        {
            InitializeComponent();

            panel1.SetRoundedCorners(20);
        }

        private void btnValiderTransfere_Click(object sender, EventArgs e)
        {
            //Form1 frm1 = new Form1();
            //frm1.openFen();

            //pageAccueilPrinc pgAccPrinc = new pageAccueilPrinc();

            //this.Controls.Clear();
            //BackgroundImage = null;
            //this.Controls.Add(pgAccPrinc);

            //this.Size = new Size(1000, 570);
            //this.MaximumSize = new Size(1000, 570);
            //this.MinimumSize = new Size(1000, 570);

            checkData();
        }

        private void showpswd_Click(object sender, EventArgs e)
        {

        }

        private void showpswd_Click_1(object sender, EventArgs e)
        {
            if (showpswd.Text == "Montrer")
            {
                txtMotDePasseDeb.PasswordChar = '\0';
                showpswd.Text = "Cacher";
            }
            else if (showpswd.Text == "Cacher")
            {
                txtMotDePasseDeb.PasswordChar = '*';
                showpswd.Text = "Montrer";
            }
        }

        
    }
}

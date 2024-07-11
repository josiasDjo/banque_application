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
    public partial class pageAccueilPrinc : UserControl
    {
        service_personnel servicePerso = new service_personnel();
        header hd = new header();
        public pageAccueilPrinc()
        {
            InitializeComponent();
            accueilShow();
        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            accueilShow();
        }

        private void accueilShow()
        {
            btnAccueil.ForeColor = System.Drawing.Color.Black;
            btnDashboard.ForeColor = System.Drawing.Color.White;
            btnDepot.ForeColor = System.Drawing.Color.White;
            button2.ForeColor = System.Drawing.Color.White;

            banque_application.Resources.tsAccu accueiilPageContainer = new banque_application.Resources.tsAccu();

            pageAccueilContenu.Controls.Clear();
            //pageAccueilContenu.Controls.Add(accueiilPageContainer);
            pageAccueilContenu.BackgroundImage = global::banque_application.Properties.Resources.buy_real_instagram_followers_https___buyrealsocialmarketing_com_instagram;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            btnAccueil.ForeColor = System.Drawing.Color.White;
            btnDashboard.ForeColor = System.Drawing.Color.White;
            btnDepot.ForeColor = System.Drawing.Color.White;
            button2.ForeColor = System.Drawing.Color.Black;

            pageAccueilContenu.BackgroundImage = null;
            pageAccueilContenu.Controls.Clear();
            pageAccueilContenu.Controls.Add(servicePerso);
        }

        private void btnDepot_Click(object sender, EventArgs e)
        {
            guichetAccueil guichetAcc = new guichetAccueil();

            btnAccueil.ForeColor = System.Drawing.Color.White;
            btnDashboard.ForeColor = System.Drawing.Color.White;
            btnDepot.ForeColor = System.Drawing.Color.Black;
            button2.ForeColor = System.Drawing.Color.White;

            pageAccueilContenu.Controls.Clear();
            pageAccueilContenu.Controls.Add(guichetAcc);
            pageAccueilContenu.BackgroundImage = null;

        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            connexionPage connPage = new connexionPage();
            this.Controls.Clear();
            this.Controls.Add(connPage);  
            pageAccueilContenu.BackgroundImage = null;

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            btnAccueil.ForeColor = System.Drawing.Color.White;
            btnDashboard.ForeColor = System.Drawing.Color.Black;
            btnDepot.ForeColor = System.Drawing.Color.White;
            button2.ForeColor = System.Drawing.Color.White;

            accueil_page accueilP = new accueil_page();
            this.Controls.Clear();
            this.Controls.Add(accueilP);
        }

        private void pageAccueilContenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

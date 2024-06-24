using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using banque_application.disign;

namespace banque_application.disign
{
    public partial class pageAccueilPrinc : UserControl
    {
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
            tsAccu accueiilPageContainer = new tsAccu();

            pageAccueilContenu.Controls.Clear();
            pageAccueilContenu.Controls.Add(accueiilPageContainer);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            service_personnel servicePerso = new service_personnel();

            pageAccueilContenu.Controls.Clear();
            pageAccueilContenu.Controls.Add(servicePerso);
        }

        private void btnDepot_Click(object sender, EventArgs e)
        {
            guichetAccueil guichetAcc = new guichetAccueil();

            pageAccueilContenu.Controls.Clear();
            pageAccueilContenu.Controls.Add(guichetAcc);
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            connexionPage connPage = new connexionPage();
            this.Controls.Clear();
            this.Controls.Add(connPage);   
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            accueil_page accueilP = new accueil_page();
            this.Controls.Clear();
            this.Controls.Add(accueilP);
        }

        private void pageAccueilContenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

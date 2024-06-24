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
    public partial class comptabilte : UserControl
    {
        private string soldeTotal;
        private string revenuTotal;
        private string detteTotal;
        private string clientTotal;
        public comptabilte()
        {
            InitializeComponent();
            show();
        }
        private void show()
        {
            DateTime currentDate = DateTime.Now;
            dateToDay.Text = currentDate.ToString("dd/MM/yyyy");
        }
    }
}

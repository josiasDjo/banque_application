﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using banque_application;

namespace banque_application.disign
{
    public partial class connexionPage : UserControl
    {
        public connexionPage()
        {
            InitializeComponent();
        }

        private void btnValiderTransfere_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.openFen();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace banque_application.disign
{
    public partial class comptabilte : UserControl
    {
        service_personnel sp = new service_personnel();
        public decimal soldeTotal;
        public decimal revenuTotal;
        public decimal detteTotal;
        public decimal clientTotal;
        public comptabilte()
        {
            InitializeComponent();
            show();
        }
        private void show()
        {
            DateTime currentDate = DateTime.Now;
            dateToDay.Text = currentDate.ToString("dd/MM/yyyy");
            txtSoldeTotal.Text = "";
            txtRevenuTotal.Text = "";
            txtDepenseTotal.Text = "";
            dettelabel.Text = "";

            getStat();
        }
        private void getStat()
        {
            try
            {
                sp.OpenConnection();
                using (SqlConnection con = sp.GetConnection())
                {
                    string req1 = "SELECT * FROM tCompte";
                    string req2 = "SELECT * FROM tPret";

                    using (SqlCommand cmd1 = new SqlCommand(req1, con))
                    {
                        using (SqlDataReader rd = cmd1.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                clientTotal += decimal.Parse(rd["solde_compte"].ToString());
                            }
                            txtDepenseTotal.Text = clientTotal.ToString();
                        }
                    }
                    using (SqlCommand cmd2 = new SqlCommand(req2 ,con))
                    {
                        using (SqlDataReader rd = cmd2.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                detteTotal += decimal.Parse(rd["montant_restat"].ToString());
                                revenuTotal += decimal.Parse(rd["taux_interet"].ToString());
                            }
                            dettelabel.Text = detteTotal.ToString();
                            txtRevenuTotal.Text = revenuTotal.ToString();
                        }
                    }
                    soldeTotal = revenuTotal + detteTotal + clientTotal;
                    txtSoldeTotal.Text = soldeTotal.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex);
            } finally
            {
                sp.CloseConnection();
            }
        }

    }
}

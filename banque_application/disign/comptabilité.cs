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
using System.Windows.Forms.DataVisualization.Charting;
using banque_application.disgn;

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
            panel1.SetRoundedCorners(7);
            panel2.SetRoundedCorners(7);
            panel3.SetRoundedCorners(7);
            panel4.SetRoundedCorners(7);

            statistiquePanel.SetRoundedCorners(7);
            panel5.SetRoundedCorners(7);
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
                    soldeTotal =  detteTotal + clientTotal;
                    txtSoldeTotal.Text = soldeTotal.ToString();

                    Series serie = new Series();
                    serie.ChartType = SeriesChartType.Pie;

                    serie.Points.AddXY("",revenuTotal);
                    serie.Points.AddXY("",clientTotal);
                    serie.Points.AddXY("",detteTotal);

                    serie.Points[0].LegendText = "Revenu Total";
                    serie.Points[1].LegendText = "Solde Total";
                    serie.Points[2].LegendText = "Dette Total";

                    chart1.Series.Clear();
                    chart1.Series.Add(serie);

                    sp.CloseConnection();
                    lastTransaction();
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
        public void lastTransaction()
        {
            try
            {
                sp.OpenConnection();
                using (SqlConnection con = sp.GetConnection())
                {
                    dataGridView2.Rows.Clear();
                    dataGridView2.AllowUserToAddRows = false;
                    string req1 = "SELECT * FROM lastTransaction";

                    using (SqlCommand cmd1 = new SqlCommand(req1, con))
                    {
                        using (SqlDataReader rd = cmd1.ExecuteReader())
                        {
                            int idnumero = 1;
                            while (rd.Read())
                            {
                                string nom = rd["nom"].ToString();
                                string prenom = rd["prenom"].ToString();
                                string typeT = rd["type_transanction"].ToString();
                                string dateT = rd["date_transaction"].ToString();
                                string montantT = rd["montant"].ToString();
                                string idtransT = rd["id_transaction"].ToString();

                                string nomsBD = nom + "  " + prenom;

                                if (idnumero <= 11) { 
                                    dataGridView2.Rows.Add(idnumero, nomsBD, typeT,  dateT, montantT, idtransT);
                                } else
                                {
                                    break;
                                }
                                idnumero ++;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex);
            }
            finally
            {
                sp.CloseConnection();
            }
        }

    }
}

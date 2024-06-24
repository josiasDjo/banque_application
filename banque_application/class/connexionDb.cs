using DevExpress.Utils.Html;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banque_application.disign
{
    partial class service_personnel
    {

        public string connexion = "Data Source=DJODEV;Initial Catalog=COMPTABILITE_BANQUE_EXAMEN;Integrated Security=True";
        public SqlConnection connection;

        //public service_personnel()
        //{
        //}

        public SqlConnection GetConnection()
        {          
            return connection;
        }

        public void OpenConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                    MessageBox.Show("Connexion réussie ! ");
                }
                else
                {
                    MessageBox.Show("Connexion encore fermé");
                }
            } catch (SqlException exc)
            {
                MessageBox.Show("Erreur : " + exc.Message);
            }

        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}

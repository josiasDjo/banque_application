using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banque_application
{
    class connexionDb
    {
        public SqlConnection reqSql;
        public string connexion = "Data Source=DJODEV;Initial Catalog=COMPTABILITE_BANQUE_EXAMEN;Integrated Security=True";

        public void connDb()
        {
            try
            {
                reqSql = new SqlConnection(connexion);
                //reqSql.Open();
                MessageBox.Show("Connexion ouverte");
            }
            catch (SqlException exc)
            {
                MessageBox.Show("Une erreur s'est produite lors de la connexion : " + exc);
            } 
            finally
            {
                if (reqSql != null && reqSql.State == ConnectionState.Open)
                {
                    reqSql.Close();
                    reqSql.Dispose();
                }
            }
        }
    }
}

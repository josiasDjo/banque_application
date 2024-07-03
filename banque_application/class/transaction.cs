using DevExpress.XtraEditors.Filtering.Templates;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace banque_application.classes
{
    class transaction
{
        string id_trasenction;
        DateTime date_transaction;
        decimal montant;
        string type_trasenction;
        int compte_beneficiaire;
        int compte_source;
        string id_compte;
        string id_compte_agence;

        public string Id_trasenction
        {
            get
            {
                return id_trasenction;
            }

            set
            {
                id_trasenction = value;
            }
        }

        public DateTime Date_transaction
        {
            get
            {
                return date_transaction;
            }

            set
            {
                date_transaction = value;
            }
        }

        public decimal Montant
        {
            get
            {
                return montant;
            }

            set
            {
                montant = value;
            }
        }

        public string Type_trasenction
        {
            get
            {
                return type_trasenction;
            }

            set
            {
                type_trasenction = value;
            }
        }

        public int Compte_beneficiaire
        {
            get
            {
                return compte_beneficiaire;
            }

            set
            {
                compte_beneficiaire = value;
            }
        }

        public string Id_compte
        {
            get
            {
                return id_compte;
            }

            set
            {
                id_compte = value;
            }
        }

        public string Id_compte_agence
        {
            get
            {
                return id_compte_agence;
            }

            set
            {
                id_compte_agence = value;
            }
        }

        public int Compte_source
        {
            get
            {
                return compte_source;
            }

            set
            {
                compte_source = value;
            }
        }
    }
}

namespace banque_application.disign
{
    public partial class depot
    {
        //============================ajout Transection==============
        public void EnregistrerTrans()
        {
            etatDeSorti etSorti = new etatDeSorti();
            service_personnel sp = new service_personnel();
            try
            {
                sp.OpenConnection();
                using (SqlConnection con = sp.GetConnection())
                {
                    string req = "INSERT INTO tTransaction (id_transaction,date_transaction,montant,type_transanction,compte_source,compte_beneficiaire,id_compte) values (@i,@date,@montant,@type,@source,@ben,@id_compte)";
                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {
                        cmd.Parameters.AddWithValue("@i", Id_trasenction);
                        cmd.Parameters.AddWithValue("@date", dateTransaction);
                        cmd.Parameters.AddWithValue("@montant", solde);
                        cmd.Parameters.AddWithValue("@type", typeTransaction);
                        cmd.Parameters.AddWithValue("@source", Compte_source);
                        cmd.Parameters.AddWithValue("@ben", Compte_beneficiaire);
                        cmd.Parameters.AddWithValue("@id_compte", id_compte);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Transaction  effectué avec succes");
                    }
                }
                sp.CloseConnection();
                soldeCompteChange();
            }
            catch (Exception ex)
            {
                MessageBox.Show("La transaction a échouée " + ex.Message);
            }
            finally
            {
                sp.CloseConnection();
            }
        }
        public void soldeCompteChange()
        {
            etatDeSorti etSorti = new etatDeSorti();
            service_personnel sp = new service_personnel();
            try
            {
                sp.OpenConnection();
                using (SqlConnection con = sp.GetConnection())
                {
                    string req = "UPDATE  tCompte set solde_compte=@soldeCompte  where id_compte=@i";
                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {
                        cmd.Parameters.AddWithValue("@i", id_compte);
                        cmd.Parameters.AddWithValue("@soldeCompte", soldeCompteFinal);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                etSorti.nomEtat = nom;
                etSorti.prenomEtat = prenom;
                etSorti.montantEtat = solde;
                etSorti.dateToDayEtat = dateTransaction;
                etSorti.idTransactionEtat = Id_trasenction;
                etSorti.adresseEtat = adresse;
                etSorti.phoneEtat = phone;
                etSorti.typeTransEtat = typeTransaction;

                etSorti.Main();

                etSorti.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("La transaction a échouée " + ex.Message);
            }
            finally
            {
                sp.CloseConnection();
            }
        }
    }
}

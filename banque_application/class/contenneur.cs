using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace banque_application.classes
{
    class contenneur
    {
        //contenneur con = null;
        //contenneur cmd = null;
        //contenneur dt = null;
        //contenneur dr = null;
        //DataSet ds = null;

        public static contenneur _instance = null;
        connexionDb conndb = new connexionDb();
        public static contenneur GetInstance()
        {
            if (_instance == null)
                _instance = new contenneur();
            return _instance;
        }

        void InnitialiseConnection()
        {
            connexionDb conndb = new connexionDb();
            conndb.connDb();
            if (conndb.reqSql == null && conndb.reqSql.State == ConnectionState.Open)
            {
                conndb.reqSql.Open();
            } else
            {
                conndb.reqSql.Close();
                conndb.reqSql.Dispose();
            }
            //con = new SqlConnection(connexion.Accesbd);
        }



       // ============================fonction pour la supression==========

        public void Supprimer(string nomTable, string nomChamp, string valeur)
        {
            try
            {
                InnitialiseConnection();
                using (SqlConnection con = new SqlConnection(conndb.connexion))
                {
                    string sqlReq = "delete from " + nomTable + " where " + nomChamp + "=@id";
                    using (SqlCommand cmd = new SqlCommand(sqlReq, con))
                    {
                        cmd.Parameters.AddWithValue("@id", valeur);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Suppression reussie");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                conndb.reqSql.Close();
                conndb.reqSql.Dispose();
            }
        }
        //=========================chargement des donnees================

        public DataTable ChargerData(string nomTable)
        {
            InnitialiseConnection();

            if (conndb.reqSql.State != ConnectionState.Open)
            {
                conndb.connDb();
            }
            try
            {
                using (SqlConnection con = new SqlConnection(conndb.connexion))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM " + nomTable, con))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataSet dataset = new DataSet();
                            da.Fill(dataset);
                            return dataset.Tables[0];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Gérer les exceptions, par exemple en les journalisant
                throw new Exception("Erreur lors du chargement des données", ex);
            }
            finally
            {
                if (conndb.reqSql.State == ConnectionState.Open)
                {
                    conndb.reqSql.Close();
                    conndb.reqSql.Dispose();
                }
            }



            //if (!con.State.ToString().Trim().ToLower().Equals("open")) con.Open();
            //cmd = new SqlCommand("SELECT * FROM " + nomTable + "", con);
            //dt = null;
            //dt = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //dt.Fill(ds);
            //con.Close();
            //return ds.Tables[0];
        }

        public DataSet get_Report_S(string nomTable)
        {
            DataSet datst = new DataSet();
            try
            {
                InnitialiseConnection();
                if (!conndb.reqSql.State.ToString().ToLower().Equals("open")) conndb.connDb();

                using (SqlConnection con = new SqlConnection(conndb.connexion))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM " + nomTable + " ", con))
                    {
                        using (SqlDataAdapter dt = new SqlDataAdapter(cmd))
                        {
                            //DataSet datst = new DataSet();
                            dt.Fill(datst, nomTable);

                            dt.Dispose();
                        }
                    }
                }

                //SqlCommand cmd = new SqlCommand("SELECT * FROM " + nomTable + " ", con);
                //dt = new SqlDataAdapter(cmd);
                //dst = new DataSet();
                //dt.Fill(dst, nomTable);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conndb.reqSql.Close();
                conndb.reqSql.Dispose();
            }
            return datst;
        }



        //=========== INSERTION ET MODIFICATION ==============================


        //======== ENREGISTREMENT POUR LE CLIENT ============================================


        public void EnregistrerClient(Client cls)
        {
            try
            {
                InnitialiseConnection();
                //con.Open();
                using (SqlConnection con = new SqlConnection(conndb.connexion))
                {
                    string req = "INSERT INTO tClient (id_client,nom,postnom,prenom,adresse,phone,date_naissance,photo) values (@i,@nom,@postnom,@prenom,@adresse,@phone,@date,@photo)";
                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {
                        cmd.Parameters.AddWithValue("@i", cls.Id_client);
                        cmd.Parameters.AddWithValue("@nom", cls.Nom);
                        cmd.Parameters.AddWithValue("@postnom", cls.Postnom);
                        cmd.Parameters.AddWithValue("@prenom", cls.Prenom);
                        cmd.Parameters.AddWithValue("@adresse", cls.Adresse);
                        cmd.Parameters.AddWithValue("@phone", cls.Phone);
                        cmd.Parameters.AddWithValue("@date", cls.Datenaissance);
                        cmd.Parameters.AddWithValue("@photo", cls.Photo);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Client enregistré avec succes");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conndb.reqSql.Close();
                conndb.reqSql.Dispose();
            }
        }

       // =========Modification du client ====================

        public void ModifierClient(Client cls)
        {
            try
            {
                InnitialiseConnection();
                //con.Open();
                using (SqlConnection con = new SqlConnection(conndb.connexion))
                {
                    string req = "UPDATE  tClient set nom=@nom,postnom=@postnom,prenom=@prenom,adresse=@adresse,phone=@phone,date_naissance=@date,photo =@photo  where id_client = @i";
                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {
                        cmd.Parameters.AddWithValue("@i", cls.Id_client);
                        cmd.Parameters.AddWithValue("@nom", cls.Nom);
                        cmd.Parameters.AddWithValue("@postnom", cls.Postnom);
                        cmd.Parameters.AddWithValue("@prenom", cls.Prenom);
                        cmd.Parameters.AddWithValue("@adresse", cls.Adresse);
                        cmd.Parameters.AddWithValue("@phone", cls.Phone);
                        cmd.Parameters.AddWithValue("@date", cls.Datenaissance);
                        cmd.Parameters.AddWithValue("@photo", cls.Photo);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Modification faite avec succes");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                conndb.reqSql.Close();
                conndb.reqSql.Dispose();
            }
        }



   //===============ajout d'une agence==================
        public void EnregistrerAgence(Agence ag)
        {
            try
            {
                InnitialiseConnection();
                //con.Open();
                using (SqlConnection con = new SqlConnection(conndb.connexion))
                {
                    string req = "INSERT INTO tAgence (id_agence,nom,adresse,phone) values (@i,@nom,@phone)";
                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {
                        cmd.Parameters.AddWithValue("@i", ag.Id_agence);
                        cmd.Parameters.AddWithValue("@nom", ag.Nom);
                        cmd.Parameters.AddWithValue("@phone", ag.Phone);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Agence ajouté avec succé");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                conndb.reqSql.Close();
                conndb.reqSql.Dispose();
            }
        }


    //  ============  modification agence=====
        public void ModifierAgene(Agence ag)
        {
            try
            {
                InnitialiseConnection();
                //con.Open();
                using (SqlConnection con = new SqlConnection(conndb.connexion))
                {
                    string req = "update tAgence set id_agence=@i, nom=@nom, phone=@phone where id_agence=@id";
                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {
                        cmd.Parameters.AddWithValue("@i", ag.Id_agence);
                        cmd.Parameters.AddWithValue("@nom", ag.Nom);
                        cmd.Parameters.AddWithValue("@phone", ag.Phone);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("l'agent a été modifié");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conndb.reqSql.Close();
                conndb.reqSql.Dispose();
            }
        }




        //===============ajout d'une carte==================
        public void EnregistrerCarte(Carte ca)
        {
            try
            {
                InnitialiseConnection();
                //con.Open();
                using (SqlConnection con = new SqlConnection(conndb.connexion))
                {
                    string req = "INSERT INTO tCarte (id_carte,numero_carte,type_carte,date_expiration) values (@i,@num,@type,@date)";
                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {
                        cmd.Parameters.AddWithValue("@i", ca.Id_carte);
                        cmd.Parameters.AddWithValue("@num", ca.Numero_carte);
                        cmd.Parameters.AddWithValue("@type", ca.Type_carte);
                        cmd.Parameters.AddWithValue("@date", ca.Date_expiration);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Enregistrement reussi");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conndb.reqSql.Close();
                conndb.reqSql.Dispose();
            }
        }

        //  ============  modification carte=====
        public void ModifierCarte(Carte ca)
        {
            try
            {
                InnitialiseConnection();
                //con.Open();
                using (SqlConnection con = new SqlConnection(conndb.connexion))
                {
                    string req = "update tCarte set id_carte=@i, numero_carte=@num, type_carte=@type where id_agence=@id";
                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {
                        cmd.Parameters.AddWithValue("@i", ca.Id_carte);
                        cmd.Parameters.AddWithValue("@num", ca.Numero_carte);
                        cmd.Parameters.AddWithValue("@type", ca.Type_carte);
                        cmd.Parameters.AddWithValue("@date", ca.Date_expiration);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Modification reussie");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conndb.reqSql.Close();
                conndb.reqSql.Dispose();
            }
        }

        //===============ajout d'un compte==================
        public void EnregistrerCompte(compte co)
        {
            try
            {
                InnitialiseConnection();
                //con.Open();
                using (SqlConnection con = new SqlConnection(conndb.connexion))
                {
                    string req = "INSERT INTO tCompte (id_compte,num_compte,type_compte,solde_compte,date_ouverture,code_securite) values (@i,@num,@type,@solde,@date,@sec)";
                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {
                        cmd.Parameters.AddWithValue("@i", co.Id_carte);
                        cmd.Parameters.AddWithValue("@num", co.Num_compte);
                        cmd.Parameters.AddWithValue("@type", co.Type_compte);
                        cmd.Parameters.AddWithValue("@solde", co.Solde_compte);
                        cmd.Parameters.AddWithValue("@date", co.Date_ouverture);
                        cmd.Parameters.AddWithValue("@sec", co.Code_securite);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Enregistrement reussi");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conndb.reqSql.Close();
                conndb.reqSql.Dispose();
            }
        }

        //  ============  modification =====
        public void ModifierCompte(compte co)
        {
            try
            {
                InnitialiseConnection();
                //con.Open();
                using (SqlConnection con = new SqlConnection(conndb.connexion))
                {
                    string req = "update tCompte set id_compte=@i, numero_compte=@num, type_compte=@type, solde_compte=@solde,date_ouverture=@date,code_securite=@sec where id_compte=@id";
                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {
                        cmd.Parameters.AddWithValue("@i", co.Id_carte);
                        cmd.Parameters.AddWithValue("@num", co.Num_compte);
                        cmd.Parameters.AddWithValue("@type", co.Type_compte);
                        cmd.Parameters.AddWithValue("@solde", co.Solde_compte);
                        cmd.Parameters.AddWithValue("@date", co.Date_ouverture);
                        cmd.Parameters.AddWithValue("@sec", co.Code_securite);
                        cmd.ExecuteNonQuery();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Modification reussie");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conndb.reqSql.Close();
                conndb.reqSql.Dispose();
            }
        }

        //===============ajout d'un compte d'agnce==================

        public void EnregistrerComptA(compteAgence cA)
        {
            try
            {
                InnitialiseConnection();
                //con.Open();
                using (SqlConnection con = new SqlConnection(conndb.connexion))
                {
                    string req = "INSERT INTO tCompteAgence (id_compte_agance) values (@i)";
                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {
                        cmd.Parameters.AddWithValue("@i", cA.Id_compte_agence);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Enregistrement reussi");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conndb.reqSql.Close();
                conndb.reqSql.Dispose();
            }
        }

        //  ============  modification compteAgence=====
        public void ModifierCompteA(compteAgence cA)
        {
            try
            {
                InnitialiseConnection();
                //con.Open();
                using (SqlConnection con = new SqlConnection(conndb.connexion))
                {
                    string req = "update tCompteAgence set id_compte_agance=@i,  where id_compte_agence=@id";
                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {
                        cmd.Parameters.AddWithValue("@i", cA.Id_compte_agence);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Modification reussie");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conndb.reqSql.Close();
                conndb.reqSql.Dispose();
            }
        }


        //============================ajout d'un employe==============
        public void EnregistrerEmploye()
        {
            Employe em = new Employe();
            MessageBox.Show("Backend activer");
            try
            {
                InnitialiseConnection();
                //conndb.reqSql.Open();
                using (SqlConnection con = new SqlConnection(conndb.connexion))
                {
                    string req = "INSERT INTO tEmploye (id_employe,nom,postnom,prenom,grade,date_Embauche,contact,salaire) values (@i,@nom,@postnom,@prenom,@grade,@date,@contact,@salaire)";
                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {
                        cmd.Parameters.AddWithValue("@i", em.Id_employe);
                        cmd.Parameters.AddWithValue("@nom", em.Nom);
                        cmd.Parameters.AddWithValue("@postnom", em.Postnom);
                        cmd.Parameters.AddWithValue("@prenom", em.Prenom);
                        cmd.Parameters.AddWithValue("@grade", em.Grade);
                        cmd.Parameters.AddWithValue("@date", em.Date_embauche);
                        cmd.Parameters.AddWithValue("@contact", em.Contact);
                        cmd.Parameters.AddWithValue("@salaire", em.Salaire);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Enregistrement reussi");
                    }
                }              
            }
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            catch (SqlException exc)
            {
                MessageBox.Show("Erreur : " + exc);
            }
            finally
            {
                if (conndb.reqSql != null && conndb.reqSql.State == ConnectionState.Open)
                {
                    conndb.reqSql.Close();
                    conndb.reqSql.Dispose();
                }
            }
        }

        // =========Modification de l'employe ====================

        public void ModifierEmploye(Employe em)
        {
            try
            {
                InnitialiseConnection();
                //con.Open();
                using (SqlConnection con = new SqlConnection(conndb.connexion))
                {
                    string req = "UPDATE  tEmploye set nom=@nom,postnom=@postnom,prenom=@prenom,grade=@grsde,date_Embauche=@date,contact =@contact,salaire=@salaire  where id_Employe = @i";
                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {
                        cmd.Parameters.AddWithValue("@i", em.Id_employe);
                        cmd.Parameters.AddWithValue("@nom", em.Nom);
                        cmd.Parameters.AddWithValue("@postnom", em.Postnom);
                        cmd.Parameters.AddWithValue("@prenom", em.Prenom);
                        cmd.Parameters.AddWithValue("@grade", em.Grade);
                        cmd.Parameters.AddWithValue("@date", em.Date_embauche);
                        cmd.Parameters.AddWithValue("@contact", em.Contact);
                        cmd.Parameters.AddWithValue("@salaire", em.Salaire);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Enregistrement reussi");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conndb.reqSql.Close();
                conndb.reqSql.Dispose();
            }
        }




        //===============ajout d'un paye pret==================
        public void EnregistrerPayP(PayementPret pp)
        {
            try
            {
                InnitialiseConnection();
                //con.Open();
                using (SqlConnection con = new SqlConnection(conndb.connexion))
                {
                    string req = "INSERT INTO tPayementPret (id_payement,date_payement,montant_paye) values (@i,@date,@montant)";
                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {
                        cmd.Parameters.AddWithValue("@i", pp.Id_payement);
                        cmd.Parameters.AddWithValue("@date", pp.Date_payement);
                        cmd.Parameters.AddWithValue("@montant", pp.Montant_paye);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Enregistrement reussi");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conndb.reqSql.Close();
                conndb.reqSql.Dispose();
            }
        }


        //  ============  modification PayePret=====
        public void ModifierAgene(PayementPret pp)
        {
            try
            {
                InnitialiseConnection();
                //con.Open();
                using (SqlConnection con = new SqlConnection(conndb.connexion))
                {
                    string req = "update tPayementPret set id_payement=@i,date_payement=@date,montant_paye=@montant where id_Payement=@id";
                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {
                        cmd.Parameters.AddWithValue("@i", pp.Id_payement);
                        cmd.Parameters.AddWithValue("@date", pp.Date_payement);
                        cmd.Parameters.AddWithValue("@montant", pp.Montant_paye);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Modification reussie");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conndb.reqSql.Close();
                conndb.reqSql.Dispose();
            }
        }



        //============================ajout d'un pret=====================
        public void EnregistrerPret(Pret p)
        {
            try
            {
                InnitialiseConnection();
                //con.Open();
                using (SqlConnection con = new SqlConnection(conndb.connexion))
                {
                    string req = "INSERT INTO tPret (id_pret,date_debut,date_fin,taux_interet,montan_total,montant_restant)  values (@i,@debut,@fin,@taux,@tmontant,@reste)";
                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {
                        cmd.Parameters.AddWithValue("@i", p.Id_pret);
                        cmd.Parameters.AddWithValue("@debut", p.Date_debut);
                        cmd.Parameters.AddWithValue("@fin", p.Date_fin);
                        cmd.Parameters.AddWithValue("@taux", p.Taux_interet);
                        cmd.Parameters.AddWithValue("@tmontant", p.Montant_total);
                        cmd.Parameters.AddWithValue("@reste", p.Montant_restant);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Enregistrement reussi");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conndb.reqSql.Close();
                conndb.reqSql.Dispose();
            }
        }

        // =========Modification du Pret ====================

        public void ModifierPret(Pret p)
        {
            try
            {
                InnitialiseConnection();
                //con.Open();
                using (SqlConnection con = new SqlConnection(conndb.connexion))
                {
                    string req = "UPDATE  tPret set id_pret=@i,date_debut=@debut,date_fin=@fin,taux_interet=@taux,montan_total=@tmontant,montant_restant=@reste where id_Pret=@i";
                    using (SqlCommand cmd =  new SqlCommand(req, con))
                    {
                        cmd.Parameters.AddWithValue("@i", p.Id_pret);
                        cmd.Parameters.AddWithValue("@debut", p.Date_debut);
                        cmd.Parameters.AddWithValue("@fin", p.Date_fin);
                        cmd.Parameters.AddWithValue("@taux", p.Taux_interet);
                        cmd.Parameters.AddWithValue("@tmontant", p.Montant_total);
                        cmd.Parameters.AddWithValue("@reste", p.Montant_restant);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Enregistrement reussi");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conndb.reqSql.Close();
                conndb.reqSql.Dispose();
            }
        }




        //============================ajout Transection==============
        public void EnregistrerTrans(transaction tr)
        {
            try
            {
                InnitialiseConnection();
                //con.Open();
                using (SqlConnection con = new SqlConnection(conndb.connexion))
                {
                    string req = "INSERT INTO tTransaction (id_transaction,date_trasanction,montant,type_transaction,compte_source,compte_beneficiaire ) values (@i,@date,@montant,@type,@source,@ben)";
                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {
                        cmd.Parameters.AddWithValue("@i", tr.Id_trasenction);
                        cmd.Parameters.AddWithValue("@date", tr.Date_transaction);
                        cmd.Parameters.AddWithValue("@montant", tr.Montant);
                        cmd.Parameters.AddWithValue("@type", tr.Type_trasenction);
                        cmd.Parameters.AddWithValue("@source", tr.Compte_source);
                        cmd.Parameters.AddWithValue("@ben", tr.Compte_beneficiaire);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Transaction  effectué avec succes");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conndb.reqSql.Close();
                conndb.reqSql.Dispose();
            }
        }

        // =========Modification Transaction ====================

        public void EffecTra(transaction tr)
        {
            try
            {
                InnitialiseConnection();
                //con.Open();
                using (SqlConnection con = new SqlConnection(conndb.connexion))
                {
                    string req = "UPDATE  tTransaction set id_transaction=@i,date_trasanction=@date,montant=@montant,type_transaction=@type,compte_source=@source,compte_beneficiaire=ben where id_transaction=@i";
                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {
                        cmd.Parameters.AddWithValue("@i", tr.Id_trasenction);
                        cmd.Parameters.AddWithValue("@date", tr.Date_transaction);
                        cmd.Parameters.AddWithValue("@montant", tr.Montant);
                        cmd.Parameters.AddWithValue("@type", tr.Type_trasenction);
                        cmd.Parameters.AddWithValue("@source", tr.Compte_source);
                        cmd.Parameters.AddWithValue("@ben", tr.Compte_beneficiaire);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Modification reussi");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conndb.reqSql.Close();
                conndb.reqSql.Dispose();
            }
        }


       // =====================ajout user===============

        public void EnregistrerUser(User u)
        {
            try
            {
                InnitialiseConnection();
                //con.Open();
                using (SqlConnection con = new SqlConnection(conndb.connexion))
                {
                    string req = "INSERT INTO tUser (matricule,nom,postnom,prenom,mot_de_pass) values  (@m,@nom,@postnom,@prenom,@code)";
                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {
                        cmd.Parameters.AddWithValue("@m", u.Matricule);
                        cmd.Parameters.AddWithValue("@nom", u.Nom);
                        cmd.Parameters.AddWithValue("@postnom", u.Postnom);
                        cmd.Parameters.AddWithValue("@prenom", u.Prenom);
                        cmd.Parameters.AddWithValue("@code", u.Mot_de_pass);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("User ajouté avec succes");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conndb.reqSql.Close();
                conndb.reqSql.Dispose();
            }
        }

        // =========Modification du user ====================

        public void AddUser(User u)
        {
            try
            {
                InnitialiseConnection();
                //con.Open();
                using (SqlConnection con = new SqlConnection(conndb.connexion))
                {
                    string req = "UPDATE  tUser set matricule=@m,nom=@nom,postnom=@postnom,prenom=@prenom,mot_de_pass=@code  where matricule = @m";
                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {
                        cmd.Parameters.AddWithValue("@m", u.Matricule);
                        cmd.Parameters.AddWithValue("@nom", u.Nom);
                        cmd.Parameters.AddWithValue("@postnom", u.Postnom);
                        cmd.Parameters.AddWithValue("@prenom", u.Prenom);
                        cmd.Parameters.AddWithValue("@code", u.Mot_de_pass);

                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Modification faite avec succes");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conndb.reqSql.Close();
                conndb.reqSql.Dispose();
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using banque_application.disign;
using banque_application.classes;
using banque_application;
using System.Windows;
using MessageBox = System.Windows.Forms.MessageBox;

namespace banque_application.disign
{
    partial class service_personnel
    {
        service_personnel con = null;
        service_personnel cmd = null;
        service_personnel dt = null;
        service_personnel dr = null;
        DataSet ds = null;

        public static service_personnel _instance = null;
        public static service_personnel GetInstance()
        {
            if (_instance == null)
                _instance = new service_personnel();
            return _instance;
        }

        // ============================fonction pour la supression==========

        public void Supprimer(string nomTable, string nomChamp, string valeur)
        {
            try
            {
                OpenConnection();
                using (SqlConnection con = new SqlConnection(connexion))
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
            }
            finally
            {
                CloseConnection();
            }
        }
        //=========================chargement des donnees================

        public DataTable ChargerData(string nomTable)
        {
            OpenConnection();
            try
            {
                using (SqlConnection con = new SqlConnection(connexion))
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
                CloseConnection();
            }
        }

    public DataSet get_Report_S(string nomTable)
        {
            DataSet datst = new DataSet();
            try
            {
                OpenConnection();

                using (SqlConnection con = new SqlConnection(connexion))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM " + nomTable + " ", con))
                    {
                        using (SqlDataAdapter dt = new SqlDataAdapter(cmd))
                        {
                            dt.Fill(datst, nomTable);
                            dt.Dispose();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return datst;
        }



        //=========== INSERTION ET MODIFICATION ==============================


        //======== ENREGISTREMENT POUR LE CLIENT ============================================


        public void EnregistrerClient()
        {
            Client cls = new Client();
            try
            {
                OpenConnection();

                SqlConnection connection = GetConnection();
                MessageBox.Show("Ident : " + cls.Id_client + " " + cls.Prenom);

                    string req = "INSERT INTO tClient (id_client,nom,postnom,prenom,adresse,phone,date_naissance,photo) values (@i,@nom,@postnom,@prenom,@adresse,@phone,@date,@photo)";
                    using (SqlCommand cmd = new SqlCommand(req, connection))
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
                        MessageBox.Show("Client enregistré avec succes");
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        // =========Modification du client ====================

        public void ModifierClient()
        {
            try
            {
                OpenConnection();
                Client cls = new Client();
                using (SqlConnection con = new SqlConnection(connexion))
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
            }
            finally
            {
                CloseConnection();
            }
        }



        //===============ajout d'une agence==================
        public void EnregistrerAgence()
        {
            Agence ag = new Agence();
            try
            {
                OpenConnection();
                using (SqlConnection con = new SqlConnection(connexion))
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
            }
            finally
            {
                CloseConnection();
            }
        }


        //  ============  modification agence=====
        public void ModifierAgene()
        {
            Agence ag = new Agence();
            try
            {
                OpenConnection();
                using (SqlConnection con = new SqlConnection(connexion))
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
                CloseConnection();
            }
        }




        //===============ajout d'une carte==================
        public void EnregistrerCarte()
        {
            Carte ca = new Carte();
            try
            {
                OpenConnection();
                using (SqlConnection con = new SqlConnection(connexion))
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
                CloseConnection();
            }
        }

        //  ============  modification carte=====
        public void ModifierCarte()
        {
            Carte ca = new Carte();
            try
            {
                OpenConnection();
                using (SqlConnection con = new SqlConnection(connexion))
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
                CloseConnection();
            }
        }

        //===============ajout d'un compte==================
        public void EnregistrerCompte()
        {
            try
            {
                compte co = new compte();
                using (SqlConnection con = new SqlConnection(connexion))
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
                CloseConnection();
            }
        }

        //  ============  modification =====
        public void ModifierCompte()
        {
            compte co = new compte();
            try
            {
                OpenConnection();
                using (SqlConnection con = new SqlConnection(connexion))
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
                CloseConnection();
            }
        }

        //===============ajout d'un compte d'agnce==================

        public void EnregistrerComptA()
        {
            compteAgence cA = new compteAgence();
            try
            {
                OpenConnection();
                using (SqlConnection con = new SqlConnection(connexion))
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
                CloseConnection();
            }
        }

        //  ============  modification compteAgence=====
        public void ModifierCompteA()
        {
            compteAgence cA = new compteAgence();
            try
            {
                OpenConnection();
                using (SqlConnection con = new SqlConnection(connexion))
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
                CloseConnection();
            }
        }


        //============================ajout d'un employe==============
        public void EnregistrerEmploye()
        {
            //service_personnel srv = new service_personnel();

            try
            {
                OpenConnection();
                Employe em = new Employe();
                using (SqlConnection con = new SqlConnection(connexion))
                {
                    con.Open();
                    if (em.Id_employe == "")
                    {
                        MessageBox.Show("ne peut pas contenir des valeur null");
                    }
                    else
                    {
                        //MessageBox.Show("id : " + em.Id_employe);
                    }
                    string req = "INSERT INTO tEmploye (id_employe,nom,postnom,prenom,grade,date_Embauche,contact,salaire,mdp) values (@i,@nom,@postnom,@prenom,@grade,@date,@contact,@salaire,@mdp)";
                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {
                        cmd.Parameters.AddWithValue("@i", id_employeB ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@nom", nomB ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@postnom", postnomB ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@prenom", prenomB ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@grade", gradeB ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@date", date_embaucheB ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@contact", contactB ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@salaire", salaireB);
                        cmd.Parameters.AddWithValue("@mdp", passwordEmplye);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Enregistrement reussi");
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        // =========Modification de l'employe ====================

        public void ModifierEmploye()
        {
            try
            {
                OpenConnection();
                using (SqlConnection con = new SqlConnection(connexion))
                {
                    string req = "UPDATE  tEmploye set nom=@nom,postnom=@postnom,prenom=@prenom,grade=@grsde,date_Embauche=@date,contact =@contact,salaire=@salaire  where id_Employe = @i";
                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {
                        cmd.Parameters.AddWithValue("@i", id_employeB ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@nom", nomB ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@postnom", postnomB ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@prenom", prenomB ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@grade", gradeB ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@date", date_embaucheB ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@contact", contactB ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@salaire", salaireB);
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
                CloseConnection();
            }
        }




        //===============ajout d'un paye pret==================
        public void EnregistrerPayP()
        {
            PayementPret pp = new PayementPret();
            try
            {
                OpenConnection();
                using (SqlConnection con = new SqlConnection(connexion))
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
                CloseConnection();
            }
        }


        //  ============  modification PayePret=====
        public void ModifierPayementPret()
        {
            PayementPret pp = new PayementPret();
            try
            {
                OpenConnection();
                using (SqlConnection con = new SqlConnection(connexion))
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
                CloseConnection();
            }
        }



        //============================ajout d'un pret=====================
        public void EnregistrerPret()
        {
            try
            {
                OpenConnection();

                Pret p = new Pret();

                using (SqlConnection con = new SqlConnection(connexion))
                {
                    string req = "INSERT INTO tPret (id_pret,date_debut,date_fin,taux_interet,montan_total,montant_restat)  values (@i,@debut,@fin,@taux,@tmontant,@reste)";
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
                CloseConnection();
            }
        }

        // =========Modification du Pret ====================

        public void ModifierPret()
        {
            Pret p = new Pret();
            try
            {
                OpenConnection();
                using (SqlConnection con = new SqlConnection(connexion))
                {
                    string req = "UPDATE  tPret set id_pret=@i,date_debut=@debut,date_fin=@fin,taux_interet=@taux,montan_total=@tmontant,montant_restant=@reste where id_Pret=@i";
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
                CloseConnection();
            }
        }




        //============================ajout Transection==============
        public void EnregistrerTrans()
        {
            try
            {
                OpenConnection();
                transaction tr = new transaction();
                using (SqlConnection con = new SqlConnection(connexion))
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
                CloseConnection();
            }
        }

        // =========Modification Transaction ====================

        public void EffecTra()
        {
            transaction tr = new transaction();
            try
            {
                OpenConnection();
                using (SqlConnection con = new SqlConnection(connexion))
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
                CloseConnection();
            }
        }


        // =====================ajout user===============

        public void EnregistrerUser()
        {
            User u = new User();
            try
            {
                OpenConnection();
                using (SqlConnection con = new SqlConnection(connexion))
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
                CloseConnection();
            }
        }

        //        // =========Modification du user ====================

        public void AddUser()
        {
            try
            {
                User u = new User();
                OpenConnection();
                using (SqlConnection con = new SqlConnection(connexion))
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
                CloseConnection();
            }
        }
    }
}

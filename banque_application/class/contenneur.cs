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
        contenneur con = null;
        contenneur cmd = null;
        contenneur dt = null;
        contenneur dr = null;
        DataSet ds = null;

        public static contenneur _instance = null;
        public static contenneur GetInstance()
        {
            if (_instance == null)
                _instance = new contenneur();
            return _instance;
        }

        void InnitialiseConnection()
        {
            con = new SqlConnection(Connexiondb.Accesbd);
        }



       // ============================fonction pour la supression==========

        public void Supprimer(string nomTable, string nomChamp, string valeur)
        {
            try
            {
                InnitialiseConnection();
                con.Open();
                cmd = new SqlCommand("delete from " + nomTable + " where " + nomChamp + "=@id", con);
                cmd.Parameters.AddWithValue("@id", valeur);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Suppression reussie");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //=========================chargement des donnees================

        public DataTable ChargerData(string nomTable)
        {
            InnitialiseConnection();
            if (!con.State.ToString().Trim().ToLower().Equals("open")) con.Open();
            cmd = new SqlCommand("SELECT * FROM " + nomTable + "", con);
            dt = null;
            dt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dt.Fill(ds);
            con.Close();
            return ds.Tables[0];
        }

        public DataSet get_Report_S(string nomTable)
        {
            DataSet dst;
            try
            {
                InnitialiseConnection();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM " + nomTable + " ", con);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, nomTable);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose(); con.Close();
            }
            return dst;
        }



        //=========== INSERTION ET MODIFICATION ==============================


        //======== ENREGISTREMENT POUR LE CLIENT ============================================


        public void EnregistrerClient(Client cls)
        {
            try
            {
                InnitialiseConnection();
                con.Open();
                cmd = new SqlCommand("INSERT INTO tClient (id_client,nom,postnom,prenom,adresse,phone,date_naissance,photo) values (@i,@nom,@postnom,@prenom,@adresse,@phone,@date,@photo)", con);
                cmd.Parameters.AddWithValue("@i", cls.Id_client);
                cmd.Parameters.AddWithValue("@nom", cls.Nom);
                cmd.Parameters.AddWithValue("@postnom", cls.Postnom);
                cmd.Parameters.AddWithValue("@prenom", cls.Prenom);
                cmd.Parameters.AddWithValue("@adresse", cls.Adresse);
                cmd.Parameters.AddWithValue("@phone", cls.Phone);
                cmd.Parameters.AsswithValue("@date", cls.Datenaissance);
                cmd.Parameters.AsswithValue("@photo", cls.Photo);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Client enregistré avec succes");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       // =========Modification du client ====================

        public void ModifierClient(Client cls)
        {
            try
            {
                InnitialiseConnection();
                con.Open();
                cmd = new SqlCommand("UPDATE  tClient set nom=@nom,postnom=@postnom,prenom=@prenom,adresse=@adresse,phone=@phone,date_naissance=@date,photo =@photo  where id_client = @i", con);
                cmd.Parameters.AddWithValue("@i", cls.Id_client);
                cmd.Parameters.AddWithValue("@nom", cls.Nom);
                cmd.Parameters.AddWithValue("@postnom", cls.Postnom);
                cmd.Parameters.AddWithValue("@prenom", cls.Prenom);
                cmd.Parameters.AddWithValue("@adresse", cls.Adresse);
                cmd.Parameters.AddWithValue("@phone", cls.Phone);
                cmd.Parameters.AsswithValue("@date", cls.Datenaissance);
                cmd.Parameters.AsswithValue("@photo", cls.Photo);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Modification faite avec succes");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



   //===============ajout d'une agance==================
        public void EnregistrerAgence(Agence ag)
        {
            try
            {
                InnitialiseConnection();
                con.Open();
                cmd = new SqlCommand("INSERT INTO tAgence (id_agence,nom,adresse,phone) values (@i,@nom,@phone)", con);
                cmd.Parameters.AddWithValue("@i", ag.Id_agence);
                cmd.Parameters.AddWithValue("@nom", ag.Nom);
                cmd.Parameters.AddWithValue("@phone", ag.Phone);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Agance ajouté avec succé");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    //  ============  modification agence=====
        public void ModifierAgene(Agence ag)
        {
            try
            {
                InnitialiseConnection();
                con.Open();
                cmd = new SqlCommand("update tAgence set id_agence=@i, nom=@nom, phone=@phone where id_agence=@id", con);
                cmd.Parameters.AddWithValue("@i", ag.Id_agence);
                cmd.Parameters.AddWithValue("@nom", ag.Nom);
                cmd.Parameters.AddWithValue("@phone", ag.Phone)
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("l'agant a été modifié");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        //===============ajout d'une carte==================
        public void EnregistrerCarte(Carte ca)
        {
            try
            {
                InnitialiseConnection();
                con.Open();
                cmd = new SqlCommand("INSERT INTO tCarte (id_carte,numero_carte,type_carte,date_expiration) values (@i,@num,@type,@date)", con);
                cmd.Parameters.AddWithValue("@i", ca.Id_carte);
                cmd.Parameters.AddWithValue("@num", ca.Numero_carte);
                cmd.Parameters.AddWithValue("@type", ca.Type_carte);
                cmd.Parameters.AddWithValue("@date", ca.Date_expiration);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Enregistrement reussi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //  ============  modification carte=====
        public void ModifierCarte(Carte ca)
        {
            try
            {
                InnitialiseConnection();
                con.Open();
                cmd = new SqlCommand("update tCarte set id_carte=@i, numero_carte=@num, type_carte=@type where id_agence=@id", con);
                cmd.Parameters.AddWithValue("@i", ca.Id_carte);
                cmd.Parameters.AddWithValue("@num", ca.Numero_carte);
                cmd.Parameters.AddWithValue("@type", ca.Type_carte);
                cmd.Parameters.AddWithValue("@date", ca.Date_expiration);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Modification reussie");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //===============ajout d'un compte==================
        public void EnregistrerCompte(compte co)
        {
            try
            {
                InnitialiseConnection();
                con.Open();
                cmd = new SqlCommand("INSERT INTO tCompte (id_compte,num_compte,type_compte,solde_compte,date_ouverture,code_securite) values (@i,@num,@type,@solde,@date,@sec)", con);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //  ============  modification =====
        public void ModifierCompte(compte co)
        {
            try
            {
                InnitialiseConnection();
                con.Open();
                cmd = new SqlCommand("update tCompte set id_compte=@i, numero_compte=@num, type_compte=@type, solde_compte=@solde,date_ouverture=@date,code_securite=@sec where id_compte=@id", con);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //===============ajout d'un compte d'agance==================

        public void EnregistrerComptA(compteAgence cA)
        {
            try
            {
                InnitialiseConnection();
                con.Open();
                cmd = new SqlCommand("INSERT INTO tCompteAgence (id_compte_agance) values (@i)", con);
                cmd.Parameters.AddWithValue("@i", cA.Id_compte_agence);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Enregistrement reussi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //  ============  modification compteAgence=====
        public void ModifierCompteA(compteAgence cA)
        {
            try
            {
                InnitialiseConnection();
                con.Open();
                cmd = new SqlCommand("update tCompteAgence set id_compte_agance=@i,  where id_compte_agence=@id", con);
                cmd.Parameters.AddWithValue("@i", cA.Id_compte_agence);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Modification reussie");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //============================ajout d'un employe==============
        public void EnregistrerEmploye(Employe em)
        {
            try
            {
                InnitialiseConnection();
                con.Open();
                cmd = new SqlCommand("INSERT INTO tEmploye (id_employe,nom,postnom,prenom,grade,date_Embauche,contact,salaire) values (@i,@nom,@postnom,@prenom,@grade,@date,@contact,@salaire)", con);
                cmd.Parameters.AddWithValue("@i", em.Id_employe);
                cmd.Parameters.AddWithValue("@nom", em.Nom);
                cmd.Parameters.AddWithValue("@postnom", em.Postnom);
                cmd.Parameters.AddWithValue("@prenom", em.Prenom);
                cmd.Parameters.AddWithValue("@grade", em.Grade);
                cmd.Parameters.AddWithValue("@date", em.Date_embauche);
                cmd.Parameters.AsswithValue("@contact", em.Contact);
                cmd.Parameters.AsswithValue("@salaire", em.Salaire);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Enregistrement reussi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =========Modification de l'employe ====================

        public void ModifierEmploye(Employe em)
        {
            try
            {
                InnitialiseConnection();
                con.Open();
                cmd = new SqlCommand("UPDATE  tEmploye set nom=@nom,postnom=@postnom,prenom=@prenom,grade=@grsde,date_Embauche=@date,contact =@contact,salaire=@salaire  where id_Employe = @i", con);
                cmd.Parameters.AddWithValue("@i", em.Id_employe);
                cmd.Parameters.AddWithValue("@nom", em.Nom);
                cmd.Parameters.AddWithValue("@postnom", em.Postnom);
                cmd.Parameters.AddWithValue("@prenom", em.Prenom);
                cmd.Parameters.AddWithValue("@grade", em.Grade);
                cmd.Parameters.AddWithValue("@date", em.Date_embauche);
                cmd.Parameters.AsswithValue("@contact", em.Contact);
                cmd.Parameters.AsswithValue("@salaire", em.Salaire);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Enregistrement reussi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        //===============ajout d'un paye pret==================
        public void EnregistrerPayP(PayementPret pp)
        {
            try
            {
                InnitialiseConnection();
                con.Open();
                cmd = new SqlCommand("INSERT INTO tPayementPret (id_payement,date_payement,montant_paye) values (@i,@date,@montant)", con);
                cmd.Parameters.AddWithValue("@i", pp.Id_payement);
                cmd.Parameters.AddWithValue("@date", pp.Date_payement);
                cmd.Parameters.AddWithValue("@montant", pp.Montant_paye);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Enregistrement reussi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //  ============  modification PayePret=====
        public void ModifierAgene(PayementPret pp)
        {
            try
            {
                InnitialiseConnection();
                con.Open();
                cmd = new SqlCommand("update tPayementPret set id_payement=@i,date_payement=@date,montant_paye=@montant where id_Payement=@id" , con);
                cmd.Parameters.AddWithValue("@i", pp.Id_payement);
                cmd.Parameters.AddWithValue("@date", pp.Date_payement);
                cmd.Parameters.AddWithValue("@montant", pp.Montant_paye);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Modification reussie");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //============================ajout d'un pret=====================
        public void EnregistrerPret(Pret p)
        {
            try
            {
                InnitialiseConnection();
                con.Open();
                cmd = new SqlCommand("INSERT INTO tPret (id_pret,date_debut,date_fin,taux_interet,montan_total,montant_restant)  values (@i,@debut,@fin,@taux,@tmontant,@reste)", con);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =========Modification du Pret ====================

        public void ModifierPret(Pret p)
        {
            try
            {
                InnitialiseConnection();
                con.Open();
                cmd = new SqlCommand("UPDATE  tPret set id_pret=@i,date_debut=@debut,date_fin=@fin,taux_interet=@taux,montan_total=@tmontant,montant_restant=@reste where id_Pret=@i", con);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        //============================ajout Transection==============
        public void EnregistrerTrans(transaction tr)
        {
            try
            {
                InnitialiseConnection();
                con.Open();
                cmd = new SqlCommand("INSERT INTO tTransaction (id_transaction,date_trasanction,montant,type_transaction,compte_source,compte_beneficiaire ) values (@i,@date,@montant,@type,@source,@ben)", con);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =========Modification Transaction ====================

        public void EffecTra(transaction tr)
        {
            try
            {
                InnitialiseConnection();
                con.Open();
                cmd = new SqlCommand("UPDATE  tTransaction set id_transaction=@i,date_trasanction=@date,montant=@montant,type_transaction=@type,compte_source=@source,compte_beneficiaire=ben where id_transaction=@i", con);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


       // =====================ajout user===============

        public void EnregistrerUser(User u)
        {
            try
            {
                InnitialiseConnection();
                con.Open();
                cmd = new SqlCommand("INSERT INTO tUser (matricule,nom,postnom,prenom,mot_de_pass) values  (@m,@nom,@postnom,@prenom,@code)", con);
                cmd.Parameters.AddWithValue("@m", u.Matricule);
                cmd.Parameters.AddWithValue("@nom", u.Nom);
                cmd.Parameters.AddWithValue("@postnom", u.Postnom);
                cmd.Parameters.AddWithValue("@prenom", u.Prenom);
                cmd.Parameters.AddWithValue("@code", u.Mot_de_pass);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("User ajouté avec succes");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =========Modification du user ====================

        public void AddUser(User u)
        {
            try
            {
                InnitialiseConnection();
                con.Open();
                cmd = new SqlCommand("UPDATE  tUser set matricule=@m,nom=@nom,postnom=@postnom,prenom=@prenom,mot_de_pass=@code  where matricule = @m", con);
                cmd.Parameters.AddWithValue("@m", u.Matricule);
                cmd.Parameters.AddWithValue("@nom", u.Nom);
                cmd.Parameters.AddWithValue("@postnom", u.Postnom);
                cmd.Parameters.AddWithValue("@prenom", u.Prenom);
                cmd.Parameters.AddWithValue("@code", u.Mot_de_pass);
        
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Modification faite avec succes");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }






    }
}

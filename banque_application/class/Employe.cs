using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banque_application
{
    public class Employe
    {
        string id_employe;
        string nom;
        string postnom;
        string prenom;
        string grade;
        string date_embauche;
        string contact;
        decimal salaire;

        public Employe(string id_employe, string nom, string postnom, string prenom, string grade, string dateEmbauche, string contact, decimal salaire)
        {
            this.Id_employe = id_employe;
            this.Nom = nom;
            this.Postnom = postnom;
            this.Prenom = prenom;
            this.Grade = grade;
            this.Date_embauche = dateEmbauche;
            this.Contact = contact;
            this.Salaire = salaire;
        }

        public string Id_employe
        {
            get
            {
                return id_employe;
            }

            set
            {
                id_employe = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Postnom
        {
            get
            {
                return postnom;
            }

            set
            {
                postnom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

        public string Grade
        {
            get
            {
                return grade;
            }

            set
            {
                grade = value;
            }
        }

        public string Date_embauche
        {
            get
            {
                return date_embauche;
            }

            set
            {
                date_embauche = value;
            }
        }

        public string Contact
        {
            get
            {
                return contact;
            }

            set
            {
                contact = value;
            }
        }

        public decimal Salaire
        {
            get
            {
                return salaire;
            }

            set
            {
                salaire = value;
            }
        }
    }
    public partial class service_personnel : UserControl
    {
        public void sendData()
        {
            service_personnel srv = new service_personnel();
            //srv.sendData();
            
        }
    }
}

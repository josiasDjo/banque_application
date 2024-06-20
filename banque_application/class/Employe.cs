using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banque_application
{
    class Employe
    {
        string id_employe;
        string nom;
        string postnom;
        string prenom;
        string grade;
        DateTime date_embauche;
        string contact;
        decimal salaire;

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

        public DateTime Date_embauche
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
}

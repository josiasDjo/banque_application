using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banque_application.classes
{
    class User
{
        string matricule;
        string nom;
        string postnom;
        string prenom;
        string mot_de_pass;

        public string Matricule
        {
            get
            {
                return matricule;
            }

            set
            {
                matricule = value;
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

        public string Mot_de_pass
        {
            get
            {
                return mot_de_pass;
            }

            set
            {
                mot_de_pass = value;
            }
        }
    }
}

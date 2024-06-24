using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banque_application.classes
{
    class Client
{
        string id_client;
        string nom;
        string postnom;
        string prenom;
        string adresse;
        string phone;
        string datenaissance;
        string photo;

        public string Id_client
        {
            get
            {
                return id_client;
            }

            set
            {
                id_client = value;
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

        public string Adresse
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public string Datenaissance
        {
            get
            {
                return datenaissance;
            }

            set
            {
                datenaissance = value;
            }
        }

        public string Photo
        {
            get
            {
                return photo;
            }

            set
            {
                photo = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banque_application.classes
{
    class Carte
{
        string id_carte;
        int  numero_carte;
        string type_carte;
        DateTime date_expiration;

        public string Id_carte
        {
            get
            {
                return id_carte;
            }

            set
            {
                id_carte = value;
            }
        }

        public int Numero_carte
        {
            get
            {
                return numero_carte;
            }

            set
            {
                numero_carte = value;
            }
        }

        public string Type_carte
        {
            get
            {
                return type_carte;
            }

            set
            {
                type_carte = value;
            }
        }

        public DateTime Date_expiration
        {
            get
            {
                return date_expiration;
            }

            set
            {
                date_expiration = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banque_application.classes
{
    class compte
{

        string id_compte;
        int num_compte;
        string type_compte;
        decimal solde_compte;
        DateTime date_ouverture;
        String code_securite;
        String id_client;
        string id_carte;
        string id_employe;

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

        public int Num_compte
        {
            get
            {
                return num_compte;
            }

            set
            {
                num_compte = value;
            }
        }

        public string Type_compte
        {
            get
            {
                return type_compte;
            }

            set
            {
                type_compte = value;
            }
        }

        public decimal Solde_compte
        {
            get
            {
                return solde_compte;
            }

            set
            {
                solde_compte = value;
            }
        }

        public DateTime Date_ouverture
        {
            get
            {
                return date_ouverture;
            }

            set
            {
                date_ouverture = value;
            }
        }

        public string Code_securite
        {
            get
            {
                return code_securite;
            }

            set
            {
                code_securite = value;
            }
        }

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
    }
}

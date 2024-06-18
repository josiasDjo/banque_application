using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

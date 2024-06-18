using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banque_application.classes
{
    class Pret
{
        string id_pret;
        DateTime date_debut;
        DateTime date_fin;
        decimal montant_total;
        decimal montant_restant;
        string id_clientl;
        decimal taux_interet;

        public string Id_pret
        {
            get
            {
                return id_pret;
            }

            set
            {
                id_pret = value;
            }
        }

        public DateTime Date_debut
        {
            get
            {
                return date_debut;
            }

            set
            {
                date_debut = value;
            }
        }

        public DateTime Date_fin
        {
            get
            {
                return date_fin;
            }

            set
            {
                date_fin = value;
            }
        }

        public decimal Montant_total
        {
            get
            {
                return montant_total;
            }

            set
            {
                montant_total = value;
            }
        }

        public decimal Montant_restant
        {
            get
            {
                return montant_restant;
            }

            set
            {
                montant_restant = value;
            }
        }

        public string Id_clientl
        {
            get
            {
                return id_clientl;
            }

            set
            {
                id_clientl = value;
            }
        }

        public decimal Taux_interet
        {
            get
            {
                return taux_interet;
            }

            set
            {
                taux_interet = value;
            }
        }
    }
}

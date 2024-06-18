using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banque_application.classes
{
    class PayementPret
{
        string id_payement;
        DateTime date_payement;
        decimal montant_paye;
        string id_pret;

        public string Id_payement
        {
            get
            {
                return id_payement;
            }

            set
            {
                id_payement = value;
            }
        }

        public DateTime Date_payement
        {
            get
            {
                return date_payement;
            }

            set
            {
                date_payement = value;
            }
        }

        public decimal Montant_paye
        {
            get
            {
                return montant_paye;
            }

            set
            {
                montant_paye = value;
            }
        }

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
    }
}

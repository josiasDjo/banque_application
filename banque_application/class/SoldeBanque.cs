using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banque_application.classes
{
    class SoldeBanque
    {
        string id_solde_banque;
        decimal montant_total;

        public string Id_solde_banque
        {
            get
            {
                return id_solde_banque;
            }

            set
            {
                id_solde_banque = value;
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
    }
}

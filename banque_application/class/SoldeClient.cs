using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banque_application.classes
{
    class SoldeClient
{
        string il_solde;
        decimal montant;

        public string Il_solde
        {
            get
            {
                return il_solde;
            }

            set
            {
                il_solde = value;
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
    }
}

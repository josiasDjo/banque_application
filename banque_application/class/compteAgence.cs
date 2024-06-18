using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banque_application.classes
{
    class compteAgence
{
        string id_compte_agence;
        string id_agence;

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

        public string Id_agence
        {
            get
            {
                return id_agence;
            }

            set
            {
                id_agence = value;
            }
        }
    }
}

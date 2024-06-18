using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banque_application.class
{
    class soldeInteret
{
    string id_interet;
    decimal montant;

    public string Id_interet
    {
        get
        {
            return id_interet;
        }

        set
        {
            id_interet = value;
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

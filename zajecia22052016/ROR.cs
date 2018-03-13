using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia22052016
{
    class ROR : Konto
    {
        public override decimal Wplac(decimal ile)
        {
            Saldo += ile;
            return Saldo;
        }

        public override decimal Wyplac(decimal ile)
        {
            if (Saldo>=ile)
            {
                Saldo -= ile;
            }
            return Saldo;

        }


    }

}

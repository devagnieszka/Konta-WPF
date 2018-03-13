using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia22052016
{
    class Konto
    {
        public string Numer { get; set; }
        public decimal Saldo { get; set; }
        public string Typ { get; set; }

        public virtual decimal Wplac(decimal ile)
        {
            return Saldo;
        }

        public virtual decimal Wyplac(decimal ile)
        {
            return Saldo;
        }


    }
}

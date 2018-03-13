using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia22052016
{
    class LOKATA : Konto
    {
        int iloscwplat = 0;
        public override decimal Wplac(decimal ile)
        {
            if (iloscwplat<1)
            {
                Saldo += ile;
                iloscwplat++;
            }

            return Saldo;
        }


        int iloscwyplat = 0;
        decimal polowa = 0;
        public override decimal Wyplac(decimal ile)
        {
      
            if (iloscwyplat==0)       
            {
                polowa = Saldo / 2;    //założenie że można wypłacic tylko połowę
            }

            Saldo -= ile;
            iloscwyplat++;

            if (Saldo<polowa)
                {
                    Saldo += ile;
                }

   
            return Saldo;

        }



    }
}

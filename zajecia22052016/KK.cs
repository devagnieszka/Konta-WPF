using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia22052016
{
    class KK:Konto
    {
        public override decimal Wplac(decimal ile)
        {
      
            if (Saldo<0)
            {
                Saldo += ile;
                if (Saldo>0)
                {
                    Saldo = 0;
                }
            }
 
            return Saldo;

        }

        public override decimal Wyplac(decimal ile)
        {
         
            
                Saldo -= ile;
                return Saldo;
           
       
        }


    }
}

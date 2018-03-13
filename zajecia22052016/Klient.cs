using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia22052016
{
    class Klient
    {

        public ObservableCollection<Konto> konta = new ObservableCollection<Konto>();
        public ObservableCollection<Konto> Konta { get { return konta; }  }
       
        public string Nazwisko{ get; set; }



    }
}

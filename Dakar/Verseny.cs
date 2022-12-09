using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dakar
{
    class Verseny
    {
        public int ev;
        public Jarmu kategoria;
        public string pilota;
        public string orszag;
        public string jarmuTipus;

        public Verseny(int ev, Jarmu kategoria, string pilota, string orszag, string jarmuTipus)
        {
            this.ev = ev;
            this.kategoria = kategoria;
            this.pilota = pilota;
            this.orszag = orszag;
            this.jarmuTipus = jarmuTipus;
        }
    }
}

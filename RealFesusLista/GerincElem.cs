using System;

namespace RealFesusLista
{
    class GerincElem<T, z>
    {
        public T gerincAdat;
        public GerincElem<T, z> gerincKov;
        public ListaElem<z> listaKezdo;
        
        public T GerincAdat
        {
            get { return gerincAdat; }
            set { gerincAdat = value; }
        }

        public GerincElem<T, z> GerincKov
        {
            get { return gerincKov; }
            set { gerincKov = value; }
        }
        
        public ListaElem<z> ListaKezdo
        {
            get { return listaKezdo; }
            set { listaKezdo = value; }
        }

        public GerincElem(T adat)
        {
            gerincAdat = adat;
            gerincKov = null;
            listaKezdo = null;
        }
        public void UjElem(z ujAdat)
        {
            ListaElem<z> ujElem = new ListaElem<z>(ujAdat);
            if (listaKezdo == null)
            {
                listaKezdo = ujElem;
                return;
            }
            ListaElem<z> p;
            for (p = listaKezdo; p.KovElem != null; p = p.KovElem) ;
            p.KovElem = ujElem;
        }


    }
}

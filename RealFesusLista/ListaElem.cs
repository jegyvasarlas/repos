using System;

namespace RealFesusLista
{
    class ListaElem<T>
    {
        T adat;
        ListaElem<T> kovElem;
        public T Adat
        {
            get { return adat; }
            set { adat = value; }
        }
        public ListaElem<T> KovElem
        {
            get { return kovElem; }
            set { kovElem = value; }
        }
        public ListaElem(T elem)
        {
            adat = elem;
            kovElem = null;
        }
    }
}

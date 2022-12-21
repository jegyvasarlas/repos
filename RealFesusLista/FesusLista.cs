using System;
using System.Collections.Generic;

namespace RealFesusLista
{
    class FesusLista<T, z>
    {
        private GerincElem<T, z> kezdo;
        public FesusLista()
        {
            kezdo = null;
        }
        public FesusLista(T gerincAdat)
        {
            GerincElem<T, z> ujElem = new GerincElem<T, z>(gerincAdat);
            kezdo = ujElem;
        }
        public void GerincElejereFuz(T ujGerincAdat)
        {
            GerincElem<T, z> ujGerincElem = new GerincElem<T, z>(ujGerincAdat);
            ujGerincElem.GerincKov = kezdo;
            kezdo = ujGerincElem;
        }
        public GerincElem<T, z> this[T key]
        {
            get
            {
                for (GerincElem<T, z> p = kezdo; p != null; p = p.gerincKov)
                {
                    if (p.gerincAdat.Equals(key))
                    {
                        return p;
                    }
                }
                throw new IndexOutOfRangeException("Nem letezik ilyen kulcs a fesus listaban: " + key.ToString());
                return null;
            }
        }
        
        public KeyValuePair<T, z> this[int i, int j]
        {
            get
            {
                GerincElem<T, z> p = kezdo;
                for (int k = 0; k < i; k++)
                {
                    if (p == null)
                    {
                        throw new IndexOutOfRangeException("Nem letezik ilyen kulcs a fesus listaban: " + i.ToString());
                    }
                    p = p.gerincKov;
                }
                ListaElem<z> q = p.listaKezdo;
                for (int k = 0; k < j; k++)
                {
                    if (q == null)
                    {
                        throw new IndexOutOfRangeException("Nem letezik ilyen kulcs a fesus listaban: " + j.ToString());
                    }
                    q = q.KovElem;
                }
                return new KeyValuePair<T, z>(p.gerincAdat, q.Adat);
            }
        }
          
        public void PrintAll()
        {
            for (GerincElem<T, z> p = kezdo; p != null; p = p.gerincKov)
            {
                Console.Write(p.gerincAdat + " : ");
                for (ListaElem<z> q = p.listaKezdo; q != null; q = q.KovElem)
                {
                    Console.Write(q.Adat + " -> ");
                }
                Console.WriteLine("null");
                Console.WriteLine("  |");
                Console.WriteLine("  V");
            }
            Console.WriteLine("null");
        }
    }
    
}

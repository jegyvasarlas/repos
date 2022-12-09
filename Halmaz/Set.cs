using System;
using StackFeladat;

namespace Halmaz
{
    class Set<T>
    {
        T[] data;
        int elementNum;

        public int Count { get { return elementNum; } }

        public bool IsEmpty { get { return Count == 0; } }

        public Set()
        {
            elementNum = 0;
            data = new T[0];
        }

        public Set(Set<T> other)
        {
            elementNum = other.elementNum;
            data = new T[Count];
            for (int i = 0; i < Count; i++)
                data[i] = other.data[i];
        }

        public bool IsElement(T newElement)
        {
            for (int i = 0; i < Count; i++)
                if (data[i].Equals(newElement))
                    return true;
            return false;
        }

        public void Add(T newElement)
        {
            if (IsElement(newElement))
                return;

            T[] tmp = new T[++elementNum];
            for (int i = 0; i < Count - 1; i++)
                tmp[i] = data[i];

            tmp[Count - 1] = newElement;

            data = tmp;
        }

        public void Remove(T element)
        {
            if (IsElement(element))
                return;

            T[] tmp = new T[--elementNum];

            bool f = false;
            for(int i=0; i < Count; i++)
            {
                if (data[i].Equals(element))
                    f = true;

                if (!f)
                    tmp[i] = data[i];
                else
                    tmp[i] = data[i + 1];
            }

            data = tmp;
        }

        public string ToString()
        {
            string s = "";
            for (int i = 0; i < Count; i++)
            {
                s += data[i].ToString() + " ";
            }
            
            s += "\n";
            return s;
        }

        //metszet
        public static Set<T> Intersect (Set<T> s1, Set<T> s2)
        {
            Set<T> ret = new Set<T>();
            for (int i = 0; i < s1.Count; i++)
                if (s2.IsElement(s1.data[i]))
                    ret.Add(s1.data[i]);
            return ret;
        }

        //unio
        public static Set<T> Union(Set<T> s1, Set<T> s2)
        {
            Set<T> ret = new Set<T>();
            for (int i = 0; i < s1.Count; i++)
                ret.Add(s1.data[i]);
            for (int i = 0; i < s2.Count; i++)
                ret.Add(s2.data[i]);
            return ret;
        }

        public static Set<T> Except(Set<T> s1, Set<T> s2)
        {
            Set<T> ret = new Set<T>();
            for(int i=0; i<s1.Count; i++)
            {
                if (!s2.IsElement(s1.data[i]))
                    ret.Add(s1.data[i]);
               
            }
            return ret;
        }



    }
}

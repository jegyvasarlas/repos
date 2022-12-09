using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teglatest
{
    class List
    {
        int[] data;
        int elementNum;
        public int Count
        {
            get { return elementNum; }
        }
        
        public List(List other)
        {
            data = new int[0];
            elementNum = 0;
            for(int i = 0; i < other.Count; i++)
            {
                this.Add(other[i]);
            }
        }

        public List()
        {
            data = new int[0];
            elementNum = 0;
        }

        public void Add(int newData)
        {
            int[] tmp = new int[Count + 1];
            for( int i = 0; i < Count; i++)
            {
                tmp[i] = data[i];
            }
            tmp[Count] = newData;
            elementNum++;
            data = tmp;
        }

        public void RemoveIndex(int index)
        {
            int[] tmp = new int[Count - 1];
            for(int i = 0; i < Count-1; i++)
                if(i < index)
                    tmp[i] = data[i];
                else
                    tmp[i] = data[i + 1];
            elementNum--;
            data = tmp;
        }

        public void RemoveValue(int value)
        {
            if (Count == 0)
                return;

            for (int i = 0; i < Count; i++)
                if (data[i] == value)
                {
                    RemoveIndex(i);
                    i = -1;
                }
        }

        public int this[int index]
        {
            get
            {
                return data[index];
            }
            set 
            { 
                data[index] = value;
            }
        }
        
        private void Csere(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        public void Sort(bool asc=true)
        {
            for (int i = 0; i < Count-1; i++)
            {
                for (int j = i+1; j < Count; j++)
                {
                    if (asc && data[j] > data[i])
                        Csere(ref data[i], ref data[j]);
                    else if (!asc && data[j] < data[i])
                        Csere(ref data[i], ref data[j]);
                }
            }
        }
    }
}

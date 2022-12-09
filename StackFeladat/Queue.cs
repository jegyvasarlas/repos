using System;
using System.Runtime.CompilerServices;

namespace StackFeladat
{
    class Queue<T>
    {
        T[] data;
        int elementNum;

        public Queue()
        {
            data = new T[0];
            elementNum = 0;
        }

        public Queue(Queue<T> other)
        {
            elementNum = other.elementNum;
            data = new T[elementNum];
            for (int i = 0; i < other.Count; i++)
                this.data[i] = other[i];
        }

        public int Count { get { return data.Length; } }

        public bool IsEmpty { get { return data.Length == 0; } }


        public void Push(T newElement)
        {
            T[] tmp = new T[++elementNum];
            tmp[0] = newElement;
            for (int i = 1; i < tmp.Length; i++)
                tmp[i] = data[i - 1];

            data = tmp;
        }

        public void Clear()
        {
            elementNum = 0;
            data = new T[0];
        }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < elementNum)
                    return data[index];
                else
                    return default(T);
            }
        }
    }
}

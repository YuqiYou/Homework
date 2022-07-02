using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class MyList<T>
    {
        private int size;// current elements
        public int Size { get { return size; } set { size = value; } }

        private int len;// total length
        public int Len { get { return len; } set { len = value; } }

  
        private T[] list;

        public MyList(int length)
        {

            Size = 0;
            list = new T[length];
            Len = length;
        }

        public void Add(T element)
        {
            list[size++] = element;
        }

        public T Remove(int index)
        {
            return list[index];
        }

        public bool Contains(T elements)
        {
            foreach(T element in list)
            {
                if (elements.Equals(element)) return true;
            }
            return false;
        }

        public void printList()
        {
           foreach(T element in list)
            {
                Console.WriteLine(element);
            }
        }

        public void Clear()
        {

            int len = list.Length;
            list = new T[len];
        }

        public void InsertAt(T element, int index)
        {
            
            T temp = list[index];
            list[index] = element;
            if(index < Len-1)
            {
                T temp2 = list[index + 1];
                for (int i = index + 1; i < Size - 2; i++)
                {

                    list[i] = temp;
                    temp = temp2;
                    temp2 = list[i + 2];

                }
            }
            else if(index == Len)
            {
                list[index] = element;
            }
        }

        public void DeleteAt(int index)
        {
            for(int i  = index; i < Len-1; i++)
            {
                list[i] = list[++i];
            }
            
        }
        public T Find(int index)
        {
            return list[index];
        }
    }
}

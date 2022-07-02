using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public  class MyStack<T> 
    {
        private int size;
        public int Size { get { return size; } set { size = value; } }

        private int top;
        public int Top { get { return top; } set { top = value; } }


        private T[] stack;

        public MyStack(int length)

        {

            Size = length;

            stack = new T[Size];
            Top = -1;

        }
        public int Count()
        {
            return size;
        }
        public T Pop()
        {

            T Removed;
            if (!(top <= 0))
            {
                Removed = stack[top];
                top = top - 1;

                return Removed;

            }
            return default(T);

        }

        public void Push(T element)
        {
            top = top + 1;
            stack[top] = element;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Postfix
{
    class StackInt
    {
        private int[] stackArray;
        private int top;

        public StackInt()
        {
            stackArray = new int[10];
            top = -1;
        }

        public StackInt(int maxSize)
        {
            stackArray = new int[maxSize];
            top = -1;
        }

        public int Size()
        {
            return top + 1;
        }
        public bool IsEmpty()
        {
            return (top == -1);
        }
        public bool IsFull()
        {
            return (top == stackArray.Length - 1);

        }
        public void Push(int x)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack overflow\n");
                return;
            }
            top = top + 1;
            stackArray[top] = x;


        }
        public int Pop()
        {
            int x;
            if (IsEmpty())
            {
                Console.WriteLine("Stack underflow\n");
                throw new System.InvalidOperationException();
            }
            x = stackArray[top];
            top = top - 1;
            return x;



        }











    }
}

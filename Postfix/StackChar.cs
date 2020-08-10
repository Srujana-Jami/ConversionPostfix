using System;
using System.Collections.Generic;
using System.Text;

namespace Postfix
{
    class StackChar
    {
        private char[] stackArray;
        private int top;

        public StackChar()
        {
            stackArray = new char[10];
            top = -1;

        }

        public StackChar(int maxSize)
        {
            stackArray = new char[maxSize];
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
        public void Push(char x)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack overflow\n");
                return;
            }
            top = top + 1;
            stackArray[top] = x;


        }

        public char Pop()
        {
            char x;
            if (IsEmpty())
            {
                Console.WriteLine("Stack underflow\n");
                throw new System.InvalidOperationException();
            }
            x = stackArray[top];
            top = top - 1;
            return x;



        }

        public char Peek()
        {
            if (IsEmpty())
                throw new System.InvalidOperationException("Stack underflow");
            return stackArray[top];
        }




    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_2
{
    public class ArrayStack : IStack
    {
        private int?[] stack; //Im using a nullable array because it can be filed with 0's
        private int size;
        public int index = 0;

        public ArrayStack(int size)
        {
            this.size = size;
            stack = new int?[size];
        }

        public int Count { get { return index; } }

        public bool IsEmpty 
        {
            get
            {
                foreach (int? i in stack)
                    if (i != null)
                        return false;

                return true;
            }
        }

        public bool Contains(int value)
        {
            foreach(int? i in stack)
            {
                if (i == value)
                    return true;
            }

            return false;
        }

        public int Pop()
        {
            if (stack[index - 1] == null)
                throw new Exception("This index is empty");

            int? toReturn = stack[index - 1];
            stack[index - 1] = null;
            index--;

            return toReturn.GetValueOrDefault();
        }

        public void Push(int value)
        {
            if (index == size)
                throw new OverflowException("Array is already full");

            stack[index] = value;
            index++;
        }
    }
}
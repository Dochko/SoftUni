using System;

namespace GenericStack
{
    public class CustomStack<T>
        where T : IComparable<T>
    {
        private const int DefaultCapacity = 16;

        private T[] array;
        private int index;
        private int currentCapacity = DefaultCapacity;

        public CustomStack(int capacity = DefaultCapacity)
        {
            this.array = new T[capacity];
            this.index = 0;
        }


        //Add element in the stack
        public void Push(T item)
        {
            currentCapacity = this.array.Length;

            if(this.index == this.currentCapacity)
            {
                this.Resize(this.currentCapacity * 2);
            }

            this.array[this.index] = item;
            this.index++;
        }

        //Remove element from the stack by overriding
        //the last element in the stack
        public T Pop()
        {
            if (this.index == 0)
            {
                return default(T);

                //throw new InvalidOperationException("Stack is empty");
            }

            T element = this.array[this.index - 1];
            this.index--;
            return element;
        }

        //Finding the highest number in the stack
        public T Max()
        {
            if (this.index == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T max = this.array[0];

            for (int i = 1; i < this.index; i++)
            {
                if (this.array[i].CompareTo(max) > 0)
                {
                    max = this.array[i];
                }
            }

            return max;
        }

        //Increasing the size of the stack
        //if the stack is full
        private void Resize(int newCapacity)
        {
            T[] newArray = new T[newCapacity];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = this.array[i];
            }

            this.array = newArray;
            this.currentCapacity = newCapacity;
        }
    }
}
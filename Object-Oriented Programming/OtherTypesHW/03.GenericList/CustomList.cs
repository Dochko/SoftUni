using System;
using System.Linq;
using System.Text;

namespace GenericList
{
    [Version(5, 01)]
    public class CustomList<T>
        where T : IComparable<T>
    {
        private const int DefaultCapacity = 16;

        private T[] array;
        private int index;
        private int currentCapacity = DefaultCapacity;

        public CustomList(int capacity = DefaultCapacity)
        {
            array = new T[capacity];
            index = 0;
        }

        public T this[int index]
        {
            get
            {
                if (index >= this.index || index < 0)
                {
                    throw new IndexOutOfRangeException("The index is invalid !");
                }

                return array[index];
            }
            set
            {
                if (index >= this.index || index < 0)
                {
                    throw new IndexOutOfRangeException("The index is invalid !");
                }
                array[index] = value;
            }
        }

        public void Add(T item)
        {
            currentCapacity = array.Length;

            if (index == currentCapacity)
            {
                Resize(currentCapacity * 2);
            }

            array[index] = item;
            index++;
        }

        public void Remove(int position)
        {
            T[] newArray = new T[currentCapacity];

            Array.Copy(array, newArray, position);
            Array.Copy(array, position + 1, newArray, position, array.Length - position - 1);

            array = newArray;
            index--;
        }

        public void Insert(T element, int position)
        {
            T[] newArray = new T[currentCapacity];

            Array.Copy(array, newArray, position);
            Array.Copy(new T[1] { element }, 0, newArray, position, 1);
            Array.Copy(array, position, newArray, position + 1, array.Length - position - 2);

            array = newArray;
            index++;
        }

        public void Clear()
        {
            array = new T[DefaultCapacity];
            index = 0;
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < index; i++)
            {
                if (array[i].Equals(element))
                {
                    return i;
                }
            }

            return -1;
        }

        public bool Contains(T element)
        {
            return array.Contains(element);
        }

        public T Max()
        {
            if (index == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T max = array[0];

            for (int i = 1; i < index; i++)
            {
                if (array[i].CompareTo(max) > 0)
                {
                    max = array[i];
                }
            }

            return max;
        }

        public T Min()
        {
            if (index == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T min = array[0];

            for (int i = 1; i < index; i++)
            {
                if (array[i].CompareTo(min) < 0)
                {
                    min = array[i];
                }
            }

            return min;
        }

        private void Resize(int newCapacity)
        {
            T[] newArray = new T[newCapacity];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
            currentCapacity = newCapacity;
        }

        public override string ToString()
        {
            StringBuilder customlist = new StringBuilder();

            for (int i = 0; i < index; i++)
            {
                customlist.Append(array[i]);

                if (i != index - 1)
                {
                    customlist.Append("\n");
                }
            }

            return customlist.ToString();
        }
    }
}
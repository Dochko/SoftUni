using System;

namespace GenericStack
{
    class Student : IComparable<Student>
    {
        public string Name { get; set; }

        public int CompareTo(Student other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }

    class Program
    {
        static void Main()
        {
            var stack = new CustomStack<int>(2);
            stack.Push(6);
            stack.Push(1);
            stack.Push(3);
            stack.Push(5);

            int result = stack.Pop();
            int max = stack.Max();

            Console.WriteLine(result);
            Console.WriteLine(max);
        }
    }
}

using System;

namespace GenericMethods
{
    //Create custom attribute
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class AuthorAttribute : Attribute
    {
        public AuthorAttribute(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }
    }

    //Declaring attribute for specific class, method, etc.
    [Author("Dobri")]
    [Author("Pesho")]
    class Program
    {
        static void Main()
        {
            int i = 5;
            int j = 7;
            Console.WriteLine("Min({0}, {1}) = {2}", i, j,
                Min(i, j));

            string firstString = "Prase";
            string secondString = "Ovca";
            Console.WriteLine("Min({0}, {1}) = {2}", firstString, secondString,
                Min(firstString, secondString));


            //Printing attribute
            Type type = typeof (Program);
            var attributes = type.GetCustomAttributes(true);

            foreach (var att in attributes)
            {
                string name = ((AuthorAttribute)att).Name;
                Console.WriteLine(name);
            }
        }

        static T Min<T>(T objA, T objB)
            where T : IComparable<T>
        {
            if (objA.CompareTo(objB) < 0)
            {
                return objA;
            }
            else
            {
                return objB;
            }
        }
    }
}

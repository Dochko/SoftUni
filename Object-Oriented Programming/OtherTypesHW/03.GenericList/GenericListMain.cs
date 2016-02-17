using System;

namespace GenericList
{
    class GenericListMain
    {
        static void Main()
        {
            //Displaying program version
            var versionAttribute = typeof (CustomList<>).GetCustomAttributes(typeof (VersionAttribute), true);
            Console.WriteLine("Program version: {0}v\n", versionAttribute[0]);

            ComputerParts cpu = new ComputerParts("AMD Athlon II X3 3.20 Ghz", 90m);
            ComputerParts ram = new ComputerParts("Kingston HyperX 4x2 GB", 130m);
            ComputerParts motherboard = new ComputerParts("Asrock PRO X3", 50m);
            ComputerParts dvd = new ComputerParts("DVD-ROM LG DH18NS60", 21m);
            ComputerParts hdd = new ComputerParts("Samsung SSD 256 GB", 110m);
            
            CustomList<ComputerParts> parts = new CustomList<ComputerParts>();

            //Adding elements
            parts.Add(cpu);
            parts.Add(ram);
            parts.Add(motherboard);
            parts.Add(dvd);
            Console.WriteLine(parts);
            Console.WriteLine();

            //Accessing element by index
            Console.WriteLine(parts[2]);
            Console.WriteLine();
            
            //Removing element
            parts.Remove(3);
            Console.WriteLine(parts);
            Console.WriteLine();

            //Insert element
            parts.Insert(hdd, 2);
            Console.WriteLine(parts);
            Console.WriteLine();

            //Find element index by value
            Console.WriteLine("Motherboard index is {0}", parts.IndexOf(motherboard));
            Console.WriteLine();

            //Check if the list contains a value
            Console.WriteLine("Does the list contains HDD ? - {0}", parts.Contains(hdd));
            Console.WriteLine();

            //Cheking the minimum and maximum part by price
            Console.WriteLine("The cheapest part is: {0}", parts.Min());
            Console.WriteLine("The most expensive part is: {0}", parts.Max());
            Console.WriteLine();
            
            //Now we delete all the elements in the list
            parts.Clear();
            Console.WriteLine("We have a brand new list now :) {0}", parts);
        }
    }
}

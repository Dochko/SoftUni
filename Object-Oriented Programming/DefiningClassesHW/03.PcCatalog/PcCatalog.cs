using System;
using System.Collections.Generic;

namespace PcCatalog
{
    class PcCatalog
    {
        static void Main()
        {
            List<Computer> computers = AddComputers();

            foreach (var computer in computers)
            {
                Console.WriteLine(computer);
            }
        }

        static List<Computer> AddComputers()
        {
            List<Computer> computers = new List<Computer>();
            string exitCommand = null;

            do
            {
                Console.Write("Enter computer name: ");
                string name = Console.ReadLine();

                List<Component> components = AddComponents();

                Computer computer = new Computer(name, components);
                computers.Add(computer);

                Console.Write("Do you want to add another computer ? y/n: ");
                exitCommand = Console.ReadLine();

                Console.WriteLine();
            }
            while (exitCommand != "n" && exitCommand != "N");

            return computers;
        }

        static List<Component> AddComponents()
        {
            List<Component> components = new List<Component>();
            string exitCommand = null;

            do
            {
                Console.Write("Enter component name: ");
                string name = Console.ReadLine();
                Console.Write("Enter component description (optional): ");
                string description = Console.ReadLine();
                Console.Write("Enter component price: ");
                decimal price = decimal.Parse(Console.ReadLine());

                Component component = new Component(name, description, price);
                components.Add(component);

                Console.Write("Do you want to add another component ? y/n: ");
                exitCommand = Console.ReadLine();
            }
            while (exitCommand != "n" && exitCommand != "N");

            return components;
        }  
    }
}
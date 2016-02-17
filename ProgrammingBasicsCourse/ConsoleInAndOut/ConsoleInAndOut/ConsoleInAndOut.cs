using System;
using System.Text;
using System.Threading;
using System.Globalization;

class ConsoleInAndOut
{
    static void Main()
    {
        
        //Console Out
        string name = "Dobromir";
        int age = 24;
        string city = "Bjala Slatina";
        Console.WriteLine("{0} is {1} years old. He is from {2}.", name, age, city);
        Console.WriteLine();
        
        float pi = 3.14159206f;
        Console.WriteLine("{0:0.000000}", pi);
        Console.WriteLine();

        double colaPrice = 1.00;
        string cola = "Coca Cola";
        double fantaPrice = 1.00;
        string fanta = "Fanta";
        double zagorkaPrice = 1.50;
        string zagorka = "Zagorka";

        Console.WriteLine("{0,-15} | {1,10:F2} |", cola, colaPrice);
        Console.WriteLine("{0,-15} | {1,10:F2} |", fanta, fantaPrice);
        Console.WriteLine("{0,-15} | {1,10:F2} |", zagorka, zagorkaPrice);
        Console.WriteLine("{0,-15} | {1,10:F2} |", "Laina", 3.55);
        Console.WriteLine("The hex value of {0} is {0:X}", 32378);
        Console.WriteLine();

        //Console In
        Console.WriteLine("Enter any number or char: ");
        int i = Console.Read();
        Console.WriteLine(i);
        char character = (char)i;
        Console.WriteLine(character);
        Console.WriteLine();

        Console.WriteLine("Press any key:");
        ConsoleKeyInfo key = Console.ReadKey();
        Console.WriteLine();
        Console.WriteLine("Key name: " + key.Key);
        Console.WriteLine("Key number: " + (int)key.Key);
        Console.WriteLine("Special Keys: [{0}] ", key.Modifiers);
        Console.WriteLine("Character entered: " + key.KeyChar);
        Console.WriteLine();

        Console.ReadLine(); //Unknown when u press ReadKey it misses string firstName and goes to lastName
        Console.Write("Enter your first name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Enter your last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine("Hello, {0} {1}!", firstName, lastName);
        Console.WriteLine();

        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        Console.Write("f = ");
        float f = float.Parse(Console.ReadLine());
        Console.WriteLine("{0} * {1} / {2} = {3}", a, b, f, a * b / f);

        Console.Write("Enter a number to convert it: ");
        string c = Console.ReadLine();
        int ch = Convert.ToInt32(c);
        Console.Write("Enter another number to convert it: ");
        string g = Console.ReadLine();
        int gh = Convert.ToInt32(g);
        Console.WriteLine();

        Console.Write("Enter a NUMBER: "); //With if/else
        string str = Console.ReadLine();
        int number;
        if (int.TryParse(str, out number))
        {
            Console.WriteLine("Congrats ! Your number is {0}", str);
        }
        else
        {
            Console.WriteLine("Epic fail ... I said a NUMBER moron: {0}", str);
        }
        Console.WriteLine();

        try //With try/catch
        {
            Console.Write("Enter a number: ");
            int tryingNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(tryingNumber);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number.");
        }

        Console.WriteLine(); //With boolean
        Console.Write("This time we will try tryParse with boolean: ");
        string inputLine = Console.ReadLine();
        int anotherNumber;
        bool succesfulParse = int.TryParse(inputLine, out anotherNumber);
        Console.WriteLine(succesfulParse);
        Console.WriteLine();

        Console.OutputEncoding = Encoding.UTF8; //using System.Text; !!! Added in the beginning of the code
        Console.WriteLine("Тава е кирилицъ :Д");

        Console.WriteLine(); // using System.Threading; using System.Globalization; is a must and the bellow too
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine(3.54);
        decimal value = decimal.Parse("1.33");
        Console.WriteLine();

        Console.Write("Enter first and last name: "); //Printing a Letter
        string person = Console.ReadLine();
        Console.Write("Enter company name: ");
        string company = Console.ReadLine();
        
        Console.WriteLine(" Dear {0},", person);
        Console.WriteLine();
        Console.WriteLine("We are pleased to tell you that " + 
            "{1} has accepted you to take part in the \"Programming Basics\"" + 
            " course. {1} wishes you a good luck!", person, company);
        Console.WriteLine(" Yours,");
        Console.WriteLine(" {0}", company);
        Console.WriteLine();

        Console.WriteLine("This program calculates " + //Calculating Area
            "the are of rectangle or a triangle");

        Console.Write("Enter a and b (for rectangle) " + 
            " or a and h (for triangle): ");
        int aSide = int.Parse(Console.ReadLine());
        int bSide = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter 1 for a rectangle or 2 for a triangle: ");

        int choice = int.Parse(Console.ReadLine());
        double area = (double)(aSide * bSide) / choice;
        Console.WriteLine("The area of your figure is {0}", area);
    }
}
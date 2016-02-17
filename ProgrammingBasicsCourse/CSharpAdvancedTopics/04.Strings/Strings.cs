using System;
using System.Net.Mime;
using System.Text;

class Strings
{
    static void Main()
    {
        //String is one-dimensional array
        string s = "Hello, SoftUni!";
        Console.WriteLine(s);
        Console.WriteLine(s[14]);
        //s[5] = 'z'; - Exception ! Strings are readonly
        string newS = s.Replace('o', '0'); //We must create a new string to edit strings
        Console.WriteLine(newS);
        Console.WriteLine();

        //Stringbuilder is a string that can be edited and is alot faster than string
        Console.WriteLine("StringBuilder:");
        StringBuilder strBuilder = new StringBuilder("Hello, SoftUni!");
        Console.WriteLine(strBuilder.ToString()); //Can be used without .ToString(), but its more apropriate to use it
        strBuilder.Append(" Give me a cool job!");
        Console.WriteLine(strBuilder.ToString());

        StringBuilder asterixString = new StringBuilder(new string('*' , 5));
        Console.WriteLine(asterixString);
        Console.WriteLine();

        //String Example 1
        Console.WriteLine("Example 1:");
        string text = "SoftUni";
        Console.WriteLine(text);
        for (int i = 0; i < text.Length; i++)
        {
            Console.WriteLine("str[{0}] = {1}", i , text[i]);
        }
        Console.WriteLine(text.IndexOf("Uni")); //4
        Console.WriteLine(text.IndexOf("uni")); //-1 (not found)
        Console.WriteLine(text.Substring(4 , 3)); //Uni
        Console.WriteLine(text.Replace("Soft", "Hard")); //HardUni
        Console.WriteLine(text.ToLower()); // softuni
        Console.WriteLine(text.ToUpper()); // SOFTUNI
        Console.WriteLine();

        //String Example 2
        Console.WriteLine("Example 2:");
        string firstName = "Steve";
        string lastName = "Jobs";
        int age = 56;
        Console.WriteLine(firstName + " " + lastName +
            " (age: " + age + ")"); // Steve Jobs (age: 56)
        string allLangs = "C#, Java; HTML, CSS; PHP, SQL";
        string[] langs = allLangs.Split(new char[] {',', ';', ' '}, StringSplitOptions.RemoveEmptyEntries);
        foreach (var lang in langs)
        {
            Console.WriteLine(lang);
        }
        Console.WriteLine("Langs = " + string.Join(", ", langs));
        Console.WriteLine(" \n\n Software University ".Trim());
    }
}
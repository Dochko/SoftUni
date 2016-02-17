using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TextModification
{
    static void Main()
    {
        string str = "you though this deer was real…nope, just chuck testa.";
        char[] a = str.ToCharArray();
        
        byte[] asciiBytes = Encoding.ASCII.GetBytes(str);

        for (int i = 0; i < str.Length; i++)
        {
            if (asciiBytes[i] % 3 == 0)
            {
                a[i] = char.ToUpper(a[i]);
            }
        }

        string cammelCase = new string(a);
        Console.WriteLine(cammelCase);


    }
}
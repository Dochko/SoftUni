using System;

class NestedIfStatements
{
    static void Main()
    {
        int nFirstNum = int.Parse(Console.ReadLine());
        int nSecondNum = int.Parse(Console.ReadLine());
        int nThirdNum = int.Parse(Console.ReadLine());

        if (nFirstNum > nSecondNum && nFirstNum > nThirdNum)
        {
            Console.WriteLine("First num is biggest");
        }
        else
        {
            if (nSecondNum > nThirdNum)
            {
                Console.WriteLine("Second num is biggest");
            }
            else
            {
                Console.WriteLine("Third num is biggest");
            }
        }
    }
}

using System;

class NestedLoops
{
    static void Main()
    {
        /* A loop inside another loop
            
            for (initialization; test; update)
            {
                for (initialization; test; update)
                {
                    statements;
                }
                .....
            }
        */

        //Triangle from numbers
        Console.WriteLine("n = ");
        string numberAsString = Console.ReadLine();
        int n = int.Parse(numberAsString);
        Console.WriteLine();

        for (int row = 1; row <= n; row++)
        {
            for (int column = 1; column <= row; column++)
            {
                Console.Write("{0}", column);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        

        //Toto 6/49 total combinations
        int counter = 0;
        for (int i1 = 1; i1 <= 44; i1++)
            for (int i2 = i1 + 1; i2 <= 45; i2++)
                for(int i3 = i2 + 1; i3 <= 46; i3++)
                    for(int i4 = i3 + 1; i4 <= 47;i4++)
                        for(int i5 = i4 + 1; i5 <= 48; i5++)
                            for (int i6 = i5 + 1; i6 <= 49; i6++) //The first loop to finish is the most inner one, so the program is working from inside out
                            {
                                //To speed up the counter, we need to comment the line below
                                //Console.WriteLine("{0} {1} {2} {3} {4} {5}", i1, i2, i3, i4, i5, i6);
                                counter++;
                            }
        Console.WriteLine("{0} combinations", counter);
            
        
    }
}
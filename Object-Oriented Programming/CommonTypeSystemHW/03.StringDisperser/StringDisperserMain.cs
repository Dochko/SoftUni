﻿using System;

namespace StringDisperser
{
    public class StringDisperserMain
    {
        private static void Main()
        {
            StringDisperser stringDisperser = new StringDisperser("gosho", "pesho", "tanio");

            foreach (var ch in stringDisperser)
            {
                Console.Write(ch + " ");

            }

            Console.WriteLine();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3ArraysReferences
{
    internal class JaggedArray
    {
        static void Main()
        {
            int[][] jaggedArray = new int[2][];

            int[] x = new int[] { 12, 5, 22 };
            int[] y = new int[] { 55, 11, 55 };

            jaggedArray[0] = x;
            jaggedArray[1] = y;

            Console.WriteLine(jaggedArray[0][0]);
            Console.WriteLine(jaggedArray[0][1]);
            Console.WriteLine(jaggedArray[0][2]);

            Console.WriteLine(jaggedArray[1][0]);
            Console.WriteLine(jaggedArray[1][1]);
            Console.WriteLine(jaggedArray[1][2]);

            Console.WriteLine();
            Console.WriteLine("Print using for loop");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + "    ");
                }
                Console.WriteLine();
            }
        }
    }
}

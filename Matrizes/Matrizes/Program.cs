﻿using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i,j] = int.Parse(values[j]);
                }
            }

            Console.Write("Diagonal Principal: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }

                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("Números negativos: " + count);
        }
    }
}

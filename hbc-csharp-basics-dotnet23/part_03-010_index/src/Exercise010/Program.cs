﻿namespace Exercise010
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == -1)
                {
                    break;
                }
                list.Add(input);
            }
            Console.WriteLine("Search for?");
            int luku = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == luku)
                {
                    Console.WriteLine(luku + " is at index " + i);

                }

            }

        }

    }
}

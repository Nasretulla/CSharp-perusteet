﻿namespace Exercise023
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.Write("Give a string: ");
            string mjono = Console.ReadLine();
            if (mjono == "true")
            {
                Console.WriteLine("You got it right!");

            }
            else
            {
                Console.WriteLine("Try again!");
            }
        }
    }
}

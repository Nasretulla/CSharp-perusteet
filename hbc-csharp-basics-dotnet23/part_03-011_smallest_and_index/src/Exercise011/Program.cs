namespace Exercise011
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
                int luku = Convert.ToInt32(Console.ReadLine());

                if (luku == 9999)
                {
                    break;
                }
                list.Add(luku);

            }
            int smallest = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                int numero = list[i];
                if (smallest > numero)
                {
                    smallest = numero;
                }
            }
            Console.WriteLine("Smallest number: " + smallest);

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == smallest)
                {
                    Console.WriteLine("Found at index: " + i);
                }
            }
        }
    }
}

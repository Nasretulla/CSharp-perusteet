namespace Exercise018
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            // implement here the program that allows the user to enter 
            // book information and to examine them

            List<Book> list = new List<Book>();

            while (true)
            {
                Console.Write("Name: ");

                string nimi = Console.ReadLine();
                if (nimi == "")
                {
                    break;

                }

                Console.Write("Pages: ");

                int sivut = Convert.ToInt32(Console.ReadLine());

                Console.Write("Publication year: ");

                int vuosi = Convert.ToInt32(Console.ReadLine());

                list.Add(new Book(nimi, sivut, vuosi));

            }
            Console.WriteLine();
            Console.Write("What information will be printed? ");

            string mjono = Console.ReadLine();
            foreach (Book value in list)
            {
                if (mjono == "everything")
                {
                    Console.WriteLine(value);
                }
                else if (mjono == "title")
                {
                    Console.WriteLine(value.title);
                }




            }



        }
    }
}
namespace Exercise015
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            // IMPLEMENT YOUR CODE IN HERE!
            List<Item> items = new List<Item>();

            while (true)
            {
                Console.Write("Name: ");
                string mjono = Console.ReadLine();


                if (mjono == "")
                {
                    break;

                }
                items.Add(new Item(mjono));

            }


            Console.WriteLine();
            foreach (Item name in items)
            {
                // Print using ToString
                Console.WriteLine(name);


            }

        }
    }
}
namespace Exercise033
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give the first string:");
            string mjono1 = Console.ReadLine();

            Console.WriteLine("Give the second string:");
            string mjono2 = Console.ReadLine();

            if (mjono1 == mjono2)
            {
                Console.WriteLine("Echo!");
            }
            else
            {
                Console.WriteLine("Nope!");
            }

        }
    }
}

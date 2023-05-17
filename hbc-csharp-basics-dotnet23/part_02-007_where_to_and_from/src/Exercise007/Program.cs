namespace Exercise007
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Where to?");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Where from?");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            for (int i = numero2; i <= numero1; i++)
            {
                Console.WriteLine(i);

            }

        }
    }
}

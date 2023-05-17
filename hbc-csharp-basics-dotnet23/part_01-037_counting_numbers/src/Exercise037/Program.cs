namespace Exercise037
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int num = 0;

            while (true)
            {
                Console.WriteLine("Give a number:");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero == 0)
                {
                    break;
                }
                num += 1;
            }
            Console.WriteLine("Total amount of numbers: " + num);

        }
    }
}

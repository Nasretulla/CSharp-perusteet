namespace Exercise040
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int summa = 0;
            int maara = 0;
            while (true)
            {

                Console.WriteLine("Give a number:");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 0)
                {
                    break;
                }

                summa += input;
                maara += 1;

            }

            Console.WriteLine("Total sum of numbers: " + summa);
            Console.WriteLine("Total amount of numbers: " + maara);
        }
    }
}

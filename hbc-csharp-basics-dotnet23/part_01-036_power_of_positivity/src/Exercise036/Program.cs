namespace Exercise036
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {


            while (true)
            {
                Console.WriteLine("Give a number:");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero == 0)
                {
                    break;
                }
                else if (numero < 0)
                {
                    Console.WriteLine("That is negative");

                }
                else if (numero > 0)
                {
                    int kertoma = numero * numero;
                    Console.WriteLine(kertoma);

                }

            }

        }
    }
}


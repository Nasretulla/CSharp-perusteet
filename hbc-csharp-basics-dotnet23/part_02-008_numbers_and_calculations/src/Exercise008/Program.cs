namespace Exercise008
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Give numbers:");
            int summa = 0;
            int maara = 0;
            double avg = 0;
            int posLuku = 0;
            int negLuku = 0;


            while (true)
            {
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero == -1)
                {
                    Console.WriteLine("Thx! Bye!");
                    break;
                }
                if (numero % 2 == 0)
                {
                    posLuku++;

                }
                else
                {
                    negLuku++;
                }
                summa = numero + summa;
                maara++;
                avg = (double)summa / maara;

            }
            Console.WriteLine("Sum: " + summa);
            Console.WriteLine("Numbers: " + maara);
            Console.WriteLine("Average: " + avg);
            Console.WriteLine("Even: " + posLuku);
            Console.WriteLine("Odd: " + negLuku);

        }
    }
}

namespace Exercise006
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int numero = Convert.ToInt32(Console.ReadLine());

            for (int j = 100; j >= numero; numero++)
            {
                Console.WriteLine(numero);

            }
        }
    }
}

namespace Exercise030
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give your percent [0 - 100]:");
            string userInput = Console.ReadLine();
            int numero = Convert.ToInt32(userInput);
            if (numero < 0)
            {
                Console.WriteLine("Impossible");
            }
            else if (numero < 49)
            {
                Console.WriteLine("Fail");
            }
            else if (numero < 59)
            {
                Console.WriteLine("Grade: 1");
            }
            else if (numero < 69)
            {
                Console.WriteLine("Grade: 2");
            }
            else if (numero < 79)
            {
                Console.WriteLine("Grade: 3");
            }
            else if (numero < 89)
            {
                Console.WriteLine("Grade: 4");

            }
            else if (numero < 100)
            {
                Console.WriteLine("Grade: 5");
            }
            else if (numero > 100)
            {
                Console.WriteLine("Outstanding!");
            }

        }
    }
}

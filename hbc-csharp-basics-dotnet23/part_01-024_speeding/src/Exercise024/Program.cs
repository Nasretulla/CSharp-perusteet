namespace Exercise024
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Your speed:");
            string userInput = Console.ReadLine();

            int numero = Convert.ToInt32(userInput);

            if (numero > 120)
            {
                Console.WriteLine("Speeding!");
            }


        }
    }
}

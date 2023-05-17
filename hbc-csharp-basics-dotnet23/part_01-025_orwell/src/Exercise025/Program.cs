namespace Exercise025
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give a number:");
            string userInput = Console.ReadLine();
            int numero = Convert.ToInt32(userInput);

            if (numero == 1984)
            {
                Console.WriteLine("Orwell");
            }

        }
    }
}

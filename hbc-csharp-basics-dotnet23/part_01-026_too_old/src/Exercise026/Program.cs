namespace Exercise026
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give your year of birth:");
            string userInput = Console.ReadLine();
            int numero = Convert.ToInt32(userInput);

            if (numero < 1900)
            {
                Console.WriteLine("You're old");
            }
        }
    }
}

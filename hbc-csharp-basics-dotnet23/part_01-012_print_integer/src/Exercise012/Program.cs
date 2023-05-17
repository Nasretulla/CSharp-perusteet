namespace Exercise012
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give a number!");

            string userInput = Console.ReadLine();
            int numero = Convert.ToInt32(userInput);

            Console.WriteLine("You gave " + numero);


        }
    }
}

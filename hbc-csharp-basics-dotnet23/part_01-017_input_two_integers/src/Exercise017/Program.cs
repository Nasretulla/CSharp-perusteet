namespace Exercise017
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give the first number!");
            string userInput = Console.ReadLine();
            int numero1 = Convert.ToInt32(userInput);

            Console.WriteLine("Give the second number!");
            string userInput2 = Console.ReadLine();
            int numero2 = Convert.ToInt32(userInput2);

            int sum = numero1 + numero2;
            Console.WriteLine("The sum is " + sum);
        }
    }
}
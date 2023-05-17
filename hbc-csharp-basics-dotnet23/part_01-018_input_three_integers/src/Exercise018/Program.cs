namespace Exercise018
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give the first number!");
            string userInput1 = Console.ReadLine();
            int numero1 = Convert.ToInt32(userInput1);

            Console.WriteLine("Give the second number!");
            string userInput2 = Console.ReadLine();
            int numero2 = Convert.ToInt32(userInput2);

            Console.WriteLine("Give the third number!");
            string userInput3 = Console.ReadLine();
            int numero3 = Convert.ToInt32(userInput3);

            int sum = numero1 + numero2 + numero3;

            Console.WriteLine("The sum is " + sum);


        }
    }
}

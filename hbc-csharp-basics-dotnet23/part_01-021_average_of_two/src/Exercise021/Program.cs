namespace Exercise021
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give the first number!");
            string userInput1 = Console.ReadLine();
            double numero1 = Convert.ToDouble(userInput1);

            Console.WriteLine("Give the second number!");
            string userInput2 = Console.ReadLine();
            double numero2 = Convert.ToDouble(userInput2);

            double sum = numero1 + numero2;

            double avg = sum / 2;

            Console.WriteLine("The average is " + avg);

        }
    }
}

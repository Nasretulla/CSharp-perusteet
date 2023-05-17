namespace Exercise022
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

            Console.WriteLine("Give the third number!");
            string userInput3 = Console.ReadLine();
            double numero3 = Convert.ToDouble(userInput3);


            double sum = numero1 + numero2 + numero3;

            double avg = sum / 3;

            Console.WriteLine("The average is " + avg);

        }
    }
}

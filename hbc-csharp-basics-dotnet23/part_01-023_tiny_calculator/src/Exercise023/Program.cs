namespace Exercise023
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
            double miinus = numero1 - numero2;
            double kerto = numero1 * numero2;
            double avg = numero1 / numero2;

            Console.WriteLine(numero1 + " + " + numero2 + " = " + sum);
            Console.WriteLine(numero1 + " - " + numero2 + " = " + miinus);
            Console.WriteLine(numero1 + " * " + numero2 + " = " + kerto);
            Console.WriteLine(numero1 + " / " + numero2 + " = " + avg);
        }
    }


}




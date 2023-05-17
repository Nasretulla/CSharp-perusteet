namespace Exercise029
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
            string userInput1 = Console.ReadLine();
            int numero2 = Convert.ToInt32(userInput1);

            if (numero1 > numero2)
            {
                Console.WriteLine("The larger number is " + numero1 + "!");
            }
            else if (numero1 == numero2)
            {
                Console.WriteLine("They are equal!");
            }

            else
            {
                Console.WriteLine("The larger number is " + numero2 + "!");

            }
            {


            }



        }
    }
}

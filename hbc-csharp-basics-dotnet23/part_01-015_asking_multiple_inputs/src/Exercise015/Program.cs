namespace Exercise015
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give a string:");
            string mjono = Console.ReadLine();

            Console.WriteLine("Give an integer:");
            string userInput = Console.ReadLine();
            int numero = Convert.ToInt32(userInput);

            Console.WriteLine("Give a double:");
            string userInput1 = Console.ReadLine();
            double numero1 = Convert.ToDouble(userInput1);

            Console.WriteLine("Give a boolean:");
            string truth = Console.ReadLine();
            bool booleanValue = Convert.ToBoolean(truth);


            Console.WriteLine("Your string: " + mjono);
            Console.WriteLine("Your integer: " + numero);
            Console.WriteLine("Your double: " + numero1);
            Console.WriteLine("Your boolean: " + booleanValue);

        }
    }
}

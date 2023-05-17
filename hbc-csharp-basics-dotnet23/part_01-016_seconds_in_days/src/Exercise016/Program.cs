namespace Exercise016
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many days?");
            string userInput = Console.ReadLine();
            int numero = Convert.ToInt32(userInput);
            int seconds = numero * 24 * 60 * 60;

            Console.WriteLine(seconds);





        }
    }
}

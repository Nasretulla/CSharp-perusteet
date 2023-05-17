namespace Exercise031
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give a number:");
            string userInput = Console.ReadLine();
            int numero = Convert.ToInt32(userInput);

            if ((numero % 2) == 0)
            {
                Console.WriteLine("It is even.");
            }
            else
            {
                Console.WriteLine("It is odd.");
            }
        }
    }
}

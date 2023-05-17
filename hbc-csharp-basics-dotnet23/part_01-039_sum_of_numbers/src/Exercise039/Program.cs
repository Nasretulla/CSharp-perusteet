namespace Exercise039
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {


            int sum = 0;

            while (true)
            {

                Console.WriteLine("Give a number:");
                int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == 0)
                {
                    break;
                }
                sum += userInput;
            }
            Console.WriteLine("Total sum of numbers: " + sum);
        }
    }
}


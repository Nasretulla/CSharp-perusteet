namespace Exercise038
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int num = 0;
            while (true)
            {

                Console.WriteLine("Give a number:");
                int userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == 0)
                {
                    break;

                }
                if (userInput < 0)
                {
                    num += 1;

                }

            }
            Console.WriteLine("Total amount of negative numbers: " + num);

        }
    }
}

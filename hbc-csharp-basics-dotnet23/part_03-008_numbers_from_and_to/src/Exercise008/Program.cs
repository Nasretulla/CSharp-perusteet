namespace Exercise008
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();

            while (true)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == -1)
                {
                    break;
                }
                list.Add(number);
            }
            //Write your code here
            Console.WriteLine("From where?");
            int luku1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Where to?");
            int luku2 = Convert.ToInt32(Console.ReadLine());

            foreach (int numero in list)
            {
                if (numero >= luku1 && numero <= luku2)
                {
                    Console.WriteLine(numero);

                }


            }


        }
    }
}

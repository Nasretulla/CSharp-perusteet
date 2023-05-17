namespace Exercise003
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            //Write your code here
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine(num * -1);
            }
            else
            {
                Console.WriteLine(num);
            }

        }
    }
}

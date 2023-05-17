namespace Exercise014
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            //Call your method here:
        }
        //Write your method here:
        public static void DivisibleByThreeInRange(int beginning, int end)
        {
            for (int i = beginning; i <= end; i++)
            {

                if (i % 3 == 0)
                {
                    // If the number is divisible by three, print it.
                    Console.WriteLine(i);
                }
            }


        }
    }
}

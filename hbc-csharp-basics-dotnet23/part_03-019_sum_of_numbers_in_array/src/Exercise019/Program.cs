namespace Exercise019
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {

            int[] numbers = { 5, 1, 5 };
            int sum = SumOfNumbersInArray(numbers);
            Console.WriteLine(sum);
        }

        public static int SumOfNumbersInArray(int[] numbers)
        {
            int summa = 0;
            foreach (int value in numbers)
            {
                summa += value;

            }
            return summa;

        }
    }
}

namespace Exercise002
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            double root = Math.Sqrt(sum);

            Console.WriteLine(root);
        }
    }
}

namespace Exercise014
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give me the truth!");
            string truth = Console.ReadLine();
            bool booleanValue = Convert.ToBoolean(truth);
            Console.WriteLine(booleanValue);


        }
    }
}

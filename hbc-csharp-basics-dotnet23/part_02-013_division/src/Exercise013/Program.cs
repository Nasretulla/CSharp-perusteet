namespace Exercise013
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            //Call your method here
            Division(8, 3);
        }
        //Write your method here
        public static void Division(int numerator, int denominator)
        {
            double tulos = Convert.ToDouble(numerator);
            double tulos1 = Convert.ToDouble(denominator);
            double division = tulos / tulos1;
            Console.WriteLine(division);
        }
    }
}

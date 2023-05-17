namespace Exercise035
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            string mjono = "Give a number:";


            while (true)
            {
                Console.WriteLine(mjono);
                int numero = Convert.ToInt32(Console.ReadLine());
                if (numero == 42)
                {
                    break;
                }
            }
        }
    }
}

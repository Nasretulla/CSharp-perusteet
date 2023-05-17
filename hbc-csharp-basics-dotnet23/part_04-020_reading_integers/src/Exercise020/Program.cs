namespace Exercise020
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {



            while (true)
            {
                string mjono = Console.ReadLine();
                if (mjono == "end")
                {
                    break;

                }
                int luku = Convert.ToInt32(mjono);

                int sum = luku * luku * luku;
                Console.WriteLine(sum);

            }
        }
    }
}
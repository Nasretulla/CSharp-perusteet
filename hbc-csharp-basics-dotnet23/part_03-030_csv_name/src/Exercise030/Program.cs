namespace Exercise030
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int vanhin = 0;
            string nimi = "";

            while (true)
            {
                string mjono = Console.ReadLine();

                if (mjono == "")
                {
                    break;

                }

                string[] pieces = mjono.Split(",");
                int luku = Convert.ToInt32(pieces[1]);

                if (luku > vanhin)
                {
                    vanhin = luku;
                    nimi = pieces[0];


                }

            }
            Console.WriteLine("Name of the oldest: " + nimi);
        }
    }
}
namespace Exercise019
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {

            int laskuri = 0;
            while (true)
            {
                string mjono = Console.ReadLine();

                if (mjono == "end")
                {
                    break;
                }
                laskuri++;


            }
            Console.WriteLine(laskuri);

        }
    }
}
namespace Exercise025
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {


            while (true)
            {
                string text = Console.ReadLine();
                if (string.IsNullOrEmpty(text))
                {
                    break;

                }
                string[] pieces = text.Split();
                foreach (string value in pieces)
                {
                    Console.WriteLine(value);
                }

            }
        }
    }
}



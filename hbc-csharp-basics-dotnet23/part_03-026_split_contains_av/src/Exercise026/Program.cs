namespace Exercise026
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {

            while (true)
            {
                string text = Console.ReadLine();


                if (text == "")
                {
                    break;

                }

                string[] pieces = text.Split();
                foreach (string value in pieces)
                {
                    if (value.Contains("av"))
                    {
                        Console.WriteLine(value);

                    }

                }


            }
        }
    }
}
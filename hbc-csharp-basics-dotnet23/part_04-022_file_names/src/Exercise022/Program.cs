namespace Exercise022
{
    using System;
    using System.IO;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Which file should have its contents printed?");
            string mjono = Console.ReadLine();

            if (mjono == "data.txt")
            {
                string text = File.ReadAllText("data.txt");
                Console.WriteLine(text);

            }
            else if (mjono == "song.txt")
            {
                string laulut = File.ReadAllText("song.txt");
                Console.WriteLine(laulut);

            }
        }
    }
}
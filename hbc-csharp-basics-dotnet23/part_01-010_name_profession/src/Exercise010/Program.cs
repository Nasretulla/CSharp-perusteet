namespace Exercise010
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("I will tell a story, but I need some information.\n" + "Give a name for main character:");


            string nimi = Console.ReadLine();

            Console.WriteLine("Give the character a profession:");

            string tyo = Console.ReadLine();



            Console.WriteLine("Here is the story:" + "\n" + "Once upon a time there was a " + tyo + " called " + nimi + "\n" + "On her way to work, " + nimi + " often pondered what being " + tyo + " meant to them." + "\nWhen you work as a " + tyo + " you meet interesting people." + "\n" + nimi + " enjoys their work as " + tyo + ", The end.");

        }
    }
}

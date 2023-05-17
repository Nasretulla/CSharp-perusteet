namespace Exercise021
{
    using System;
    public class Program
    {
        public static void Main(String[] args)
        {
            ChristmasTree(4);
        }
        public static void PrintStars(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
        public static void PrintSpaces(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(" ");
            }
        }
        public static void PrintRightTriangle(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                PrintSpaces(size - i);
                PrintStars(i);
            }
        }
        public static void ChristmasTree(int height)
        {
            int baseWidth = 3;
            int baseHeight = 2;

            for (int i = 1; i < height; i++)
            {
                PrintSpaces(height - i);
                PrintStars(i * 2 - 1);
                Console.Write("");
            }
            // Pohjan pituus
            for (int i = 0; i < baseHeight; i++)
            {
                PrintSpaces(height - 2);
                PrintStars(baseWidth);
            }
        }
    }
}
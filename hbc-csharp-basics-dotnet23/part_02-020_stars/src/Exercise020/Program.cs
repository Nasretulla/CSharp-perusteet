namespace Exercise020
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            PrintStars(4);
        }
        //Write you methods here
        public static void PrintStars(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        public static void PrintSquare(int size)
        {
            for (int i = 0; i < size; i++)
            {
                PrintStars(size);
            }
        }
        public static void PrintRectangle(int width, int height)
        {
            for (int i = 0; i < height; i++)
            {
                PrintStars(width);

            }
        }
        public static void PrintTriangle(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                PrintStars(i);

            }
        }
    }
}

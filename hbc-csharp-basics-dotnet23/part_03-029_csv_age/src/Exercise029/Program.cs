namespace Exercise029
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int vanhin = 0;
            while (true)
            {
                string mjono = Console.ReadLine();
                if (mjono == "")
                {
                    break;

                }
                string[] pieces = mjono.Split(",");
                int age = Convert.ToInt32(pieces[1]);

                if (vanhin > age)
                {
                    vanhin = age;
                }
            }
            Console.WriteLine("Age of the oldest: " + vanhin);

        }
    }
}
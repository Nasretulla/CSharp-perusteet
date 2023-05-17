namespace Exercise017
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {

            List<TelevisionProgram> list = new List<TelevisionProgram>();
            // IMPLEMENT YOUR CODE IN HERE!

            while (true)
            {
                Console.Write("Name: ");
                string mjono = Console.ReadLine();

                if (mjono == "")
                {
                    break;
                }
                Console.Write("Duration: ");
                int pituus = Convert.ToInt32(Console.ReadLine());

                list.Add(new TelevisionProgram(mjono, pituus));

            }
            Console.WriteLine();

            Console.Write("Program's maximum duration? ");

            int userDuration = Convert.ToInt32(Console.ReadLine());

            foreach (TelevisionProgram value in list)
            {

                if (value.duration <= userDuration)
                {
                    Console.WriteLine(value);

                }
            }
        }
    }
}
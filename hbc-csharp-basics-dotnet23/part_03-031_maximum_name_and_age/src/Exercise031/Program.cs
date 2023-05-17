namespace Exercise031
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            //string pisinNimi = "";
            int vuosi = 2023;

            int nuorin = int.MaxValue;
            int ika = 0;
            string pisin = "";

            while (true)
            {
                string mjono = Console.ReadLine();

                if (mjono == "")
                {
                    break;

                }
                string[] osat = mjono.Split(",");
                int age = Convert.ToInt32(osat[1]);
                string name = osat[0];

                if (name.Length > pisin.Length)
                {
                    pisin = name;

                }
                if (nuorin > age)
                {
                    nuorin = age;
                    ika = vuosi - nuorin;
                }
            }
            Console.WriteLine("Longest name: " + pisin);

            Console.WriteLine("Highest age: " + ika);



        }
    }
}
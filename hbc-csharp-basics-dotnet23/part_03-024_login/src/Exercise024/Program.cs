namespace Exercise024
{
    using System;
    //using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] user = { "alex", "emma" };
            string[] pass = { "sunshine", "haskell" };

            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string passWord = Console.ReadLine();

            if (userName == user[0] && passWord == pass[0] || userName == user[1] && passWord == pass[1])
            {
                Console.WriteLine("You have successfully logged in!");
            }
            else
                Console.WriteLine("Incorrect username or password!");

        }
    }
}
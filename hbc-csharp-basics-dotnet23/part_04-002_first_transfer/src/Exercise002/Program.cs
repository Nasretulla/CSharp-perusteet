namespace Exercise002
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {

            Account heikki = new Account("Heikki's account", 1000.0);
            Account personal = new Account("Personal account", 0);

            heikki.Withdrawal(100.0);

            personal.Deposit(100.0);

            Console.WriteLine(heikki);
            Console.WriteLine(personal);





        }
    }
}
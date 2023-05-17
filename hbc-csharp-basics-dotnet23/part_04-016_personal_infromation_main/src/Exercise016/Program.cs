namespace Exercise016
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<PersonalInformation> list = new List<PersonalInformation>();
            // IMPLEMENT YOUR CODE IN HERE!

            while (true)
            {
                Console.WriteLine("First name:");
                String firstName = Console.ReadLine();



                if (firstName == "")
                {
                    break;

                }

                Console.WriteLine("Last name:");
                String lastName = Console.ReadLine();

                Console.WriteLine("Identification number:");
                string idNumber = Console.ReadLine();

                list.Add(new PersonalInformation(firstName, lastName, idNumber));


            }
            Console.WriteLine();

            foreach (PersonalInformation item in list)
            {
                // Print only first and last name!
                Console.WriteLine(item.firstName + " " + item.lastName);

            }

        }
    }
}
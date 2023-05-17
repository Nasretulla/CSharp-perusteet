using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise002
{



    public class UserInterface
    {

        private JokeManager manageri;
        public UserInterface(JokeManager manageri)
        {
            this.manageri = manageri;
        }
        public void Start()
        {
            tulosta();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "X")
                {
                    break;
                }

                if (command == "1")
                {
                    Console.WriteLine("Write the joke to be added:");
                    string lisattava = Console.ReadLine();
                    manageri.AddJoke(lisattava);
                }
                if (command == "2")
                {
                    Console.WriteLine("Drawing a joke.");

                    Console.WriteLine(manageri.DrawJoke());




                }
                else if (command == "3")
                {
                    Console.WriteLine("Printing the jokes.");

                    manageri.PrintJokes();

                }

            }

        }
        public string tulosta()
        {
            while (true)
            {
                Console.WriteLine("Commands:");
                Console.WriteLine(" 1 - add a joke");
                Console.WriteLine(" 2 - draw a joke");
                Console.WriteLine(" 3 - list jokes");
                Console.WriteLine(" X - stop");

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise002
{
    public class JokeManager
    {

        private List<string> jokes;

        public JokeManager()
        {
            jokes = new List<string>();
        }
        public void AddJoke(string joke)
        {
            jokes.Add(joke);
        }

        public string DrawJoke()
        {

            if (jokes.Count == 0)
            {
                return "Jokes are in short supply.";

            }
            Random rand = new Random();
            int indeksi = rand.Next(0, jokes.Count);
            return jokes[indeksi];

        }

        public void PrintJokes()
        {
            foreach (string value in jokes)
            {
                Console.WriteLine(value);

            }

        }

    }
}
namespace Exercise011
{
    public class Song
    {
        private string artist;
        private string name;
        private int durationInSeconds;

        public Song(string artist, string name, int durationInSeconds)
        {
            this.artist = artist;
            this.name = name;
            this.durationInSeconds = durationInSeconds;
        }

        public override bool Equals(object compared)
        {
            if ((compared == null) || !this.GetType().Equals(compared.GetType()))
            {
                return false;
            }

            Song comparedSong = (Song)compared;

            if (this.artist == comparedSong.artist &&
            this.name == comparedSong.name && this.durationInSeconds == comparedSong.durationInSeconds)
            {
                return true;

            }
            return false;

        }
        public override string ToString()
        {
            return this.artist + ": " + this.name + " (" + this.durationInSeconds + " s)";
        }


    }
}
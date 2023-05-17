namespace Exercise018
{

    using System;

    public class Book
    {
        public string title { get; set; }
        public int pages { get; set; }
        public int year { get; set; }

        public Book(string bookTitle, int numbPage, int year)
        {

            this.title = bookTitle;
            this.pages = numbPage;
            this.year = year;
        }

        public override string ToString()
        {
            return this.title + ", " + this.pages + " pages" + ", " + this.year;
        }



    }
}
using System;

namespace Model
{
    public class Book
    {
        private int id;
        
        public string Author { get; set; }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Title { get; set; }

        public Book(int id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
            return Id + ". " + Title + " by " +Author;
        }
    }
}

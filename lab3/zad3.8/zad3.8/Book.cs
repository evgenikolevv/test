using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3._8
{
    public struct Book
    {   
        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public void Info()
        {
            List<Book> data = Data();
            foreach(Book book in data)
            {
                Console.WriteLine(book.ToString());
            }
        }

        public override string ToString()
        {
            return "title: " + Title + " author: " + Author + " year: " + Year;
        }

        private List<Book> Data()
        {
            List<Book> data = new List<Book>();
            Book firstBook = new Book("Feed", "Mira Grant", 2010);
            Book secondBook = new Book("IT", "Stephen King", 2000);

            data.Add(firstBook);
            data.Add(secondBook);
            return data;
        }
    }
}

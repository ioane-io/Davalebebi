using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_method_class
{
    public class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }
        public void AddBook(string title, string author, int year)
        {
            Book newBook = new Book(title, author, year);
            books.Add(newBook);
            Console.WriteLine("Book added to the library.");
        }
        public void DisplayAllBooks()
        {
            Console.WriteLine("Library Books:");
            foreach (var book in books)
            {
                book.DisplayBookInfo();
            }
        }








    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_method_class
{
    public class Library
    {
        public List<Book> Books = new List<Book>()
        {
              new Book()
              {
                    Title = "red book",
                    Author = "nina",
                    AvailableOfCopy = 5,
              },
              new Book()
              {
                    Title = "black book",
                    Author = "ernesto",
                    AvailableOfCopy = 5,
              },
              new Book()
              {
                    Title = "gray book",
                    Author = "alfredo",
                    AvailableOfCopy = 5,
              }
        };

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void PrintBooks()
        {
            foreach (var book in Books)
            {
                Console.WriteLine($"Book Title: {book.Title}; Author: {book.Author}; Amount Of Copy: {book.AvailableOfCopy}");
            }
        }
    }
}
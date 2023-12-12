using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Task_4_method_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.Title = "red book";
            book.Author = "nina";
            book.AvailableOfCopy = 5;
            var library = new Library();
            library.AddBook(book);
            library.PrintBooks(); 
        }
    } 
}    
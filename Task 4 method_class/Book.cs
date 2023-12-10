using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_method_class
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;

        }
        public void DisplayBookInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Year: {Year}, Available Copies: {AvailableCopies}");
        }
    }
}

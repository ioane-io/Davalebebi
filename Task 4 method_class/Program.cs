namespace Task_4_method_class
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Library myLibrary = new Library();
            Book book1 = new Book("Red Book", "Ann", 1925);
            Book book2 = new Book("Blue Book", "Lee", 1960);
            Book book3 = new Book("Yellow Book", "George", 1949);
            Book book4 = new Book("White Book", "John", 1951);
            Book book5 = new Book("Pink Book", "Lola", 1813);
            Console.WriteLine("Information about the Books:");
            book1.DisplayBookInfo();
            book2.DisplayBookInfo();
            book3.DisplayBookInfo(); 
            book4.DisplayBookInfo();
            book5.DisplayBookInfo();

            Console.ReadLine();
        }
    }
}

        
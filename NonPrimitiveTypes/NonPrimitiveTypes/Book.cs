using System;

namespace NonPrimitiveTypes
{
     internal class Book
     {
        public string title;
        private string author;
        private string ISBN;

        public Book (string title, string author, string ISBN)
        {
            this.title = title;
            this.author = author;
            this.ISBN = ISBN;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Author: " + this.author);
            Console.WriteLine("ISBN: " + this.ISBN);
        }

        public static void Compare(Book book1, Book book2)
        {
            Console.WriteLine("book1 {0} == book2 {1} ? {2}",
                book1.ISBN, book2.ISBN, book1.ISBN == book2.ISBN);
        }
    }
}

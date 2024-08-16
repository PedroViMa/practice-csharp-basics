using System;
using System.Collections.Generic;


namespace NonPrimitiveTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            Book bookToRemove = new Book("Las Jirafas no Pueden Bailar", "Andreae, Giles", "ISBN");
            books.Add(bookToRemove);
            books.Add(new Book("El Monstruo de Colores", "Llenas Serra, Anna", "ISBN"));
            books.Add(new Book("El Pollo Pepe", "Denchfield, Nick", "ISBN"));
            books.Add(new Book("Puedo Mirar tu Panal", "van Genechten, Guido", "HELLO"));

            Console.WriteLine("Lista de libros");
            foreach (Book book in books)
            {
                book.DisplayDetails();
            }

            books.Remove(bookToRemove);

            Console.WriteLine("\n\n");
            Console.WriteLine("Lista de libros sin Jiarafas");
            foreach (Book book in books)
            {
                book.DisplayDetails();
            }

            Book.Compare(books[0], books[1]);
            Book.Compare(books[0], books[2]);
        }
    }
}

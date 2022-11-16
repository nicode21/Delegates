using System;
using System.Collections.Generic;

namespace BookFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> list = new List<Book>();

            Book book1 = new Book("Nizami","Xemse");
            Book book2 = new Book("Nizami" ,"Yeddi Gozel");
            Book book3 = new Book("Filankes", "Filan");
            Book book4 = new Book("Nizami", "Filan");

            list.Add(book1);
            list.Add(book2);
            list.Add(book3);
            list.Add(book4);

            Predicate<List<Book>> func = Book.CheckBooks;

            Book.GetFilteredBook(func,list);
        }
    }
}

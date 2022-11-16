using System;
using System.Collections.Generic;
using System.Text;

namespace BookFilter
{
    public class Book
    {
        public string Author { get; set; }

        public string Name { get; set; }

        public static List<Book> BList;

        public Book(string author,string name)
        {
            Author=author;
            Name=name;
        }

        public static bool CheckBooks(List<Book> list)
        {
            BList=list;
            int count =0;
            foreach (var item in list)
            {
                if (item.Author=="Nizami")
                {
                    count++;
                }
            }
            if (count==0)
            {
                return false;
            }
            else
            {
                Console.WriteLine(count);
                return true;
            }
        }


        public static void GetFilteredBook(Predicate<List<Book>> func , List<Book>list)
        {
            func(list);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class IteratorTest
    {
        public static void Test()
        {
            BookShelf bookShelf = new BookShelf();

            bookShelf.AddBook(new Book("Around the World in 80 Days"));
            bookShelf.AddBook(new Book("Bible"));
            bookShelf.AddBook(new Book("Cinderella"));
            bookShelf.AddBook(new Book("Daddy Long Legs"));

            Iterator it = bookShelf.iterator();

            while (it.HasNext())
            {
                Book book = (Book)it.Next();
                Console.WriteLine(book.Name);
            }
        }
    }
}

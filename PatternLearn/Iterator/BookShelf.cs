using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class BookShelf : Aggregate
    {
        private List<Book> books = new List<Book>();

        public int Length { get { return books.Count; } }

        public BookShelf() { }

        public void AddBook(Book book)
        {
            books.Add(book);
        }  

        public Book GetBook(int index)
        {
            return books[index];
        }

        public Iterator iterator()
        {
            return new BookShelfIterator(this);
        }
    }
}

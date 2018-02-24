using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class BookShelfIterator : Iterator
    {
        private BookShelf bookShelf;

        private int index;

        public BookShelfIterator(BookShelf bookShelf)
        {
            this.bookShelf = bookShelf;
        }

        public bool HasNext()
        {
            if (index < bookShelf.Length) return true;
            return false;
        }

        public object Next()
        {   
            return bookShelf.GetBook(index++);
        }
    }
}

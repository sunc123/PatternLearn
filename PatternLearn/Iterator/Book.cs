using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class Book
    {
        private string name;
        public string Name { get { return name; } }

        public Book(string name)
        {
            this.name = name;
        }
    }
}

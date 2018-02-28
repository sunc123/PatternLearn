using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public abstract class Page
    {
        protected string title;
        protected string author;
        protected List<Item> content = new List<Item>();

        protected StringBuilder builder = new StringBuilder();
        public Page(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public void Add(Item item)
        {
            content.Add(item);
        }

        public void Output()
        {
            string fileName = title + ".html";

            System.IO.File.WriteAllText(fileName, MakeHTML(), Encoding.UTF8);

            Console.WriteLine("over");
        }

        public abstract string MakeHTML();
    }
}

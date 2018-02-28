
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class Directory : Entry
    {
        private string name;
        private List<Entry> list = new List<Entry>();
        
        
        public Directory(string name)
        {
            this.name = name;
        }

        public override Entry Add(Entry entry)
        {
            list.Add(entry);
            entry.root = this;
            return this;
        }

        public override string GetName()
        {
            return name;
        }

        public override int GetSize()
        {
            int size = 0;

            list.ForEach(item => size += item.GetSize());

            return size;
        }

        public override void PrintList(string prefix)
        {
            Console.WriteLine(prefix + "/" + this);

            list.ForEach(item => item.PrintList(prefix + "/" + name));
            
        }
    }
}

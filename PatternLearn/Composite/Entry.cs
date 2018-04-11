using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public abstract class Entry : VisitElement
    {
        public Entry root;

        public abstract string GetName();

        public abstract int GetSize();

        public abstract Entry Add(Entry entry);

        public void Print()
        {
            PrintList("");
        }

        public virtual void Accept(Visitor visitor) { }

        public override string ToString()
        {
            return GetName() + " (" + GetSize() + ")";
        }

        public abstract void PrintList(string prefix);

        public string GetPath()
        {
            StringBuilder path = new StringBuilder();

            path.Append(GetName());

            Entry tmp = root;

            while(tmp != null)
            {
                path.Insert(0, "/");
                path.Insert(0, tmp.GetName());
                tmp = tmp.root;
            }
            path.Insert(0, "/");
            return path.ToString();
        }
    }
}

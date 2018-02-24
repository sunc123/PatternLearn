using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    abstract class Product
    {
        protected static int NextNumber = 0;

        protected int id;

        public int ID { get { return id; } }

        public abstract void Use();
    }
}

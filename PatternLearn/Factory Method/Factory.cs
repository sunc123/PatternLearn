using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    abstract class Factory
    {
        public Product Creat(string owner)
        {
            Product p = CreatProduct(owner);
            RegisterProduct(p);
            return p;
        }

        protected abstract Product CreatProduct(string owner);
        protected abstract void RegisterProduct(Product product);
    }
}

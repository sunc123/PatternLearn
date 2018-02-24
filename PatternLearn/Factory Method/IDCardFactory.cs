using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class IDCardFactory : Factory
    {
        private List<Product> products = new List<Product>();

        public IDCardFactory() { }

        protected override Product CreatProduct(string owner)
        {
            return new IDCard(owner);
        }

        protected override void RegisterProduct(Product product)
        {
            products.Add(product);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class IDCardFactory : Factory
    {
        private Dictionary<int, Product> products = new Dictionary<int, Product>();

        public IDCardFactory() { }

        protected override Product CreatProduct(string owner)
        {
            return new IDCard(owner);
        }

        protected override void RegisterProduct(Product product)
        {
            products.Add(product.ID,product);
        }

        public Product GetProduct(int id)
        {
            return products[id];
        }
    }
}

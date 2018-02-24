using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class FactoryTest
    {
        public static void Test()
        {
            string[] names = { "ming", "hong", "gang" };

            Factory f = new IDCardFactory();

            Product p1 = f.Creat(names[0]);
            Product p2 = f.Creat(names[1]);
            Product p3 = f.Creat(names[2]);

            p1.Use();
            p2.Use();
            p3.Use();

            Console.WriteLine();

            string format = "第{0}个IDCard的姓名是{1}.";

            Console.WriteLine(string.Format(format, 2, ((IDCard)(((IDCardFactory)f).GetProduct(2))).Owner));
            Console.WriteLine(string.Format(format, 0, ((IDCard)(((IDCardFactory)f).GetProduct(0))).Owner));
            Console.WriteLine(string.Format(format, 1, ((IDCard)(((IDCardFactory)f).GetProduct(1))).Owner)); 
        }
    }
}

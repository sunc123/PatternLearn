using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class DecoratorTest
    {
        public static void Test()
        {
            Milk m = new OriginalMilk(10);
            Milk d1 = new StrawberryDeco(m, 5);
            Milk d2 = new PotatoDeco(d1, 2);

            Console.WriteLine(d2.GetName() + "  " + d2.GetCost());
        }

    }
}

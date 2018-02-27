using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class BridgeTest
    {
        public static void Test()
        {
            Display d = new Display(new StringDisplayImpl("Hello World"));

            Display e = new CountDisplay(new StringDisplayImpl("Hello China"));

            CountDisplay f = new CountDisplay(new StringDisplayImpl("Hello Unity"));

            d.DisplayAll();

            e.DisplayAll();

            f.DisplayAll();

            f.MultiDisplayAll(5);
        }
    }
}

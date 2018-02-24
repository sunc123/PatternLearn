using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class AdapterTest
    {
        public static void Test()
        {
            Print p = new PrintBanner(new Banner("Hello World"));

            p.PrintStrong();
            p.PrintWeak();
        }
    }
}

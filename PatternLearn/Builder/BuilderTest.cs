using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class BuilderTest
    {
        public static void Test()
        {
            TextBuilder t = new TextBuilder();
            HtmlBuilder h = new HtmlBuilder();

            Director d = new Director(t);
            d.Construct();
            Console.WriteLine(t.ToString());

            Console.ReadKey();
            d = new Director(h);
            d.Construct();
            Console.WriteLine(h.ToString());
        }
    }
}

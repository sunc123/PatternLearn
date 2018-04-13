using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class FlyweightTest
    {
        public static void Test()
        {
            BigString str = new BigString("hello world");

            str.Print();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class TemplateTest
    {
        public static void Test()
        {
            AbstarctDisplay a1 = new CharDisplay('A');
            a1.Display();

            AbstarctDisplay a2 = new StringDisplay("Hello World");
            a2.Display();

            AbstarctDisplay a3 = new StringDisplay("你好，世界!");
            a3.Display();
        }
    }
}

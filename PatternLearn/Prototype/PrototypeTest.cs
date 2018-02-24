using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class PrototypeTest
    {
        public static void Test()
        {
            string[] names = { "strong", "normal", "weak" };

            Manager m = new Manager();

            m.Register(names[0], new UnderPen('-'));
            m.Register(names[1], new MessageBox('*'));
            m.Register(names[2], new MessageBox('/'));

            IClone i1 = m.Creat(names[0]);
            i1.Use("Hello World");

            i1 = m.Creat(names[1]);
            i1.Use("Hello World");

            i1 = m.Creat(names[2]);
            i1.Use("Hello World");
        }
    }
}

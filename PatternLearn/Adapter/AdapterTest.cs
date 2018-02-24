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

            Console.ReadKey();
            Console.WriteLine();

            string[] array = { "year" };

            Properties pro = new Properties(array);
            pro.SetValue(array[0], "1999");
            pro.Print();

            PropertiesPrint print = new PropertiesPrint(pro);
            print.SetValue("day", "24");
            print.SetValue("year", "2018");
            print.SetValue("month", "2");
            print.Print();
        }
    }
}

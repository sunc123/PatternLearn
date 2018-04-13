using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class ProxyTest
    {
        public static void Test()
        {
            Printable p = new PrinterProxy("Alice");
            Console.WriteLine("现在的名字是(" + p.GetPrinterName() + ").");
            p.SetPrinterName("Bob");
            Console.WriteLine("现在的名字是(" + p.GetPrinterName() + ").");
            p.Print("Hello, world.");
        }
    }
}

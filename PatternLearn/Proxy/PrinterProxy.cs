using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class PrinterProxy : Printable
    {
        private string name;
        private Printer printer;

        public PrinterProxy() { }

        public PrinterProxy(string name)
        {
            this.name = name;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void SetPrinterName(string name)
        {
            if (printer != null)
            {
                printer.SetPrinterName(name);
            }
            this.name = name;
        }

        public string GetPrinterName()
        {
            return name;
        }

        public void Print(string str)
        {
            Init();

            printer.Print(str);
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        void Init()
        {
            if (printer == null)
            {
                printer = new Printer(name);
            }
        }
    }
}

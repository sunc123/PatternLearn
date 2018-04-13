using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public interface Printable
    {
        void SetPrinterName(string name);
        string GetPrinterName();
        void Print(string str);
    }
}

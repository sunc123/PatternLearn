using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class Printer : Printable
    {
        private string name;    

        public Printer()
        {
            HeavyJob("is creating printer");
        }

        public Printer(string name)
        {
            this.name = name;

            HeavyJob("is creating printer (" + name + ")");
        }

        public void SetPrinterName(string name)
        {
            this.name = name;
        }

        public string GetPrinterName()
        {
            return name;
        }

        public void Print(string str)
        {
            Console.WriteLine("=== " + name + " ===");
            Console.WriteLine(str);
        }

        void HeavyJob(string msg)
        {
            Console.WriteLine(msg);
            for (int i = 0; i < 5; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine(" over.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class StringDisplayImpl : DisplayImpl
    {
        private string str;
        private int width;

        public StringDisplayImpl(string str)
        {
            this.str = str;
            this.width = str.Length;
        }

        public override void RawOpen()
        {
            printLine();
        }

        public override void RawPrint()
        {
            Console.WriteLine("|{0}|", str);
        }

        public override void RawClose()
        {
            printLine();
        }

        private void printLine()
        {
            Console.Write("+");
            for (int i = 0; i < width; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
    }
}

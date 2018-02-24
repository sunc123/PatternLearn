using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class StringDisplay : AbstarctDisplay
    {
        private string str;

        public StringDisplay(string str)
        {
            this.str = str;
        }

        protected override void Open()
        {
            PrintLine();
        }

        protected override void Print()
        {
            Console.WriteLine("|{0}|", str);
        }

        protected override void Close()
        {
            PrintLine();
        }

        private void PrintLine()
        {
            Console.Write('+');
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write('-');
            }
            Console.Write('+');
            Console.WriteLine();
        }
    }
}

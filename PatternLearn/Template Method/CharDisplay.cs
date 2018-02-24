using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class CharDisplay : AbstarctDisplay
    {
        private char mChar;

        public CharDisplay(char mChar)
        {
            this.mChar = mChar;
        }  

        protected override void Open()
        {
            Console.Write("<<");
        }

        protected override void Print()
        {   
            Console.Write(mChar);
        }

        protected override void Close()
        {
            Console.Write(">>");
            Console.WriteLine();
        }
    }
}

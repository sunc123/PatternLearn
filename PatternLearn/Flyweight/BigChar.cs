using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class BigChar
    {
        private char charname;

        public BigChar(char charname)
        {
            this.charname = charname;
        }

        public void Print()
        {
            Console.Write(charname);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class UnderPen : IClone
    {
        private char mChar;

        public UnderPen(char mChar)
        {
            this.mChar = mChar;
        }

        public IClone Clone()
        {
            return new UnderPen(mChar);
        }

        public void Use(string str)
        {
            Console.WriteLine();
            Console.Write("|");
            Console.Write(str);
            Console.Write("|");
            Console.WriteLine();
            for (int i = 0; i < str.Length + 2; i++)
            {
                Console.Write(mChar);
            }
            Console.WriteLine();
        }
    }
}

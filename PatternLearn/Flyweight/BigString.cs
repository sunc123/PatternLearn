using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class BigString
    {
        private BigChar[] bigchars;

        public BigString(string str)
        {
            bigchars = new BigChar[str.Length];

            BigCharFactory factory = BigCharFactory.Singleton;

            for (int i = 0; i < str.Length; i++)
            {
                bigchars[i] = factory.GetBigChar(str[i]);
            }
        }

        public void Print()
        {
            for (int i = 0; i < bigchars.Length; i++)
            {
                bigchars[i].Print();
            }
        }
    }
}

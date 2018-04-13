using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class BigCharFactory
    {
        private Dictionary<char, BigChar> pool = new Dictionary<char, BigChar>();

        private static BigCharFactory factory = new BigCharFactory();

        public static BigCharFactory Singleton { get { return factory; } }

        private BigCharFactory() { }

        public BigChar GetBigChar(char charname)
        {
            BigChar bc;
            if(!pool.TryGetValue(charname, out bc))
            {
                bc = new BigChar(charname);

                pool.Add(charname, bc);
            }   
            return bc;
        }
    }
}

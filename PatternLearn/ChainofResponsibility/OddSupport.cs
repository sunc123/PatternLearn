using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class OddSupport : Support
    {
        public OddSupport(string name) : base(name)
        {  
        }

        protected override bool Resolve(Trouble trouble)
        {
            if (trouble.Difficulty % 2 == 1)
            {
                return true;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class LimitSupprot : Support
    {
        private int limit;

        public LimitSupprot(string name, int limit) : base(name)
        {
            this.limit = limit;
        }

        protected override bool Resolve(Trouble trouble)
        {                                                       
            if (trouble.Difficulty < limit)
            {
                return true;
            }
            return false;
        }
    }
}

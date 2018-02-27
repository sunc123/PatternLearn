using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class CountDisplay : Display
    {
        public CountDisplay(DisplayImpl impl) : base(impl)
        {
        }

        public void MultiDisplayAll(int times)
        {
            Open();
            for (int i = 0; i < times; i++)
            {
                Print();
            }
            Close();
        }
    }
}

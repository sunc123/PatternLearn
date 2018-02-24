using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    abstract class AbstarctDisplay
    {
        protected abstract void Open();
        protected abstract void Print();
        protected abstract void Close();

        //如果是接口的话，就不能添加实现
        public void Display()
        {
            Open();
            for (int i = 0; i < 5; i++)
            {
                Print();
            }
            Close();
        }
    }
}

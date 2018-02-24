using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class Manager
    {
        private Dictionary<string, IClone> showCase = new Dictionary<string, IClone>();

        public Manager() { }

        public void Register(string str, IClone clone)
        {
            showCase.Add(str, clone);
        }

        public IClone Creat(string str)
        {
            IClone i = showCase[str];

            return i.Clone();
        }
    }
}

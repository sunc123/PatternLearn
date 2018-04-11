using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public interface VisitElement
    {
        void Accept(Visitor visitor);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class PotatoDeco : MilkDecorator
    {  
        public PotatoDeco(Milk milk, float cost) : base(milk, cost)
        {
            name = "Potato";
        } 
    }
}

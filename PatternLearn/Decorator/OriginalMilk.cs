using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class OriginalMilk : Milk
    {
        private string name = "OriginalMilk";
        private float cost;

        public OriginalMilk(float cost)
        {
            this.cost = cost;
        }

        public override string GetName()
        {
            return name;
        }

        public override float GetCost()
        {
            return cost;
        }
    }
}

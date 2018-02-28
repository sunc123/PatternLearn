using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public abstract class MilkDecorator : Milk
    {
        protected string name;

        protected float cost;

        protected Milk milk;

        protected MilkDecorator(Milk milk, float cost)
        {
            this.milk = milk;
            this.cost = cost;
        }

        public override float GetCost()
        {
            return milk.GetCost() + cost;
        }

        public override string GetName()
        {
            return name + " " + milk.GetName();
        }

    }
}

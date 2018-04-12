using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class IncremetalNumberGenerator : NumberGenerator
    {
        private int start;
        private int end;
        private int per;

        public IncremetalNumberGenerator(int start, int end, int per)
        {
            this.start = start;
            this.end = end;
            this.per = per;
        }

        public override void Execute()
        {
            do
            { 
                NotifyObservers();
                start += per;
            } while (start <= end);
        }

        public override int GetNumber()
        {
            return start;
        }
    }
}

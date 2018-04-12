using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class DigitObserver : Observer
    {
        public void Update(NumberGenerator generator)
        {
            Console.WriteLine("DigitObserver: " + generator.GetNumber());

            Thread.Sleep(100);
        }
    }
}

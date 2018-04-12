using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class ObserverTest
    {
        public static void Test()
        {
            //NumberGenerator generator = new RandomNumberGenerator();

            NumberGenerator generator = new IncremetalNumberGenerator(10, 50, 5);

            Observer o1 = new DigitObserver();

            Observer o2 = new GraphObserver();

            generator.AddObserver(o1);

            generator.AddObserver(o2);

            generator.Execute();
        }
    }
}

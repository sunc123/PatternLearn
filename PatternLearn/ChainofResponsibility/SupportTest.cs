using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class SupportTest
    {
        public static void Test()
        { 
            Support alice = new NoSupport("Alice");
            Support bob = new LimitSupprot("Bob", 100);
            Support charlie = new SpecialSupport("Charlie", 429);
            Support diana = new LimitSupprot("Diana", 200);
            Support elmo = new OddSupport("Elmo");
            Support fred = new LimitSupprot("Fred", 300);

            alice.SetNext(bob).SetNext(charlie).SetNext(diana).SetNext(elmo).SetNext(fred);

            for (int i = 0; i < 500; i += 33)
            {
                alice.SupportTrouble(new Trouble(i));
            }

        }
    }
}

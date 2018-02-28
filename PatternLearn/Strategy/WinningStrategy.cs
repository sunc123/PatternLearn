using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class WinningStrategy : Strategy
    {
        private Random random;
        private bool won = false;
        private Hand preHand;

        public WinningStrategy(int seed)
        {
            random = new Random(seed);
        }

        public Hand NextHand()
        {
            if (!won)
            {
                preHand = Hand.GetHand(random.Next(3));
            }

            return preHand;
        }

        public void Study(bool win)
        {
            won = win;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class ProStrategy : Strategy
    {
        private Random random;
                                  
        private int preHandValue = 0;

        private int currentHandValue = 0;

        private int[][] history = 
        {
            new int[] {1, 1, 1 },
            new int[] {1, 1, 1 },
            new int[] {1, 1, 1 }
        };

        public ProStrategy(int seed)
        {
            random = new Random(seed);
        }


        public Hand NextHand()
        {
            int bet = random.Next(getSum(currentHandValue));
            int handValue = 0;

            if (bet < history[currentHandValue][0])
            {
                handValue = 0;
            }
            else if (bet < history[currentHandValue][0] + history[currentHandValue][1])
            {
                handValue = 1;
            }
            else
            {
                handValue = 2;
            }
            preHandValue = currentHandValue;
            currentHandValue = handValue;
            return Hand.GetHand(handValue); 
        }

        private int getSum(int hv)
        {
            int sum = 0;

            for (int i = 0; i < hv; i++)
            {
                sum += history[hv][i];
            }
            return sum;
        }

        public void Study(bool win)
        {
            if (win)
            {
                history[preHandValue][currentHandValue]++;
            }
            else
            {
                history[preHandValue][(currentHandValue + 1) % 3]++;
                history[preHandValue][(currentHandValue + 2) % 3]++;
            }
        }
    }
}

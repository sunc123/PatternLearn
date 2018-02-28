using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class Hand
    {
        public static int GUU = 0;
        public static int CHO = 1;
        public static int PAA = 2;
        public static Hand[] hand =
        {
            new Hand(GUU),
            new Hand(CHO),
            new Hand(PAA)
        };

        private static string[] name =
        {
            "石头", "剪刀","布"
        };


        private int handValue;

        private Hand(int value)
        {
            handValue = value;
        }

        public static Hand GetHand(int value)
        {
            return hand[value];
        }

        public bool IsStrongerThan(Hand h)
        {
            return fight(h) == 1;
        }

        public bool IsWeakerTran(Hand h)
        {
            return fight(h) == -1;
        }

        public override string ToString()
        {
            return name[handValue];
        }

        private int fight(Hand h)
        {
            if (this == h)
            {
                return 0;
            }
            else if ((handValue + 1) % 3 == h.handValue)
            {
                return 1;
            }
            return -1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class StrategyTest
    {
        public static void Test()
        {
            Player people = new Player("peo", new ProStrategy(1));
            Player computer = new Player("com", new WinningStrategy(1000));

            for (int i = 0; i < 10000; i++)
            {
                Hand h1 = people.nextHand();
                Hand h2 = computer.nextHand();

                if (h1.IsStrongerThan(h2))
                {
                    Console.WriteLine("Winner : " + people);
                    people.Win();
                    computer.Lose();
                }
                else if (h1.IsWeakerTran(h2))
                {
                    Console.WriteLine("Winner : " + computer);
                    computer.Win();
                    people.Lose();
                }
                else
                {
                    Console.WriteLine("Even...");
                    computer.Even();
                    people.Even();
                }
            }

            Console.WriteLine();
            Console.WriteLine(people.ToString());
            Console.WriteLine(computer.ToString());
        } 

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class MementoTest
    {
        public static void Test()
        {
            string path = "game.dat";

            Gamer gamer = new Gamer(100);

            if (System.IO.File.Exists(path))
            {
                gamer.RestoreMemento(path);
            }

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("==== " + i);
                Console.WriteLine("state : " + gamer);

                gamer.Bet();

                Console.WriteLine("money : " + gamer.Money);

                

                if (gamer.Money > gamer.PreviousMoney)
                {
                    Console.WriteLine("money add, save");
                    gamer.CreatMemento(path);
                }
                else if (gamer.Money < gamer.PreviousMoney / 2)
                {
                    Console.WriteLine("money cut, return");
                    gamer.RestoreMemento(path);
                } 
            }
        }
    }
}

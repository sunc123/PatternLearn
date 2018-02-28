using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class Player
    {
        private string name;
        private Strategy startegy;
        private int winCount;
        private int loseCount;
        private int gameCount;

        public Player(string name, Strategy startegy)
        {
            this.name = name;
            this.startegy = startegy;
        }

        public Hand nextHand()
        {
            return startegy.NextHand();
        }

        public void Win()
        {
            startegy.Study(true);
            winCount++;
            gameCount++;
        }

        public void Lose()
        {
            startegy.Study(false);
            loseCount++;
            gameCount++;
        }

        public void Even()
        {
            gameCount++;
        }

        public override string ToString()
        {
            return "[" + name + ":" + gameCount + " games, " + winCount + " win, " + loseCount + " lose" + "]";
        }

    }
}

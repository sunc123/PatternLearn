using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class Trouble
    {
        private int difficulty;

        public int Difficulty { get { return difficulty; } }

        public Trouble(int difficulty)
        {
            this.difficulty = difficulty;
        }

        public override string ToString()
        {
            return "[Trouble " + difficulty + "]";
        }
    }
}

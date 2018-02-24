using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class IDCard : Product
    {
        private string owner;

        public IDCard(string owner)
        {
            this.owner = owner;
            Console.WriteLine("creat {0}'s IDCard.", owner);
        }

        public override void Use()
        {
            Console.WriteLine("used {0}'s IDCard.", owner);
        }
    }
}

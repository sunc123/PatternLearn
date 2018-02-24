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
        
        public string Owner { get { return owner; } }  

        public IDCard(string owner)
        {
            this.owner = owner;
            this.id = NextNumber++;
            Console.WriteLine("creat {0}'s IDCard[{1}].", owner, id);
        }

        public override void Use()
        {
            Console.WriteLine("used {0}'s IDCard[{1}].", owner, id);
        }
    }
}

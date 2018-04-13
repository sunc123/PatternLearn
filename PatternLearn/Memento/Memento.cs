using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    [Serializable]
    internal class Memento
    {
        int money;
        int number;
        List<string> fruits;

        internal int Money { get { return money; } }
        internal int Number { get { return number; } }

        internal Memento(int money, int number)
        {
            this.money = money;
            this.number = number;
            fruits = new List<string>();
        }

        internal void AddFruit(string fruit)
        {
            fruits.Add(fruit);
        }

        internal List<string> GetFruits()
        {
            return new List<string>(fruits);
        }
    }
}

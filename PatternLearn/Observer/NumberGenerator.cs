using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public abstract class NumberGenerator
    {
        private List<Observer> list = new List<Observer>();

        public void AddObserver(Observer observer)
        {
            list.Add(observer);
        }

        public void DeleteObserver(Observer observer)
        {
            list.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var item in list)
            {
                item.Update(this);
            }
        }

        public abstract int GetNumber();

        public abstract void Execute();
    }
}

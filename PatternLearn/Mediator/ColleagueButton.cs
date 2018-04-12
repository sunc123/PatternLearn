using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class ColleagueButton : Colleague
    {
        private string name;

        private Mediator mediator;

        public ColleagueButton(string name)
        {
            this.name = name;
        }
          
        public void SetMediator(Mediator mediator)
        {
            this.mediator = mediator;
        }
        public void SetColleagueEnabled(bool enabled)
        {
            if (enabled)
            {
                Console.WriteLine("[" + name + "] 已打开");
            }
            else
            {
                Console.WriteLine("[" + name + "] 已关闭");
            }
        }  
    }
}

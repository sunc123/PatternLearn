using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class SafeFrame : Context
    {
        private State state = DayState.Singleton;

        public State CurrentState { get { return state; } }

        public SafeFrame() { }

        public void SetClock(int hour)
        {
            string clockstring = "now is ";
            if (hour < 10)
            {
                clockstring += "0" + hour + ":00";
            }
            else
            {
                clockstring += hour + ":00";
            }

            Console.Clear();
            Console.WriteLine(clockstring);
            state.DoClock(this, hour);
        }

        public void ChangeState(State state)
        {
            Console.WriteLine("state from" + this.state + " to " + state);
            this.state = state; 
        }

        public void CallSecurityCenter(string msg)
        {
            Console.WriteLine("call! " + msg + "\n");
        }
               
        public void RecordLog(string msg)
        {
            Console.WriteLine("recording... " + msg + "\n");
        }   
    }
}

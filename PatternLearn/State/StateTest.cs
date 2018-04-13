using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PatternLearn
{
    class StateTest
    {
        public static void Test()
        {
            SafeFrame frame = new SafeFrame();

            while (true)
            {
                for (int i = 0; i < 24; i++)
                {
                    frame.SetClock(i);

                    frame.CurrentState.DoAlarm(frame);

                    frame.CurrentState.DoPhone(frame);

                    frame.CurrentState.DoUse(frame);
                                         
                    Thread.Sleep(1000);
                }
            }
        }
    }
}

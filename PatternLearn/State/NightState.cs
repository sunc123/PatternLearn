using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class NightState : State
    {
        private static NightState singleton = new NightState();

        private NightState() { }

        public static NightState Singleton { get { return singleton; } }

        public void DoClock(Context context, int hour)
        {
            if (hour >= 8 && hour < 21)
            {
                context.ChangeState(DayState.Singleton);
            }
        }

        public void DoAlarm(Context context)
        {
            context.CallSecurityCenter("按下警铃(晚上)");
        }

        public void DoUse(Context context)
        {
            context.CallSecurityCenter("紧急: 晚上使用金库!");
        }

        public void DoPhone(Context context)
        {
            context.RecordLog("晚上的通话录音");
        }

        public override string ToString()
        {
            return "[ 晚上 ]";
        }
    }
}

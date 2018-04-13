using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class DayState : State
    {
        private static DayState singleton = new DayState();

        private DayState() { }

        public static DayState Singleton { get { return singleton; } }

        public void DoClock(Context context, int hour)
        {
            if (hour < 8 || hour >= 21)
            {
                context.ChangeState(NightState.Singleton);
            }
            else if (hour >= 12 && hour < 13)
            {
                context.ChangeState(LunchState.Singleton);
            }
        }

        public void DoAlarm(Context context)
        {
            context.CallSecurityCenter("按下警铃(白天)");
        }

        public void DoUse(Context context)
        {
            context.CallSecurityCenter("正常通话(白天)");
        }

        public void DoPhone(Context context)
        {
            context.RecordLog("使用金库(白天)");
        }

        public override string ToString()
        {
            return "[ 白天 ]";
        }
    }
}

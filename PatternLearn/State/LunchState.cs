using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class LunchState : State
    {
        private static LunchState singleton = new LunchState();

        private LunchState() { }

        public static LunchState Singleton { get { return singleton; } }

        public void DoClock(Context context, int hour)
        {
            if (hour >= 9 && hour < 17)
            {
                context.ChangeState(DayState.Singleton);
            }
        }

        public void DoAlarm(Context context)
        {
            context.CallSecurityCenter("午餐时间按下警铃");
        }

        public void DoUse(Context context)
        {
            context.CallSecurityCenter("午餐时间使用金库!");
        }

        public void DoPhone(Context context)
        {
            context.RecordLog("午餐时间的通话录音");
        }

        public override string ToString()
        {
            return "[ 午餐时间 ]";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public interface State
    {
        void DoClock(Context context, int hour);
        void DoUse(Context context);    
        void DoAlarm(Context context);
        void DoPhone(Context context);
    }
}

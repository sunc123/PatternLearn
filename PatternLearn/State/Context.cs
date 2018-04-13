﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public interface Context
    {
        void SetClock(int hour);
        void ChangeState(State state);
        void CallSecurityCenter(string msg);
        void RecordLog(string msg);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public interface Observer
    {
        void Update(NumberGenerator generator);
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class NoSupport : Support
    {
        public NoSupport(string name) : base(name)
        {
        }

        protected override bool Resolve(Trouble trouble)
        {
            return false;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public abstract class Builder
    {
        public abstract void MakeTitle(string title);
        public abstract void MakeString(string str);
        public abstract void MakeItems(string[] items);
        public abstract void Close();
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public abstract class Item
    {
        protected string caption;

        public Item(string caption)
        {
            this.caption = caption;
        }

        public abstract string MakeHtml();
    }
}

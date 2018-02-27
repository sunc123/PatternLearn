﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class Display
    {
        private DisplayImpl impl;
        public Display(DisplayImpl impl)
        {
            this.impl = impl;
        }

        public void Open()
        {
            impl.RawOpen();
        }

        public void Print()
        {
            impl.RawPrint();
        }

        public void Close()
        {
            impl.RawClose();
        }

        public void DisplayAll()
        {
            Open();
            Print();
            Close();
        }
    }
}

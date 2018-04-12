﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class GraphObserver : Observer
    {
        public void Update(NumberGenerator generator)
        {
            Console.WriteLine("GraphObserver:");
            int count = generator.GetNumber();

            for (int i = 0; i < count; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            Thread.Sleep(100);
        }
    }
}

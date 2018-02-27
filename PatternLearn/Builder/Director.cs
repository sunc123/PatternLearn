using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class Director
    {
        private Builder builder;

        public Director(Builder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            builder.MakeTitle("Greeting");
            builder.MakeString("从早上到下午");
            builder.MakeItems(new string[]{ "早上好", "下午好" });

            builder.MakeString("晚上");
            builder.MakeItems(new string[] { "晚上好", "晚安", "再见" });
            builder.Close(); 
        }
    }
}

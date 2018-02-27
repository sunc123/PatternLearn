using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class TextBuilder : Builder
    {
        private StringBuilder builder = new StringBuilder();

        public override void MakeTitle(string title)
        {
            builder.Append("==========\n");
            builder.Append("[" + title + "]\n");
            builder.Append("\n");
        }

        public override void MakeString(string str)
        {
            builder.Append('#' + str + "\n");
            builder.Append("\n");
        }

        public override void MakeItems(string[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                builder.Append("  -" + items[i] + "\n");
            }
            builder.Append("\n");
        }

        public override void Close()
        {
            builder.Append("==========\n");
        }

        public override string ToString()
        {
            return builder.ToString();
        }
    }
}

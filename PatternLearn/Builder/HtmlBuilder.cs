using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class HtmlBuilder : Builder
    {
        private StringBuilder builder = new StringBuilder();

        public override void MakeTitle(string title)
        {
            builder.Append("<html><head><title>" + title + "</title><head><body>");
            builder.Append("\n");
            builder.Append("<h1>" + title + "</h1>");
            builder.Append("\n");
        }

        public override void MakeString(string str)
        {
            builder.Append("<p>" + str + "</p>");
            builder.Append("\n");
        }

        public override void MakeItems(string[] items)
        {
            builder.Append("<ul>");
            for (int i = 0; i < items.Length; i++)
            {
                builder.Append("\t<li>" + items[i] + "</li>");
                builder.Append("\n");
            }
            builder.Append("</ul>");
            builder.Append("\n");
        }

        public override void Close()
        {
            builder.Append("</body></html>");
        }

        public override string ToString()
        {
            return builder.ToString();
        }
    }
}

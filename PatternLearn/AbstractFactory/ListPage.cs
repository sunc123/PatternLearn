using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class ListPage : Page
    {
        public ListPage(string title, string author) : base(title, author)
        {
        }

        public override string MakeHTML()
        {
            StringBuilder buffer = new StringBuilder();

            buffer.Append("<html><head><title>" + title + "</title><head>\n");
            buffer.Append("<body>\n");
            buffer.Append("<h1>" + title + "</h1>");
            buffer.Append("<ul>\n");
            content.ForEach(item => buffer.Append(item.MakeHtml()));
            buffer.Append("</ul>\n");
            buffer.Append("<hr><address>" + author + "</address>");
            buffer.Append("</body></html>\n");
            return buffer.ToString();
        }
    }
}

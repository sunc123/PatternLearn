using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class ListLink : Link
    {
        public ListLink(string caption, string url) : base(caption, url)
        {
        }

        public override string MakeHtml()
        {
            return "\t<li><a href=\"" + url + "\">" + caption + "</a></li>\n";
        }
    }
}

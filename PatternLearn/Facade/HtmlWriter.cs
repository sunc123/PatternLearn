using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    internal class HtmlWriter
    {
        private string fileName;

        private StringBuilder str;

        internal HtmlWriter(string name)
        {
            fileName = name;
            str = new StringBuilder();
        }

        internal void Title(string title)
        {
            str.Append("<html>");
            str.Append("<head>");
            str.Append("<title>" + title + "</title>");
            str.Append("</head>");
            str.Append("<body>\n");
            str.Append("<h1>" + title + "</h1>\n");
        }

        internal void Paragraph(string msg)
        {
            str.Append("<p>" + msg + "</p>\n");
        }

        internal void Link(string href, string caption)
        {
            Paragraph("<a href=\"" + href + "\">" + caption + "</a>");
        }

        internal void MailTo(string mailaddr, string username)
        {
            Link("mailto:" + mailaddr, username);
        }

        internal void Close()
        {
            str.Append("</body>");
            str.Append("</html>\n");

            System.IO.File.WriteAllText(fileName, str.ToString(), Encoding.UTF8);   
        }
    }
}

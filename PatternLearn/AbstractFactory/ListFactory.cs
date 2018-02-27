using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class ListFactory : AFFactory
    {
        public override Link CreatLink(string caption, string url)
        {
            return new ListLink(caption, url);
        }

        public override Tray CreatTray(string caption)
        {
            return new ListTray(caption);
        }

        public override Page CreatPage(string title, string author)
        {
            return new ListPage(title, author);
        }

        
    }
}

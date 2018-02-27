using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public abstract class AFFactory
    { 
        public abstract Link CreatLink(string caption, string url);
        public abstract Tray CreatTray(string caption);
        public abstract Page CreatPage(string title, string author);
    }
}

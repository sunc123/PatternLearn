using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class PrintBanner : Print
    {
        private Banner banner;

        public PrintBanner(Banner banner)
        {
            this.banner = banner;
        }

        public void PrintStrong()
        {
            banner.ShowWithParen();
        }

        public void PrintWeak()
        {
            banner.ShowWithAster();
        }
    }
}

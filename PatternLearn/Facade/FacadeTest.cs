using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class FacadeTest
    {
        public static void Test()
        {
            PageMaker.MakeWelcomePage("hyuki@hyuki.com", "welcome.html");
            PageMaker.MakeLinkPage("link page.html");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class AbstractFactoryTest
    {
        public static void Test()
        {
            AFFactory factory = new ListFactory();

            Link people = factory.CreatLink("人民日报", "http://www.people.com.cn");
            Link gmw = factory.CreatLink("光明日报", "http://www.gmw.com.cn");

            Link us_yahoo = factory.CreatLink("Yahoo!", "http://www.yahoo.com");
            Link jp_yahoo = factory.CreatLink("Yahoo!Japan", "http://www.yahoo.co.jp/");
            Link excite = factory.CreatLink("Excite", "http://www.excite.com");
            Link google = factory.CreatLink("Google", "http://www.google.com");

            Tray traynews = factory.CreatTray("日报");
            traynews.Add(people);
            traynews.Add(gmw);

            Tray trayyahoo = factory.CreatTray("Yahoo!");
            trayyahoo.Add(us_yahoo);
            trayyahoo.Add(jp_yahoo);

            Tray trayserch = factory.CreatTray("检索引擎");
            trayserch.Add(trayyahoo);
            trayserch.Add(excite);
            trayserch.Add(google);

            Page page = factory.CreatPage("LinkPage", "sunc");
            page.Add(traynews);
            page.Add(trayyahoo);
            page.Add(trayserch);
            page.Output();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class PropertiesPrint
    {
        private Properties properties;

        public PropertiesPrint(Properties properties)
        {
            this.properties = properties;
        }

        public void SetValue(string key, string value)
        {
            properties.SetValue(key, value);
        }

        public void Print()
        {
            DateTime now = DateTime.Now;

            Console.WriteLine("#written by PropertiesPrint");
            Console.WriteLine(string.Format("#{0} {1} {2} {3} {4} {5}",
                                            now.DayOfWeek.ToString(""),
                                            now.Month,
                                            now.Day,
                                            now.TimeOfDay,
                                            now.Kind,
                                            now.Year));
            Console.WriteLine(now.ToString("#ddd MMM ttt hh:mm:ss fff yyy"));

            Console.WriteLine("#" + now.ToString("R"));

            foreach (var item in properties.PropertiesDict)
            {
                Console.WriteLine(string.Format("{0}={1}", item.Key, item.Value));
            }
        }
    }
}

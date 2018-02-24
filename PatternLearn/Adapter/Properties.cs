using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class Properties
    {
        private Dictionary<string, string> properties = new Dictionary<string, string>();

        public Dictionary<string, string> PropertiesDict { get { return properties; } }

        public Properties(string[] strings)
        {
            foreach (var item in strings)
            {   
                if (!properties.ContainsKey(item))
                {
                    properties.Add(item, string.Empty);
                }
            }
        }

        public void SetValue(string key, string value)
        {
            if (!properties.ContainsKey(key))
            {
                properties.Add(key, value);
            }
            else
            {
                properties[key] = value;
            }
        }

        public void Print()
        {
            foreach (var item in properties)
            {
                Console.WriteLine( string.Format("[{0}: {1}]", item.Key, item.Value));
            }
        }
    }
}

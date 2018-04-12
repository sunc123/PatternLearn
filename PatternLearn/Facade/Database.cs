using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    internal class Database
    {
        private static string str = "hyuki@hyuki.com=Hiroshi Yuki\nhanako@hyuki.com=Hanako Sato\ntomura@hyuki.com=Tomura\nmamoru@hyuki.com=Mamoru Takahashi";

        private Database() { }

        internal static Properties2 GetProperties(string dbName)
        {
            Properties2 p = new Properties2();

            string[] strs = str.Split('\n');

            for (int i = 0; i < strs.Length; i++)
            {
                string[] temp = strs[i].Split('=');

                p.Add(new Property(temp[0], temp[1]));
            }       
            return p;
        }  
    }

    internal class Properties2 : IEnumerable<Property>
    {
        List<Property> list;

        internal Properties2()
        {
            list = new List<Property>();
        }

        internal string GetProperty(string mailName)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Key == mailName)
                {
                    return list[i].Value;
                }
            }   
            return string.Empty;
        }

        internal void Add(Property p)
        {
            list.Add(p);
        } 

        IEnumerator<Property> IEnumerable<Property>.GetEnumerator()
        {
            foreach (Property t in list)
            {
                yield return t;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (Property t in list)
            {
                yield return t;
            }
        }
    }

    internal class Property
    {
        string key;
        string value;

        internal string Key { get { return key; } }
        internal string Value { get { return value; } }

        internal Property(string key, string value)
        {
            this.key = key;
            this.value = value;
        }
    }
}

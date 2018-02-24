using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class Singleton3
    {
        private int id;

        private static Singleton3[] instances = new Singleton3[3];
        
        private Singleton3(int id)
        {
            this.id = id;
            Console.WriteLine("creat {0} singleton3.", id);
        }
        
        public static Singleton3 GetInstance(int id)
        {
            if (id >= 0 && id <3)
            {
                if (Equals(instances[id], null))
                {
                    instances[id] = new Singleton3(id);
                }
                return instances[id];
            }
            else
            {
                return null;
            }
        } 

        public void Blank()
        {
            Console.WriteLine("访问的是第{0}个Singleton3.", id);
        }
    }
}

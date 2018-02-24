using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class Singleton2
    {
        private static Singleton2 instance;

        public static Singleton2 Instance
        {
            get
            {
                if (Equals(instance, null))
                {
                    instance = new Singleton2();
                }
                return instance;
            }
        }

        private Singleton2()
        {
            Console.WriteLine("creat Singleton2.");
        }

        public void Blank()
        {

        }
    }
}

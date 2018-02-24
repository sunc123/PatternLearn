using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class SingletonTest
    {
        public static void Test()
        {
            Singleton1.Instance.Blank();

            Singleton2.Instance.Blank();

            Singleton3.GetInstance(0).Blank();

            Singleton3.GetInstance(2).Blank();

            Singleton3.GetInstance(1).Blank();

            //Singleton3.GetInstance(3).Blank();
        }
    }
}

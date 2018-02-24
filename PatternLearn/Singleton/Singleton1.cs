using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class Singleton1
    {
        private static Singleton1 instance = new Singleton1();

        public static Singleton1 Instance { get { return instance; } }

        private Singleton1()
        {
            Console.WriteLine("creat singleton1.");
        }

        public void Blank()
        {

        }
    }
}

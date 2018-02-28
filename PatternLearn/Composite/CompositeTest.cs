using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class CompositeTest
    {
        public static void Test()
        {
            Console.WriteLine("Creating Root...");

            Directory root = new Directory("root");
            Directory bind = new Directory("bind");
            Directory tmp = new Directory("tmp");
            Directory usr = new Directory("usr");

            root.Add(bind).Add(tmp).Add(usr);

            bind.Add(new File("vi", 10000));
            bind.Add(new File("latex", 20000));
            root.Print();

            Console.WriteLine("");
            Console.WriteLine("Creating user");

            Directory yuki = new Directory("yuki");
            Directory hanako = new Directory("hanako");
            Directory tomura = new Directory("tomura");

            usr.Add(yuki).Add(hanako).Add(tomura);

            yuki.Add(new File("diary.html", 100));
            yuki.Add(new File("Composite.java", 200));
            hanako.Add(new File("memo.tex", 300));
            tomura.Add(new File("game.doc", 400));
            tomura.Add(new File("junk.mail", 500));

            root.Print();

            Console.WriteLine("");
            Console.WriteLine("Test Path...");
            Console.WriteLine("{0}'s Path is {1}", yuki.GetName(), yuki.GetPath());
        }

    }
}

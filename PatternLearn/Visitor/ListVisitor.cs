using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class ListVisitor : Visitor
    {
        private string currentdir = "";

        public override void Visit(Directory directory)
        {
            Console.WriteLine(currentdir + "/" + directory.GetName());

            string savedir = currentdir;

            currentdir = currentdir + "/" + directory.GetName();
                
            foreach (var item in directory)
            {
                item.Accept(this);
            }

            currentdir = savedir;
        }

        public override void Visit(File file)
        {
            Console.WriteLine(currentdir + "/" + file.GetName());
        }
    }
}

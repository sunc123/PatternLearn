using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public abstract class Support
    {
        private string name;

        private Support next;

        public Support Next { get { return next; } }

        public Support(string name)
        {
            this.name = name;
        }

        public Support SetNext(Support next)
        {
            this.next = next;

            return next;
        }

        public void SupportTrouble(Trouble trouble)
        {   
            /*递归*/
                
            //if (Resolve(trouble))
            //{             
            //    Done(trouble);
            //}
            //else if(Next != null)
            //{                         
            //    Next.SupportTrouble(trouble);
            //}
            //else
            //{                         
            //    Fail(trouble);
            //}


            /*迭代*/
            Support current = this;
                
            do
            {     
                if (current.Resolve(trouble))
                {
                    current.Done(trouble);
                    break;
                }
                else if (current.Next != null)
                {
                    current = current.Next;
                }
                else
                {
                    current.Fail(trouble);
                    break;
                }
            } while (true);
        } 

        protected abstract bool Resolve(Trouble trouble);

        protected void Done(Trouble trouble)
        {
            Console.WriteLine(trouble.ToString() + " is resolved by " + ToString() + ".");
        }

        protected void Fail(Trouble trouble)
        {
            Console.WriteLine(trouble.ToString() + " cannot be resolved.");
        }

        public override string ToString()
        {
            return "[" + name + "]";
        }
    }
}

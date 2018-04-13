using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class MacroCommand : Command
    {
        private Stack<Command> commands = new Stack<Command>();

        public int Length { get { return commands.Count; } }

        public void Execute()
        {
            Console.WriteLine(commands.Count);

            foreach (var item in commands)
            {
                item.Execute();
            } 
        }

        public void Append(Command cmd)
        {
            if (cmd != this)
            {
                commands.Push(cmd);
            }
        }

        public void Undo()
        {
            if (commands.Count > 0)
            {
                commands.Pop();
            }
        }

        public void Clear()
        {
            commands.Clear();
        }

        public Command Peek()
        {
            if (commands.Count > 0)
            {
                return commands.Peek();
            }
            return null;
        }
    }
}

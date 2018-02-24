using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class MessageBox : IClone
    {
        private char mChar;

        public MessageBox(char mChar)
        {
            this.mChar = mChar;
        }

        public IClone Clone()
        {
            return new MessageBox(mChar);
        }

        public void Use(string str)
        {
            int length = str.Length + 2;

            DrawLine(length);
            Console.Write("|");
            Console.Write(str);
            Console.Write("|");
            Console.WriteLine();
            DrawLine(length);
            Console.WriteLine();
        }

        private void DrawLine(int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(mChar);
            }
            Console.WriteLine();
        }
    }
}

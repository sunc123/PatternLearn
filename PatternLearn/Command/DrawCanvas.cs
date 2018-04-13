using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class DrawCanvas : Drawable
    {
        private int radius = 10;

        private char[,] canvas;

        private MacroCommand history;
        public DrawCanvas()
        {
            canvas = new char[radius, radius];

            history = new MacroCommand();
        }

        public void Paint()
        {      
            Console.Clear(); 

            for (int i = 0; i < canvas.GetLength(0); i++)
            {
                for (int j = 0; j < canvas.GetLength(1); j++)
                {
                    Console.Write(canvas[i, j]);
                }
                Console.WriteLine();
            }   
            Console.WriteLine(history.Length);
        }

        public void Draw(int x, int y)
        {
            history.Append(new DrawCommand(this, x, y));
                            
            history.Execute(); 
        }

        //=========================== 

        public void Draw(int x, int y, char ch)
        {
            canvas[x, y] = ch;
        }

        public void Undo()
        {
            history.Undo();

            canvas = new char[radius, radius];

            history.Execute();
        }
    }
}

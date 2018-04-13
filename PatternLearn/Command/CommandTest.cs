using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class CommandTest
    {
        public static void Test()
        {
            DrawCanvas canvas = new DrawCanvas();

            while (true)
            {
                canvas.Paint();

                Console.ReadKey();

                Random r = new Random();

                if (r.Next(10) >= 5)
                {
                    canvas.Undo();
                }
                else
                {
                    canvas.Draw(r.Next(10), r.Next(10));
                } 
            }
        }
    }
}

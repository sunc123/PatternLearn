using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    class DrawCommand : Command
    {
        private Drawable canvas;

        private int x, y;

        public DrawCommand(Drawable canvas, int x, int y)
        {
            this.canvas = canvas;
            this.x = x;
            this.y = y;
        }

        public void Execute()
        {
            canvas.Draw(x, y, 'a');
        }
    }
}

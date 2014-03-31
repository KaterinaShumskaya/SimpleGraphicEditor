using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGraphicEditor
{
    using System.Drawing;

    class Rectangle : Shape
    {
        public Rectangle(int x1, int y1) : base (x1, y1)
        {
        }

        public override void Draw(Graphics gr, Color color)
        {
            using (var pen = new Pen(color))
            {
               gr.DrawRectangle(pen, X1, Y1, X2 - X1, Y2 - Y1); 
            }
        }
    }
}

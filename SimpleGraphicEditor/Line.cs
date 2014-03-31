using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGraphicEditor
{
    using System.Drawing;

    public class Line : Shape
    {
        public Line(int x, int y) : base(x, y)
        {
        }

        public override void Draw(Graphics gr, Color color)
        {
            using (var p = new Pen(color))
            {
                gr.DrawLine(p, X1, Y1, X2, Y2); 
            }          
        }
    }
}

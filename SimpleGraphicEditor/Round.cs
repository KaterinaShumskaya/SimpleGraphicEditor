using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGraphicEditor
{
    using System.Drawing;

    public class Round : Shape
    {
        public Round(int x1, int y1)
            : base(x1, y1)
        {
        }

        public override void Draw(Graphics gr, Color color)
        {
            gr.FillEllipse(new SolidBrush(color), new System.Drawing.Rectangle(X1, Y1, X2-X1, Y2-Y1));
        }
    }
}

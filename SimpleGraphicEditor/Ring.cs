using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGraphicEditor
{
    using System.Drawing;

    public class Ring : Shape
    {
        public Ring(int x1, int y1, int d)
            : base(x1, y1)
        {
            D = d;
        }

        public int D { get; protected set; }

        public override void Draw(Graphics gr, Color color)
        {

            var circle1 = new Circle(X1, Y1);
            circle1.X2 = X2;
            circle1.Y2 = Y2;
            circle1.Draw(gr, color);
            var circle2 = new Circle(X1 + D, Y1 + D);
            circle2.X2 = X2 - D;
            circle2.Y2 = Y2 - D;
            circle2.Draw(gr, color);

        }
    }
}

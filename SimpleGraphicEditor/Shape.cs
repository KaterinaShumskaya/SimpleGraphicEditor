using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGraphicEditor
{
    using System.Drawing;

    public abstract class Shape
    {
        public Shape(int x1, int y1)
        {
            X1 = x1;
            Y1 = y1;
        }

        public int X1 { get; set; }

        public int X2 { get; set; }

        public int Y1 { get; set; }

        public int Y2 { get; set; }

        public abstract void Draw(Graphics gr, Color color);
    }
}

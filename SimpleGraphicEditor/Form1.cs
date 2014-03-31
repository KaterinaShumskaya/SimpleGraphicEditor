using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleGraphicEditor
{
    public partial class Form1 : Form
    {
        private List<Shape> _shapes = new List<Shape>();
        private bool _isDrawing;

        private Shape _currentFigure;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void DrawAll(Graphics gr)
        {
            foreach (var shape in _shapes)
            {
                shape.Draw(gr, Color.Black);
            }                                       
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _isDrawing = true;

            if (radioButton1.Checked)
            {
                _currentFigure = new Line(e.X, e.Y);
            }
            else if (radioButton2.Checked)
            {
                _currentFigure = new Circle(e.X, e.Y);
            }
            else if (radioButton3.Checked)
            {
                _currentFigure = new Rectangle(e.X, e.Y);
            }
            else if (radioButton4.Checked)
            {
                _currentFigure = new Ring(e.X, e.Y, 5);
            }
            else
            {
                _currentFigure = new Round(e.X, e.Y);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDrawing)
            {
                _currentFigure.X2 = e.X;
                _currentFigure.Y2 = e.Y;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _shapes.Add(_currentFigure);
            _isDrawing = false;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            this.DrawAll(e.Graphics);
            if (_isDrawing)
            {
                _currentFigure.Draw(e.Graphics, Color.Black);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _shapes.RemoveAll(x => true);
            pictureBox1.Invalidate();
        }
    }
}

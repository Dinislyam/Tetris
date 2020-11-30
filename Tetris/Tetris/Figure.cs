using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    abstract class Figure
    {
        protected Point[] points = new Point[4];

        public void Draw()
        {
            foreach (Point p in points)
            {
                p.Draw();
            }
        }
        internal void Hide()
        {
            foreach(var p in points)
            {
                p.Hide();
            }
        }
        public void Move(Direction dir)
        {
            Hide();
            foreach(Point p in points)
            {

                p.Move(dir);
            }
            Draw();
        }

        public abstract void Rotate();
      
    }
}

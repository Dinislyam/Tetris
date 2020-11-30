using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    abstract class Figure
    {
        const int LENGHT = 4;
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
        //public void Move(Direction dir)
        //{
        //    Hide();
        //    foreach(Point p in points)
        //    {

        //        p.Move(dir);
        //    }
        //    Draw();
        //}
        public void Move(Point[] plist, Direction dir)
        {
            foreach (Point p in plist)
            {
                p.Move(dir);
            }
        }
        public abstract void Rotate(Point[] plist);

        internal void TryMove(Direction dir)
        {
            Hide();
            var clone = Clone();
            Move(clone, dir);
            if (VerifyPosition(clone))
                points = clone;

            Draw();
        }

        private bool VerifyPosition(Point[] plist)
        {
            foreach(var p in plist)
            {
                if (p.x < 0 || p.y < 0 || p.x >= 40 || p.y >= 30)
                    return false;
            }
            return true;
        }

        internal void TryRotate()
        {
            Hide();
            var clone = Clone();
            Rotate(clone);
            if (VerifyPosition(clone))
                points = clone;

            Draw();
        }

        private Point[] Clone()
        {
            var newPoints = new Point[LENGHT];
            for (int i = 0; i < LENGHT; i++)
            {
                newPoints[i] = new Point(points[i]);
            }
            return newPoints;
        }
    }
}

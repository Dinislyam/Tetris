using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    abstract class Figure
    {
        const int LENGHT = 4;
        public Point[] Points = new Point[4];

        public void Draw()
        {
            foreach (Point p in Points)
            {
                p.Draw();
            }
        }
        internal void Hide()
        {
            foreach(var p in Points)
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

        internal Result TryMove(Direction dir)
        {
            Hide();
            var clone = Clone();
            Move(clone, dir);

            var result = VerifyPosition(clone);
            if (result == Result.SUCCES)
                Points = clone;

            Draw();

            return result;
        }

        private Result VerifyPosition(Point[] newPoints)
        {
            foreach(var p in newPoints)
            {
                if (p.Y >= Field.Height)
                    return Result.DOWN_BORDER_STRIKE;
                if (p.X  == Field.Width || p.X < 0 || p.Y < 0)
                    return Result.BORDER_STRIKE;
                if (Field.CheckStrike(p))
                    return Result.HEAP_STRIKE;
            }
            return Result.SUCCES;
        }

        internal Result TryRotate()
        {
            Hide();
            var clone = Clone();
            Rotate(clone);

            var result = VerifyPosition(clone);
            if (result == Result.SUCCES)
                Points = clone;

            Draw();

            return result;
        }

        private Point[] Clone()
        {
            var newPoints = new Point[LENGHT];
            for (int i = 0; i < LENGHT; i++)
            {
                newPoints[i] = new Point(Points[i]);
            }
            return newPoints;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Point
    {
        public int X { get; set; }
        public int Y
        public char C
        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(C);
            Console.SetCursorPosition(0, 0);
        }
        public Point(int a, int b, char sym)
        {
            X = a;
            Y = b;
            C = sym;
        }

        public Point(Point p)
        {
            X = p.X;
            Y = p.Y;
            C = p.C;
        }
        internal void Hide()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(' ');
        }

        internal void Move(Direction dir)
        {
            switch (dir)
            {
                case Direction.DOWN:
                    Y += 1;
                    break;
                case Direction.RIGHT:
                    X += 1;
                    break;
                case Direction.LEFT:
                    X -= 1;
                    break;
            }
        }

        public Point() { }
    }
}

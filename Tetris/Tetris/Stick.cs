using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris 
{
    class Stick : Figure
    {
        
        public Stick(int x, int y, char sym)
        {
            points[0] = new Point(x, y, sym);
            points[1] = new Point(x, y + 1, sym);
            points[2] = new Point(x, y + 2, sym);
            points[3] = new Point(x, y + 3, sym);
            Draw();
        }

        public override void Rotate(Point[] plist)
        {
            if (plist[0].X == plist[1].X)
            {
                RotateHorizontal(plist);
            }
            else
            {
                RotateVertical(plist);
            }
        }

        private void RotateVertical(Point[] plist)
        {
            for (int i = 0; i < plist.Length; i++)
            {
                plist[i].X = plist[0].X;
                plist[i].Y = plist[0].Y + i;
            }
        }

        private void RotateHorizontal(Point[] plist)
        {
            for (int i = 0; i < plist.Length; i++)
            {
                plist[i].Y = plist[0].Y;
                plist[i].X = plist[0].X + i;
            }


        }
    }
}

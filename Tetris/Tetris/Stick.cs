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
            if (plist[0].x == plist[1].x)
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
                plist[i].x = plist[0].x;
                plist[i].y = plist[0].y + i;
            }
        }

        private void RotateHorizontal(Point[] plist)
        {
            for (int i = 0; i < plist.Length; i++)
            {
                plist[i].y = plist[0].y;
                plist[i].x = plist[0].x + i;
            }


        }
    }
}

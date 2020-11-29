using System;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);
            Square s = new Square(10, 5, '*');
            s.Draw();

            Point p1 = new Point(5, 4, '*');
            p1.Draw();            
        }
        
    }
}

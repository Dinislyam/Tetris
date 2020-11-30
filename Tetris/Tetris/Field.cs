using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    static class Field
    {
        private static int _width = 40;
        private static int _height = 30;
        public static int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
                Console.SetWindowSize(40, 30);
                Console.SetBufferSize(40, 30);
            }
        }
        public static int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
                Console.SetWindowSize(_width, _height);
                Console.SetBufferSize(_width, _height);
            }
        }

    }
}

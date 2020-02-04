using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.SetBufferSize(120, 30);
            HorizontalLine upline = new HorizontalLine(0,118,0,'+');
            upline.Drow();

            HorizontalLine downline = new HorizontalLine(0, 118, 28, '+');
            downline.Drow();

            VerticalLine leftline = new VerticalLine(0, 28, 0, '+');
            leftline.Drow();

            VerticalLine rightline = new VerticalLine(0, 28, 118, '+');
            rightline.Drow();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            Console.ReadLine();
        }
    }
}

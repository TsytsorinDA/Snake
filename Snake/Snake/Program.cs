using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);

            Console.SetBufferSize(80, 25);

            HorizontalLine Hline = new HorizontalLine(0, 78, 0, '*');
            Hline.Drow();
            Hline = new HorizontalLine(0, 78, 24, '*');
            Hline.Drow();
            VerticalLine Vline = new VerticalLine(0, 24, 0, '*');
            Vline.Drow();
            Vline = new VerticalLine(0, 24, 78, '*');
            Vline.Drow();


            Snake snake = new Snake(new Point(78 / 2, 24 / 2, '+'), 4, Direction.Down);
            snake.Drow();

            Console.ReadKey();
        }
    }
}

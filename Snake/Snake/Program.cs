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
            HorizontalLine Hline = new HorizontalLine(5, 10, 8, '*');
            Hline.Drow();
            VerticalLine Vline = new VerticalLine(8, 13, 5, '*');
            Vline.Drow();

            Console.ReadKey();
        }
    }
}

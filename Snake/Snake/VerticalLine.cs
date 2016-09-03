using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class VerticalLine
    {
        List<Point> pList;
        public VerticalLine(int yLeft, int yRight, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yLeft; y <= yRight; y++)
            {
                pList.Add(new Point(x, y, sym));
            }

        }
        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}

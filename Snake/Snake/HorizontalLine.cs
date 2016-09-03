using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> pList;

        public HorizontalLine(int xLeft, int xRight,int y, char sym)
        {
            pList = new List<Point>();
            for(int x = xLeft; x <= xRight; x++)
            {
                pList.Add(new Point(x, y, sym));
            }
        }
        public void Drow()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }

}

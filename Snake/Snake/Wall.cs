using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Walls
    {
        List<Figure> m_wallList;
        public Walls(int xMax, int yMax)
        {
            m_wallList = new List<Figure>();

            m_wallList.Add(new HorizontalLine(0, xMax - 2, 0, '+'));
            m_wallList.Add(new HorizontalLine(0, xMax - 2, yMax - 1, '+'));
            m_wallList.Add(new VerticalLine(0, yMax - 1, 0, '+'));
            m_wallList.Add(new VerticalLine(0, yMax - 1, xMax - 2, '+'));
        }
        internal bool IsHit(Figure figure)
        {
            foreach(var wall in m_wallList)
            {
                if(wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
        public void Draw()
        {
            foreach (var wall in m_wallList)
            {
                wall.Drow();
            }
        }
    }
}

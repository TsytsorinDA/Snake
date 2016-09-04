using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()
        {

        }
        public Point(int m_x, int m_y, char m_sym)
        {
            x = m_x;
            y = m_y;
            sym = m_sym;
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        public void Move(int offset,Direction direction)
        {
            if(direction == Direction.Right)
            {
                x += offset;
            }
            else if (direction == Direction.Left)
            {
                x -= offset;
            }
            else if (direction == Direction.Down)
            {
                y += offset;
            }
            else if (direction == Direction.Up)
            {
                y -= offset;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}

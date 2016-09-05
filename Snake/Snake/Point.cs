using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake
{
    class Point
    {
        public int m_x;
        public int m_y;
        public char m_sym;

        public Point()
        {

        }
        public Point(int x, int y, char sym)
        {
            m_x = x;
            m_y = y;
            m_sym = sym;
        }
        public Point(Point p)
        {
            m_x = p.m_x;
            m_y = p.m_y;
            m_sym = p.m_sym;
        }
        public void Move(int offset,Direction direction)
        {
            if(direction == Direction.Right)
            {
                m_x += offset;
            }
            else if (direction == Direction.Left)
            {
                m_x -= offset;
            }
            else if (direction == Direction.Down)
            {
                m_y += offset;
            }
            else if (direction == Direction.Up)
            {
                m_y -= offset;
            }
        }

        internal void Clear()
        {
            m_sym = ' ';
            Draw();
        }

        public void Draw()
        {
            Console.SetCursorPosition(m_x, m_y);
            Console.Write(m_sym);
        }

        internal bool IsHit(Point Pfood)
        {
            bool res = Pfood.m_x == m_x && Pfood.m_y == m_y;
            return res;
        }
        public override string ToString()
        {
            return String.Format("m_x = {0},m_y = {1}, m_sym = {2}", m_x, m_y, m_sym);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Snake :Figure
    {
        Direction m_direction;

        public Snake(Point tail, int lenght,Direction direction)
        {
            m_direction = direction;
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }
        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point newPoint = new Point(head);
            newPoint.Move(1, m_direction);
            return newPoint;
        }

        internal void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                m_direction = Direction.Left;
            }
            else if (key == ConsoleKey.RightArrow)
            {
                m_direction = Direction.Right;
            }
            else if (key == ConsoleKey.UpArrow)
            {
                m_direction = Direction.Up;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                m_direction = Direction.Down;
            }
        }
    }
}

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
            Point NextPoint = new Point(head);
            NextPoint.Move(1, m_direction);
            return NextPoint;
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
        public bool Eat(Point food)
        {
            bool res = false;
            Point head = pList.Last();
            //Point CurrentPoint = pList.Last();
            //if((CurrentPoint.m_x == food.m_x - 1) || (CurrentPoint.m_x == food.m_x + 1) || (CurrentPoint.m_y == food.m_y - 1) || (CurrentPoint.m_y == food.m_y + 1))
            //{

            //}
            if (head.IsHit(food))
            {
                head.Draw();
                food.m_sym = head.m_sym;
                pList.Add(food);
                return true;
            }

            return res;
        }
        public List<Point> GetSnake()
        {
            return pList;
        }
    }
}

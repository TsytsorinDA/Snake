using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class FoodCreator
    {
        int m_height;
        int m_width;
        char m_char;

        Random random = new Random();

        public FoodCreator(int xMax, int yMax,char sym)
        {
            m_width = xMax;
            m_height = yMax;
            m_char = sym;
        }
        public Point CreateFood(List<Point> snake)
        {
            int x = random.Next(2, m_width - 2);
            int y = random.Next(2, m_height - 2);
            Point food = new Point(x, y, m_char);

            foreach (Point p in snake)
            {
                if (p.IsHit(food))
                {
                    food = CreateFood(snake);
                    break;
                }
            }
            return food;
        }
    }
}

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
            List<char> listchar = new List<char>();
            listchar.Add('@');
            listchar.Add('#');
            listchar.Add('$');
            listchar.Add('%');

            int x = 0;
            int y = 1;

            List<Point> listpoint = new List<Point>();

            foreach (char i in listchar)
            {
                listpoint.Add(new Point(x, y, i));
                x++;
                y++;
            }

            foreach (Point i in listpoint)
            {
                i.Draw();
            }


            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);

            Console.SetBufferSize(80, 25);

            Walls wall = new Walls(80, 25);
            wall.Draw();

            Snake snake = new Snake(new Point(78 / 2, 24 / 2, '*'), 4, Direction.Down);
            snake.Drow();

            FoodCreator foodcreator = new FoodCreator(80, 25, '$');
            Point food = foodcreator.CreateFood(snake.GetSnake());
            food.Draw();

            while (true)
            {
                if(wall.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }

                if (snake.Eat(food))
                {
                    food = foodcreator.CreateFood(snake.GetSnake());
                    food.Draw();
                }


                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(200);
                snake.Move();
            }
        }
    }
}

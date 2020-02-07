using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Walls walls = new Walls(120, 30);
            walls.Draw();

            FoodCreator foodCreator = new FoodCreator(110, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            while (true)
            {
                if (snake.Eat (food))
                {
                    snake.Draw();
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                else
                {
                    snake.Move();
                }
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                    walls.Draw();
                }
                Thread.Sleep(85);
            }
            Console.Clear();
            Console.WriteLine("Игра окончена");
            Console.ReadLine();
        }
    }
}

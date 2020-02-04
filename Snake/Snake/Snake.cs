using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake :Figure
    {
        public Direction direction;
        public Snake(Point tail, int lenght, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for(int i=0; i<lenght; i++)
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
            Point nextpoint = new Point(head);
            nextpoint.Move(1, direction);
            return nextpoint;
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.A)
                direction = Direction.LEFT;
            if (key == ConsoleKey.D)
                direction = Direction.RIGHT;
            if (key == ConsoleKey.S)
                direction = Direction.DOWN;
            if (key == ConsoleKey.W)
                direction = Direction.UP;
        }
    }
}
    
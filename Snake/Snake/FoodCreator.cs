using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int mapW;
        int mapH;
        char sym;

        Random random = new Random();
        
        public FoodCreator (int mapW, int mapH, char sym)
        {
            this.mapW = mapW;
            this.mapH = mapH;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapW - 2);
            int y = random.Next(2, mapH - 2);
            return new Point(x, y, sym);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Obstacle : Tile   //Subclass
    {
        public Obstacle(int X, int Y) : base(X, Y)  //  Borders map
        {
            Map[,] map = new Map[Y, X];

            for (int y = 0; y < Y; y++)
            {
                for (int x = 0; x < X; x++)
                {
                    if (y == 0 || y == Y - 1 || x == 0 || x == X - 1)
                    {
                        map[X, Y] = 'X';
                    }  
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class EmptyTile : Tile 
    {
        public EmptyTile(int X, int Y) : base(X, Y) //Denotes empty tiles
        {
            Map[,] map = new Map[Y, X];

            for (int y = 0; y < Y; y++)
            {
                for (int x = 0; x < X; x++)
                {
                    map[Y, X] = '.';
                }
            }
        }
    }
}

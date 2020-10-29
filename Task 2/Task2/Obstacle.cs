using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK1
{
    class Obstacle : Tile
    {
        public Obstacle(int x, int y) : base(x, y)
        {
            int width = x;
            int height = y;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || j == 0 || i == width - 1)
                    {
                        this.x = 'X';
                    }
                }

                this.y = 'X';
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK1
{
    class EmptyTile : Tile
    {
        public EmptyTile(int x, int y) : base(x, y)
        {
            int width = x;
            int height = y;

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    if (i > 0 && i <= width)
                    {
                        //"."
                    }
                }

                //"."
            }
        }
    }
}

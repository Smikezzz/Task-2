using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK1
{
    abstract class Tile
    {
        protected int x;
        protected int y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public enum TileType
        {
            HERO,
            ENEMY,
            GOLD,
            WEAPON
        }

        public Tile(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}

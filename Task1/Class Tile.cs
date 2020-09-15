using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    abstract class Tile //Base class for all in-game objects with positions on map
    {
        protected int X;    //Protected variables
        protected int Y;

        public enum TileType    //Will be used by other classes to define type of tile
        {
            HERO, ENEMY, GOLD, WEAPON
        }

        public int x { get => X; }    //Public accessors
        public int y { get => Y; }

        public Tile(int X, int Y)   //Tile constructor
        {
            X = 0;
            Y = 0;
        }
    }
}

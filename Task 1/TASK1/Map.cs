using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK1
{
    class Map
    {
        private int[,] tile;
        private Hero hero; //how am i gonna enter these values?
        private int[] enemy;
        private int width;
        private int height;
        private Random r = new Random();

        public int[,] TILE { get => tile; set => tile = value; }
        public Hero HERO { get => hero; set => hero = value; }
        public int[] ENEMY { get => enemy; set => enemy = value; }
        public int WIDTH { get => width; set => width = value; }
        public int HEIGHT { get => height; set => height = value; }
        public Random R { get => r; set => r = value; }

        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int enemy)
        {
            enemy = r.Next(2, 5 + 1);

            width = r.Next(minWidth, maxWidth + 1);
            height = r.Next(minHeight, maxHeight + 1);

            TILE = new int[width, height];

            ENEMY = new int[enemy];

            //Create();

            for (int i = 0; i < ENEMY.Length; i++)
            {
                for (int j = 0; j < this.WIDTH; j++)
                {
                    for (int k = 0; k < this.HEIGHT; k++)
                    {
                        //Enemy goblin = new Enemy(goblin.X, goblin.Y, 1, 10, 10, 'G');
                        //UpdateVision(goblin);
                    }
                }
            }

            //Character hero = new Character(hero.X, hero.Y, 'H');
            UpdateVision(hero); //not sure what the question meant if it should be placed inside the loop or outside
        }

        public void UpdateVision(Character unit)
        {
            int north, east, south, west;
            //north
            north = unit.CharVis[unit.X, unit.Y - 1];
            //east
            east = unit.CharVis[unit.X + 1, unit.Y];
            //south
            south = unit.CharVis[unit.X, unit.Y + 1];
            //west
            west = unit.CharVis[unit.X - 1, unit.Y];
            //p.s this is very wrong, i have to figure this out
        }

        private Tile Create(Tile.TileType type)
        {
            int x, y;

            x = r.Next(this.WIDTH, this.HEIGHT);
            y = r.Next(this.WIDTH, this.HEIGHT);

            while (TILE[x,y] == '.')    //very unsure about this
            {
                x = r.Next(this.WIDTH, this.HEIGHT);
                y = r.Next(this.WIDTH, this.HEIGHT);

                //TILE[x, y] = type; 
            }
        }
    }
}

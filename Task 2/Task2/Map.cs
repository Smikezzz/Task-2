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
        private Hero hero;
        private int[] enemy;
        private int width;
        private int height;
        private Random r = new Random();

        private int[,] item;

        public int[,] TILE { get => tile; set => tile = value; }
        public Hero HERO { get => hero; set => hero = value; }
        public int[] ENEMY { get => enemy; set => enemy = value; }
        public int WIDTH { get => width; set => width = value; }
        public int HEIGHT { get => height; set => height = value; }
        public Random R { get => r; set => r = value; }

        public int[,] ITEM { get => item; set => item = value; }

        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int enemy, int gold)
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
                        UpdateVision(enemy);
                    }
                }
            }
            UpdateVision(hero);

            int[] item = new int[gold];
        }

        public void UpdateVision(Character unit)
        {
            int north, east, south, west;   //trying to figure this out
            north = unit.CharVis[unit.X, unit.Y - 1];
            east = unit.CharVis[unit.X + 1, unit.Y];
            south = unit.CharVis[unit.X, unit.Y + 1];
            west = unit.CharVis[unit.X - 1, unit.Y];
        }

        private Tile Create(Tile.TileType type)
        {
            int x, y;

            int gold;

            x = r.Next(this.WIDTH, this.HEIGHT);
            y = r.Next(this.WIDTH, this.HEIGHT);

            gold = r.Next(1, 5 + 1);

            while (TILE[x,y] == '.')    //very unsure about this
            {
                x = r.Next(this.WIDTH, this.HEIGHT);
                y = r.Next(this.WIDTH, this.HEIGHT);

                //TILE[x, y] = type; 

                for (int i = 0; i < gold; i++)
                {
                    x = r.Next(this.WIDTH, this.HEIGHT);
                    y = r.Next(this.WIDTH, this.HEIGHT);
                    TILE[x, y] = 'O';
                }
            }
        }

        public Item GetItemAtPosition(int x, int y)
        {
            for (int i = 0; i < ITEM.Length; i++)
            {
                if (ITEM[x, y] == 'G')
                {
                    ITEM[x, y] = '.';
                    return ;    //What and how to return?
                }
                else
                {
                    if (ITEM[x, y] == 'W')
                    {
                        ITEM[x, y] = '.';
                        return ;    //What and how to return?
                    }
                }
            }
        }
    }
}

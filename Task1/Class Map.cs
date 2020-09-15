using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Map
    {
        private int[,] map;
        private Hero hero = new Hero(0, 0, "H", 100, 100, 2);   //***
        private int[] enemy;
        private int width;
        private int height;
        private Random r = new Random();

        public int[,] MAP { get => map; set => map = value; }
        public Hero HERO { get => hero; set => hero = value; }
        public int[] ENEMY { get => enemy; set => enemy = value; }
        public int WIDTH { get => width; set => width = value; }
        public int HEIGHT { get => height; set => height = value; }
        public Random R { get => r; set => r = value; }

        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int enemyCount)
        {
            width = r.Next(minWidth, maxWidth + 1); //Randomizes height and width based on minimum and maximum values
            height = r.Next(minHeight, maxHeight + 1);

            map = new int[height, width];   //Map array created

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (y == 0 || y == height - 1 || x == 0 || x == width - 1)
                    {
                        map[y, x] = 'X';
                    }
                    else map[y, x] = '.';
                }
            }

            enemy = new int[enemyCount];    //Creates enemy array

            //Create();   //Creates the Hero

            for (int i = 0; i < enemy.Length; i++)
            {
                //Create();   //Creates enemyies
            }

            UpdateVision();
        }

        public void UpdateVision()  //Updates character vision
        {

        }

        /*/private Tile Create(Tile.TileType type) //Creates objects and places them on the map
        {
            return type;
        }/*/
    }
}

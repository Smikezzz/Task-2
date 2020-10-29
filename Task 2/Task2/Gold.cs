using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK1
{
    class Gold : Item
    {
        private int gold;
        private Random r = new Random();

        public int GOLD { get => gold; set => gold = value; }
        public Random R { get => r; set => r = value; }

        public Gold(int x, int y) : base(x, y)
        {
            this.x = r.Next(1, 5 + 1);
            this.y = r.Next(1, 5 + 1);
        }
    }
}

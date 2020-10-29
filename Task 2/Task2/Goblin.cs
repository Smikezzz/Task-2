using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK1
{
    class Goblin : Enemy
    {
        public Goblin(int x, int y) : base(x, y, 1, 10, 10, 'G')
        {
            this.x = x;
            this.y = y;
        }

        public override int ReturnMove(int x, int y)    //what's gonna override?
        {
            int direction;
            int movement;

            while (this.CharVis[x,y] == '.')
            {
                direction = r.Next(1, 2 + 1);

                if (direction == 1)
                {
                    movement = r.Next(-1, 1 + 1);
                    x += movement;
                    return this.CharVis[x, y];
                }
                else
                {
                    if (direction == 2)
                    {
                        movement = r.Next(-1, 1 + 1);
                        y += movement;
                        return this.CharVis[x, y];
                    }
                }
            }
            return this.CharVis[x, y];
        }
    }
}

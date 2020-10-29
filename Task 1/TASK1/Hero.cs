using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK1
{
    class Hero : Character
    {
        public Hero(int x, int y, int hp, int maxHp, int dmg) : base(x, y, 'H')
        {
            dmg = 2;
            this.X = x;
            this.Y = y;
            this.HP = hp;
            this.MaxHP = maxHp;
            this.DMG = dmg;
        }

        public override Movement ReturnMove(Movement move)
        {
            if (this.CharVis[x,y] == '.')   //i have a very bad feeling about this
            {
                return move;
            }
            else
            {
                return Movement.NONE;
            }
        }

        public override string ToString()
        {
            string output;
            output = "\n" + "Player stats:" + "\n" + "HP: " + this.HP + "/" + this.MaxHP + "\n" + "Damage: " + this.DMG + "\n" + "[" + this.X + ", " + this.Y + "]";
            return output;
        }
    }
}

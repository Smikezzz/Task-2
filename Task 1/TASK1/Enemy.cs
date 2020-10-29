using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK1
{
    abstract class Enemy : Character
    {
        protected Random r = new Random();

        public Random Rndm { get => r; set => r = value; }

        public Enemy(int x, int y, int dmg, int hp, int maxHp, char symbol) : base(x, y, symbol)
        {
            this.x = x;
            this.y = y;
            this.Dmg = dmg;
            this.Hp = hp;
            this.MaxHP = maxHp;
            //what to do with the symbol...
        }

        public override string ToString(Enemy enemy)    //override?
        {
            string output;
            output = enemy + " at [" + enemy.X + ", " + enemy.Y + "] (Amount " + enemy.DMG + ")";
            return output;
        }
    }
}

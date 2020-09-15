using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    abstract class Enemy : Character
    {
        protected Random r = new Random();  //For randomising numbers

        public Enemy(int X, int Y, string symbol, int damage, int hp, int MAXhp) : base(X, Y, symbol)
        {
            
        }

        public override string ToString()
        {
            return /*/EnemyClassName + /*/ " at " + X + "," + Y + "(" + DMG + ")"; 
        }
    }
}

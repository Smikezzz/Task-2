using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Goblin : Enemy
    {
        public Goblin(int X, int Y, string symbol, int damage, int hp, int maxHP) : base(Y, X, symbol, damage, hp, maxHP)
        {
            hp = 10;
            damage = 1;
        }

        /*/override int ReturnMove()
        {
            int move = 0;

            return = move;
        }/*/
    }
}

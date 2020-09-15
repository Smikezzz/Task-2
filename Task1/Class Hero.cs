using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Hero : Character
    {
        public Hero(int X, int Y, string symbol, int hp, int maxHP, int damage) : base(X, Y, symbol)
        {
            hp = 100;
            maxHP = 100;
            damage = 2;
        }

        /*/override ReturnMove()
        {
            
        }/*/

        public override string ToString()
        {
            /*/Player Stats:
             * HP: HP/MaxHP
             * Damage: 2
             * [X,Y]/*/
            return "";
        }
    }
}

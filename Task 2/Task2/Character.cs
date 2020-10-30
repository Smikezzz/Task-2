using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK1
{
    class Character : Tile
    {
        protected int HP;
        protected int MAX_HP;
        protected int DMG;
        protected int[,] CHAR_VIS;

        protected int goldPurse;

        public int Hp { get => HP; set => HP = value; }
        public int MaxHP { get => MAX_HP; set => MAX_HP = value; }
        public int Dmg { get => DMG; set => DMG = value; }
        public int[,] CharVis { get => CHAR_VIS; set => CHAR_VIS = value; }

        public int GOLD_PURSE { get => goldPurse; set => goldPurse = value; }

        public enum Movement
        {
            NONE = 0,
            UP = 1,
            DOWN = 2,
            LEFT = 3,
            RIGHT = 4
        }

        public Character(int x, int y, char symbol) : base(x, y)
        {
            this.x = x;
            this.y = y;
            //this.CharVis[x, y] = symbol;    //a bit unsure about this
            this.CharVis[x, y] = CharVis[x + 1, y + 1]; //added this just to choose which one is better to use, it is most likely this one
        }

        public void Attack(Character target)
        {
            Character attacker = this;
            target.HP -= attacker.DMG;
        }

        public bool IsDead()
        {
            if (this.HP <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual bool CheckRange(Character target)
        {
            int range = 1;  //barehanded range is equal to 1

            if (DistanceTo(target) <= range)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int DistanceTo(Character target)
        {
            int xSpaces;
            int ySpaces;
            int totalSpaces;

            xSpaces = this.X - target.X;
            ySpaces = this.Y - target.Y;

            totalSpaces = xSpaces + ySpaces;

            return totalSpaces;
        }

        public void Move(Movement move)
        {
            switch (move)
            {
                case Movement.NONE:
                    X += 0;
                    break;
                case Movement.UP:
                    Y -= 1;
                    break;
                case Movement.DOWN:
                    Y += 1;
                    break;
                case Movement.LEFT:
                    X -= 1;
                    break;
                case Movement.RIGHT:
                    X += 1;
                    break;
            }
        }

        public abstract Movement ReturnMove(Movement move = 0)
        {
            return move;
        }

        public abstract override string ToString();

        public void PickUp(Item i)
        {
            if (i = Gold.TileType.GOLD) //???
            {
                this.GOLD_PURSE += 1;
            }
        }

        public bool MovePlayer(Character.Movement direction)
        {
            bool move = false;

            bool loot = false;

            if (direction == Character.Movement.NONE)
            {
                loot = false;
            }
            else
            {
                loot = true;
            }

            if (loot == true)
            {
                this.GOLD_PURSE += 1;
            }

            return move;
        }
    }
}

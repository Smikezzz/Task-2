using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    abstract class Character : Tile //Base class for Hero and Goblin classes
    {
        protected int HP;   //Protected variables
        protected int maxHP;
        protected int damage;
        protected int[,] CharacterVision;   //Array for character's vision which checks for valid movement

        public enum Movement    //Player's movement
        { 
            NONE, UP, DOWN, LEFT, RIGHT
        }

        public int hp { get => HP; set => HP = value; }    //Public accessors
        public int MAXhp { get => maxHP; set => maxHP = value; }
        public int DMG { get => damage; set => damage = value; }
        public int[,] vision { get => CharacterVision; set => CharacterVision = value; }

        public Character(int X, int Y, string symbol) : base(X, Y)  //Constructor that delegates setting of variables to Tile class via constructor initializer
        {

        }

        public void Attack(/*/Character target/*/)    //Attacks target
        {
            hp -= DMG;
        }

        public bool IsDead()    //Checks if character is dead
        {
            if (hp <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual bool CheckRange()    //Checks if target is in range
        {
            return false;
        }

        private int DistanceTo(/*/Character target/*/)  //Determine distance between character and target
        {
            return 0;
        }

        public void Move(Movement move) //Edits unit's X and Y positions based on movement
        {
            switch (move)
            {
                case Movement.NONE:
                    y = y + 0;
                    break;
                case Movement.UP:
                    y = y + 1;
                    break;
                case Movement.DOWN:
                    y = y - 1;
                    break;
                case Movement.LEFT:
                    x = x - 1;
                    break;
                case Movement.RIGHT:
                    x = x + 1;
                    break;
            }
        }

        public /*/abstract/*/ Movement ReturnMove(Movement move = 0)  //Returns direction of movement based on validity against vision array
        {
            return 0;
        }

        /*/public abstract override ToString()  //Overrides Object ToString() method
        {

        }/*/
    }
}

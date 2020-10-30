using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK1
{
    class GameEngine
    {
        private Map map;

        public Map MAP { get => map; set => map = value; }

        public GameEngine()
        {
            MAP = new Map(4, 10, 4, 10, 3);
        }

        public bool MovePlayer(Character.Movement direction)
        {

        }

        public void EnemyAttacks()
        {
            
        }

        public void MoveEnemies()
        {

        }
    }
}

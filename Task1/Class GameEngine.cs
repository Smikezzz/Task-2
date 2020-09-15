using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class GameEngine
    {
        private string map;

        public string MAP { get => map; set => map = value; }

        public GameEngine()
        {
            Map MAP = new Map(11, 22, 11, 22, 5);   //***

            
        }

        public bool MovePlayer(Character.Movement direction)
        {
            return false;
        }
    }
}

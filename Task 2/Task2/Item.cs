using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK1
{
    abstract class Item : Tile
    {
        public Item(int x, int y) : base(x, y)
        {

        }

        abstract override string ToString()
        {
            //???
        }
    }
}

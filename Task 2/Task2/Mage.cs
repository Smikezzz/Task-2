using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK1
{
    class Mage : Enemy
    {
        public Mage(int x, int y) : base(x, y, 5, 5, 5, 'M')
        {

        }

        public override int ReturnMove()
        {
            return 0;
        }

        public override bool CheckRange()
        {
            if (!(this.CharVis[x + 1, y + 1] == '.' || this.CharVis[x - 1, y - 1] == '.' || this.CharVis[x + 1, y - 1] == '.' || this.CharVis[x - 1, y + 1] == '.'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

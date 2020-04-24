using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwayGameOfLife
{
    public class HighLife : ConwayGameOfLife
    {
        public override bool CellShouldLive(bool livingCell, int neighbourCount)
        {
            // with 3 or 6 neighbour cell will live
            if (neighbourCount == 3 || neighbourCount == 6)
                return true;

            // live cell with 2 or 3 neighbours stays alive
            if (livingCell && neighbourCount == 2) //Je hoeft niet voor 3 te checken want dat gebeurd hierboven al, en als dat gebeurd wordt er al true gereturned
                return true;

            // dead cell
            return false;
        }
    }
}

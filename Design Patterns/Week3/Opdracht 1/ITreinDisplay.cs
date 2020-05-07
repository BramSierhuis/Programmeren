using System;
using System.Collections.Generic;
using System.Text;

namespace Opracht_1
{
    public interface ITreinDisplay
    {
        void Update(string huidigStation, string volgendStation, string spoor, DateTime aankomstTijd);
    }
}

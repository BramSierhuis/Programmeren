using System;
using System.Collections.Generic;
using System.Text;

namespace Opracht_1
{
    public interface ITreinReis
    {
        void AddObserver(ITreinDisplay display);
        void RemoveObserver(ITreinDisplay display);
        void VolgendStation();
        void NieuwDisplay();
    }
}

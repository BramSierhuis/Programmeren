using Opdracht_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Opracht_1
{
    public class TreinController : ITreinController
    {
        private ITreinReis treinReis;

        public TreinController(ITreinReis treinReis)
        {
            this.treinReis = treinReis;
        }

        public void VolgendStation()
        {
            treinReis.VolgendStation();
        }

        public void NieuwDisplay()
        {
            treinReis.NieuwDisplay();
        }
    }
}

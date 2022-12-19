using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    internal class SniperRifle:Weapons
    {
        public SniperRifle()
        {
            CurrentBullets = 7;

            Magazinesize = 7;
            Range = 100;
            NeedsReload = false;
            Weight = 70.5;
            Accesories = "Telescopic Sight";
        }
    }
}

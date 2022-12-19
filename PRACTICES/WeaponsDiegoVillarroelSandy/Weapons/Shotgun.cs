using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    internal class Shotgun : Weapons

    {
        public Shotgun()
        {
            CurrentBullets = 2;
            Magazinesize = 2;
            Range = 5;
            NeedsReload = false;
            Weight = 85.5;
            Accesories = "Lantern";
        }
    }
}

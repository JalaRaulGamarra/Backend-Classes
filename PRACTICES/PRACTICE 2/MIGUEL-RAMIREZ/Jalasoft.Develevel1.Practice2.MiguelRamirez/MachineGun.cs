using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Develevel1.Practice2.MiguelRamirez
{
    public class MachineGun : Weapon
    {
        public bool HasLantern { get; set; }
        public MachineGun() 
        {
            Brand = "Cabela's M";
            Name = "Machine gun qwe";
            MagazineSize = 20;
            Color = "Purple";
            Range = 16;
            NeedsReload = false;
            CurrentBullets = MagazineSize;
            Weigth = 15.3;
            HasLantern = true;
        }
    }
}

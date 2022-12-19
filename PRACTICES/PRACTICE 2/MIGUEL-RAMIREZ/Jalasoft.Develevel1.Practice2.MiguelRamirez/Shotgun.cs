using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Develevel1.Practice2.MiguelRamirez
{
    public class Shotgun : Weapon
    {

        public bool HasLantern { get; set; }
        public Shotgun()
        {
            Brand = "Cabela's S";
            Name = "Shotgun abc";
            MagazineSize = 2;
            Color = "Synthetic Black";
            Range = 5;
            NeedsReload = false;
            CurrentBullets = MagazineSize;
            Weigth = 6.87;
            HasLantern = true;
        }

        public override void Shoot()
        {
            base.Shoot();
            RechargeShotgun();
        }

        public void RechargeShotgun()
        {
            Console.WriteLine("Recharging the shotgun ...");
        }
    }
}

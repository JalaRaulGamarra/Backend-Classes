using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Develevel1.Practice2.MiguelRamirez
{
    public class SniperRifle : Weapon
    {
        public bool HasTelescopicSight { get; set; }
        public SniperRifle()
        {
            Brand = "BARRETT MRAD";
            Name = "Sniper Rifle xyz";
            MagazineSize = 7;
            Color = "Green";
            Range = 100;
            NeedsReload = false;
            CurrentBullets = MagazineSize;
            Weigth = 11.8;
            HasTelescopicSight = true;
        }

        public override void Shoot()
        {
            base.Shoot();
            RechargeSniperRifle();
        }
        public void RechargeSniperRifle()
        {
            Console.WriteLine("Recharging the rifle ...");
        }
    }
}

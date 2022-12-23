using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.Practice2
{
    internal class SniperRifle : Weapon
    {
        private byte recharged = 1;
        public bool HasTelecopicSight { get; set; }
        public SniperRifle()
        {
            this.magazineSize = 7;
            this.shootRange = 100;
            this.currentBullets = magazineSize;
        }

        public void Recharge()
        {
            Console.WriteLine("Recharge Sniper Rifle");
            this.recharged = 1;
        }

        public override void Shoot(int range)
        {
            if (this.currentBullets > 0 && this.recharged == 1)
            {
                Console.WriteLine("Sniper Shoots!");
                this.HitsTarget(range);
                this.currentBullets--;
                this.recharged = 0;
            }
            else
            {
                Console.WriteLine("can't shoot!");
            }
        }
    }
}
